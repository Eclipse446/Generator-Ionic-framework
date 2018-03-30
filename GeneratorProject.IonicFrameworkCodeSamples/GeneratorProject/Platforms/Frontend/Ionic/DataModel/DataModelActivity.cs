﻿using Mobioos.Scaffold.Core.Runtime.Activities;
using System.IO;
using System.Threading.Tasks;
using Mobioos.Scaffold.Infrastructure.Runtime;
using System;
using Mobioos.Foundation.Jade.Models;
using System.Collections.Generic;
using System.Linq;
using Mobioos.Scaffold.Core.Runtime.Attributes;
using Mobioos.Foundation.Prompts.Interfaces;
using System.Text.RegularExpressions;

namespace GeneratorProject.Platforms.Frontend.Ionic
{
    [Activity(Order = 5)]
    public class DataModelActivity : GeneratorActivity
    {
        public DataModelActivity(string name, string basePath)
            : base(name, basePath)
        {
        }

        #region GeneratorActivity Methods

        /// <summary>
        /// Initializing task in the Scaffold runtime.
        /// </summary>
        /// <param name="activityContext">The activityContext which contains the SmartApp's manifeste</param>
        [Task(Order = 1)]
        public async override Task Initializing(IActivityContext activityContext)
        {
            await base.Initializing(activityContext);
        }

        /// <summary>
        /// Prompting users with questions. Responses given will help
        /// the activity bringing more spectifications.
        /// </summary>
        //[Task(2)]
        public override Task Prompting()
        {
            return base.Prompting();
        }

        /// <summary>
        /// Method invoked when prompting user is done and
        /// answers are given.
        /// </summary>
        /// <param name="questions">A list of questions answered.</param>
        protected override void ActivityPrompt_Completed(IEnumerable<IQuestion> questions)
        {
            base.ActivityPrompt_Completed(questions);
        }

        /// <summary>
        /// Writing task in the Scaffold runtime.
        /// </summary>
        [Task(Order = 2)]
        public async override Task Writing()
        {
            if (null == Context.Context.Manifest)
                throw new ArgumentNullException(nameof(Context.Context.Manifest));

            SmartAppInfo smartApp = Context.Context.Manifest;
            TransformDataModels(smartApp);
            await base.Writing();
        }

        #endregion

        #region Writing Methods

        /// <summary>
        /// Generating typescript models of the SmartApp.
        /// In frontend context, essentially backend
        /// models which are used by the viewmodels.
        /// </summary>
        /// <param name="smartApp">A SmartApp's manifeste.</param>
        private void TransformDataModels(SmartAppInfo smartApp)
        {
            List<EntityInfo> layoutApiReferences = new List<EntityInfo>();
            List<EntityInfo> references = new List<EntityInfo>();
            if (smartApp != null
                && smartApp.Version != null
                && smartApp.DataModel != null
                && smartApp.DataModel.Entities.AsEnumerable() != null
                && smartApp.Concerns.AsEnumerable() != null)
            {
                // Search for references in layout's datamodels
                foreach (ConcernInfo concern in smartApp.Concerns.AsEnumerable())
                    if (concern.Layouts.AsEnumerable() != null)
                        foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                            if (layout.DataModel != null && layout.DataModel.References.AsEnumerable() != null)
                                foreach (ReferenceInfo reference in layout.DataModel.References.AsEnumerable())
                                    if (reference.Target != null && !layoutApiReferences.AsEnumerable().Contains(reference.Target))
                                        layoutApiReferences.Add(reference.Target);

                // Search for references in api's datamodels
                foreach (ApiInfo api in smartApp.Api.AsEnumerable())
                    if (api.Actions.AsEnumerable() != null)
                        foreach (ApiActionInfo apiAction in api.Actions.AsEnumerable())
                        {
                            if (apiAction.Parameters.AsEnumerable() != null)
                                foreach (ApiParameterInfo apiActionParameter in apiAction.Parameters.AsEnumerable())
                                    if (apiActionParameter.DataModel != null && apiActionParameter.DataModel.References.AsEnumerable() != null)
                                        foreach (ReferenceInfo reference in apiActionParameter.DataModel.References.AsEnumerable())
                                            if (reference.Target != null && !layoutApiReferences.AsEnumerable().Contains(reference.Target))
                                                layoutApiReferences.Add(reference.Target);

                            if (apiAction.ReturnType != null && apiAction.ReturnType.References.AsEnumerable() != null)
                                foreach (ReferenceInfo reference in apiAction.ReturnType.References.AsEnumerable())
                                    if (reference.Target != null && !layoutApiReferences.AsEnumerable().Contains(reference.Target))
                                        layoutApiReferences.Add(reference.Target);
                        }
                
                // Extract references from these references and generate them
                foreach (EntityInfo entity in layoutApiReferences.AsEnumerable())
                    if (entity.Id != null)
                    {
                        DataModelTemplate dataModelTemplate = new DataModelTemplate(entity);
                        foreach (PropertyInfo property in dataModelTemplate.getReferenceProperties(entity).AsEnumerable())
                        {
                            if (property.Parent != null && property.Id != null && !references.AsEnumerable().Contains((EntityInfo)property.Parent))
                            {
                                EntityInfo parent = (EntityInfo)property.Parent;
                                references.Add(parent);
                                TransformDataModel(parent);
                            }
                            if (property.Target != null && !references.AsEnumerable().Contains(property.Target))
                            {
                                references.Add(property.Target);
                                TransformDataModel(property.Target);
                            }
                        }
                    }

                // Generate base references
                foreach (EntityInfo entity in layoutApiReferences.AsEnumerable())
                    if (entity.Id != null && !references.AsEnumerable().Contains(entity))
                    {
                        references.Add(entity);
                        TransformDataModel(entity);
                    }
            }
        }

        /// <summary>
        /// Generating a typescript model. 
        /// </summary>
        /// <param name="entity">An entity.</param>
        private void TransformDataModel(EntityInfo entity)
        {
            if (entity != null && entity.Id != null)
            {
                string fileToWritePath = "";
                string textToWrite = "";
                if (entity.IsEnum)
                {
                    EnumTemplate enumTemplate = new EnumTemplate(entity);
                    string enumDirectoryPath = Path.Combine(enumTemplate.OutputPath);
                    string enumFilename = CamelCase(entity.Id) + "Enum.ts";
                    fileToWritePath = Path.Combine(BasePath, enumDirectoryPath, enumFilename);
                    textToWrite = enumTemplate.TransformText();
                }
                else
                {
                    DataModelTemplate dataModelTemplate = new DataModelTemplate(entity);
                    string dataModelDirectoryPath = Path.Combine(dataModelTemplate.OutputPath);
                    string dataModelFilename = CamelCase(entity.Id) + "Model.ts";
                    fileToWritePath = Path.Combine(BasePath, dataModelDirectoryPath, dataModelFilename);
                    textToWrite = dataModelTemplate.TransformText();
                }

                WriteFile(fileToWritePath, textToWrite);
            }
        }

        /// <summary>
        /// Convert a string to CamelCase.
        /// </summary>
        /// <param name="word">A word to convert.</param>
        public static string CamelCase(string word)
        {
            string result = "";
            word = word.Trim();
            if (word.Length > 0)
            {
                char[] separators = new char[] {
                    ' ',
                    '-',
                    '_',
                    '/'
                };
                string[] splittedString = word.Split(separators);

                splittedString[0] = Regex.Replace(splittedString[0], "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", " $1", RegexOptions.Compiled).Trim();
                splittedString[0] = splittedString[0].Replace(" ", string.Empty);
                splittedString[0] = splittedString[0].Substring(0, 1).ToLower() + splittedString[0].Substring(1);
                result += splittedString[0];

                for (int i = 1; i < splittedString.Count(); i++)
                {
                    splittedString[i] = Regex.Replace(splittedString[i], "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])", " $1", RegexOptions.Compiled).Trim();
                    splittedString[i] = splittedString[i].Replace(" ", string.Empty);
                    splittedString[i] = splittedString[i].Substring(0, 1).ToUpper() + splittedString[i].Substring(1);
                    result += splittedString[i];
                }
            }
            return result;
        }

        #endregion

    }
}