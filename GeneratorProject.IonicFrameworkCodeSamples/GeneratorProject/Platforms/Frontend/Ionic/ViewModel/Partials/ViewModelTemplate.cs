﻿using Mobioos.Foundation.Jade.Models;
using Mobioos.Foundation.Jade.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GeneratorProject.Platforms.Frontend.Ionic
{
    public partial class ViewModelTemplate
    {
        private EntityInfo _dataModel { get; set; }
        private List<PropertyInfo> _constructorParametersObj { get; set; }
        public ViewModelTemplate(EntityInfo dataModel)
        {
            _dataModel = dataModel;
            _constructorParametersObj = getReferences(dataModel);
        }

        public List<PropertyInfo> getReferences(EntityInfo entity)
        {
            List<PropertyInfo> result = new List<PropertyInfo>();
            if (entity != null)
            {
                if (entity.BaseEntity != null)
                    foreach (PropertyInfo property in getReferences(entity.BaseEntity).AsEnumerable())
                        result.Add(property);

                if (entity.Properties.AsEnumerable() != null)
                    foreach (PropertyInfo property in entity.Properties.AsEnumerable())
                        result.Add(property);

                if (entity.References.AsEnumerable() != null)
                    foreach (ReferenceInfo reference in entity.References.AsEnumerable())
                        result.Add(reference);
            }
            return result;
        }

        public string IsModel(PropertyInfo property)
        {
            string result = "";
            switch (property.TypeScriptType().ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                default: result = "Model"; break;
            }
            if (property.Target != null && property.Target.IsEnum)
                result = "Enum";
            return result;
        }

        /// <summary>
        /// Convert a string to PascalCase.
        /// </summary>
        /// <param name="word">A word to convert.</param>
        public static string PascalCase(string word)
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
                splittedString[0] = splittedString[0].Substring(0, 1).ToUpper() + splittedString[0].Substring(1);
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

        public override string OutputPath => "src\\viewModels";
    }
}
