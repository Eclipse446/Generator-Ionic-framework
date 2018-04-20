﻿using Mobioos.Foundation.Jade.Extensions;
using Mobioos.Foundation.Jade.Models;
using Mobioos.Scaffold.Generators.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace GeneratorProject.Platforms.Frontend.Ionic
{
    public partial class ServiceSpecTemplate
    {
        private ApiInfo _api { get; set; }
        private List<string> _viewModels { get; set; }
        public ServiceSpecTemplate(ApiInfo api)
        {
            _api = api;
            _viewModels = getViewModels(api);
        }

        /// <summary>
        /// Retrieve viewModels from an api.
        /// </summary>
        /// <param name="api">An api.</param>
        public List<string> getViewModels(ApiInfo api)
        {
            List<string> viewModels = new List<string>();
            if (api != null && api.Actions.AsEnumerable() != null)
            {
                foreach (ApiActionInfo action in _api.Actions.AsEnumerable())
                {
                    if (action.Parameters.AsEnumerable() != null)
                    {
                        foreach (ApiParameterInfo apiParameter in action.Parameters.AsEnumerable())
                        {
                            bool parameterIsModel = IsModelBool(TextConverter.PascalCase(apiParameter.TypeScriptType()));
                            if (parameterIsModel && !viewModels.AsEnumerable().Contains(TextConverter.PascalCase(apiParameter.TypeScriptType())))
                                viewModels.Add(TextConverter.PascalCase(apiParameter.TypeScriptType()));
                        }
                    }

                    if (action.ReturnType != null && action.ReturnType.Id != null && !viewModels.AsEnumerable().Contains(TextConverter.PascalCase(action.ReturnType.Id)))
                        viewModels.Add(TextConverter.PascalCase(action.ReturnType.Id));
                }
            }
            return viewModels;
        }

        /// <summary>
        /// Retrieve a standard value for each type supposed
        /// to be in the generated code.
        /// </summary>
        /// <param name="type">A type.</param>
        public string getValueFromType(string type)
        {
            string result = "null";
            switch (type.ToLower())
            {
                case "date": break;
                case "string":
                    result = "'test'";
                    break;
                case "number":
                    result = "0";
                    break;
                case "boolean":
                    result = "true";
                    break;
                default:
                    result = "null";
                    break;
            }
            return result;
        }

        /// <summary>
        /// Convert an Mobioos action type to typescript action type.
        /// </summary>
        /// <param name="actionType">A Mobioos action type.</param>
        public string ConvertActionType(string actionType)
        {
            string result = "";
            switch (actionType.ToLower())
            {
                case "dataget":
                    result = "get";
                    break;
                case "datalist":
                    result = "get";
                    break;
                case "datacreate":
                    result = "post";
                    break;
                case "dataupdate":
                    result = "put";
                    break;
                case "datadelete":
                    result = "delete";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        /// <summary>
        /// Check if the given type is a model or primitive type. Return a boolean.
        /// </summary>
        /// <param name="type">A type.</param>
        public bool IsModelBool(string type)
        {
            bool result = false;
            switch (type.ToLower())
            {
                case "date": break;
                case "string": break;
                case "number": break;
                case "boolean": break;
                default: result = true; break;
            }
            return result;
        }

        public override string OutputPath => "src\\services";
    }
}
