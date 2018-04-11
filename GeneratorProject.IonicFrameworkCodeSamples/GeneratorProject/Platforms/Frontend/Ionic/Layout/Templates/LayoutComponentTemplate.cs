// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GeneratorProject.Platforms.Frontend.Ionic
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Scaffold.Generators.Helpers;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LayoutComponentTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            this.Write(@"/*
 * You should add your licence here, here is an example :
 *
 * SonarQube, open source software quality management tool.
 * Copyright (C) 2008-2013 SonarSource
 * mailto:contact AT sonarsource DOT com
 *
 * SonarQube is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * SonarQube is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
");
            
            #line 24 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

    if (_concernId != null && _layout != null && _layout.Id != null)
    {
        string layout = TextConverter.PascalCase(_concernId) + TextConverter.PascalCase(_layout.Id);
        string layoutToLower = TextConverter.CamelCase(_concernId) + "-" + TextConverter.CamelCase(_layout.Id);
        string layoutPathToLower = TextConverter.CamelCase(_concernId) + "/" + TextConverter.CamelCase(_layout.Id);

            
            #line default
            #line hidden
            this.Write("import { Component } from \'@angular/core\';\r\nimport { IonicPage, NavController");
            
            #line 32 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
 if (_menu.AsEnumerable() != null && _menu.AsEnumerable().Count() > 0) { 
            
            #line default
            #line hidden
            this.Write(", Events");
            
            #line 32 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write(" } from \'ionic-angular\';\r\n");
            
            #line 33 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_viewModels.AsEnumerable() != null && _viewModels.AsEnumerable().Count() > 0)
        {
            foreach (string viewModel in _viewModels.AsEnumerable())
            {

            
            #line default
            #line hidden
            this.Write("import { ");
            
            #line 39 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(viewModel)));
            
            #line default
            #line hidden
            this.Write(" } from \'../../../viewModels/");
            
            #line 39 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(viewModel)));
            
            #line default
            #line hidden
            this.Write("\';\r\n");
            
            #line 40 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

            }
        }

        if (_apiDomainServices.AsEnumerable() != null && _apiDomainServices.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("import { Observable } from \'rxjs\';\r\n");
            
            #line 48 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

            foreach (string service in _apiDomainServices.AsEnumerable())
            {

            
            #line default
            #line hidden
            this.Write("import { ");
            
            #line 52 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(service)));
            
            #line default
            #line hidden
            this.Write(" } from \'../../../services/");
            
            #line 52 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(service)));
            
            #line default
            #line hidden
            this.Write(".service\';\r\n");
            
            #line 53 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

            }
        }

        if (_languages.AsEnumerable() != null && _languages.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("import { LanguagePage } from \'../../language/language\';\r\n");
            
            #line 61 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("\r\n/**\r\n * class: ");
            
            #line 66 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layout));
            
            #line default
            #line hidden
            this.Write(".\r\n");
            
            #line 67 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_layout.Description != null)
        {

            
            #line default
            #line hidden
            this.Write(" * ");
            
            #line 71 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_layout.Description));
            
            #line default
            #line hidden
            this.Write(".\r\n * This is the component of that layout.\r\n * This component is generated from " +
                    "Concerns domain.\r\n");
            
            #line 74 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write(" * You should add a description of your\r\n * layout\'s component here.\r\n * This is " +
                    "the component of the current layout.\r\n * This component is generated from Concer" +
                    "ns domain.\r\n");
            
            #line 83 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write(" */\r\n@IonicPage({\r\n  name: \'");
            
            #line 88 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutToLower));
            
            #line default
            #line hidden
            this.Write("\',\r\n  segment: \'");
            
            #line 89 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutPathToLower));
            
            #line default
            #line hidden
            this.Write("\'\r\n})\r\n@Component({\r\n  selector: \'");
            
            #line 92 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutToLower));
            
            #line default
            #line hidden
            this.Write("\',\r\n  templateUrl: \'");
            
            #line 93 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutToLower));
            
            #line default
            #line hidden
            this.Write(".html\'\r\n})\r\nexport class ");
            
            #line 95 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layout));
            
            #line default
            #line hidden
            this.Write(" {\r\n");
            
            #line 96 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_menu.AsEnumerable() != null && _menu.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("  public _menu;\r\n");
            
            #line 101 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("  constructor(\r\n");
            
            #line 105 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_menu.AsEnumerable() != null && _menu.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("    public _events: Events,\r\n");
            
            #line 110 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

        if (_apiDomainServices.AsEnumerable() != null && _apiDomainServices.AsEnumerable().Count() > 0)
        {
            foreach (string service in _apiDomainServices.AsEnumerable())
            {

            
            #line default
            #line hidden
            this.Write("    public _");
            
            #line 118 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(service)));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 118 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(service)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 119 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

            }
        }

            
            #line default
            #line hidden
            this.Write("    public _nav: NavController\r\n  ) {\r\n");
            
            #line 125 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_menu.AsEnumerable() != null && _menu.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("    this._menu = [\r\n");
            
            #line 130 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

            string last = _menu.Keys.Last();
            foreach(KeyValuePair<string, string> m in _menu.AsEnumerable())
            {
                if (m.Key.Equals(last))
                {

            
            #line default
            #line hidden
            this.Write("      { name: \'");
            
            #line 137 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.Value));
            
            #line default
            #line hidden
            this.Write("\', component: \'");
            
            #line 137 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.Key));
            
            #line default
            #line hidden
            this.Write("\' }\r\n");
            
            #line 138 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                }
                else
                {

            
            #line default
            #line hidden
            this.Write("      { name: \'");
            
            #line 143 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.Value));
            
            #line default
            #line hidden
            this.Write("\', component: \'");
            
            #line 143 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(m.Key));
            
            #line default
            #line hidden
            this.Write("\' },\r\n");
            
            #line 144 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                }
            }

            
            #line default
            #line hidden
            this.Write("    ];\r\n");
            
            #line 149 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("  }\r\n\r\n");
            
            #line 154 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        if (_layout.Actions.AsEnumerable() != null)
        {
            foreach (ActionInfo action in _layout.Actions.AsEnumerable())
            {
                switch (action.Type.ToLower())
                {
                    case "navigation":
                        if (action.Target != null)
                        {
                            string[] actionTargetSplitted = action.Target.Split('.');
                            string targetedConcern = TextConverter.CamelCase(actionTargetSplitted[0]);
                            string targetedLayout = TextConverter.CamelCase(actionTargetSplitted[1]);

                            if (_layout.IsVisibleInMenu)
                            {

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: on");
            
            #line 172 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n   * That method is a navigation method.\r\n   */\r\n  public on");
            
            #line 175 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("() {\r\n    this._nav.setRoot(\'");
            
            #line 176 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetedConcern + "-" + targetedLayout));
            
            #line default
            #line hidden
            this.Write("\');\r\n  }\r\n\r\n");
            
            #line 179 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                            }
                            else
                            {

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: on");
            
            #line 185 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n   * That method is a navigation method.\r\n   */\r\n  public on");
            
            #line 188 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("() {\r\n    this._nav.push(\'");
            
            #line 189 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(targetedConcern + "-" + targetedLayout));
            
            #line default
            #line hidden
            this.Write("\');\r\n  }\r\n\r\n");
            
            #line 192 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                            }
                        }
                        break;
                    case "method":

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: on");
            
            #line 199 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n   * That method is a blank method.\r\n   */\r\n  public on");
            
            #line 202 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("() {\r\n    // TO DO\r\n  }\r\n\r\n");
            
            #line 206 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                        break;
                    case "dataget": case "datalist": case "datacreate": case "dataupdate": case "datadelete":
                        if (action.Api != null && _api != null)
                        {
                            string[] actionSplitted = action.Api.Split('.');
                            string apiService = actionSplitted[0];
                            string apiAction = actionSplitted[1];

                            foreach (ApiInfo api in _api.AsEnumerable())
                            {
                                if (api.Id.ToLower().Equals(apiService.ToLower()) && api.Actions.AsEnumerable() != null)
                                {
                                    foreach (ApiActionInfo apiA in api.Actions.AsEnumerable())
                                    {
                                        if (apiA.Id.ToLower().Equals(apiAction.ToLower()))
                                        {

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: on");
            
            #line 225 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n   * You should add a description of your method here.\r\n");
            
            #line 227 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                            if (apiA.Parameters.AsEnumerable() != null && apiA.Parameters.AsEnumerable().Count() > 0)
                                            {
                                                foreach (ApiParameterInfo apiParameter in apiA.Parameters.AsEnumerable())
                                                {
                                                    if (apiParameter.Id != null)
                                                    {
                                                        string parameterIsModel = IsModel(apiParameter.TypeScriptType());
                                                        string type = apiParameter.TypeScriptType();
                                                        if (!parameterIsModel.Equals(""))
                                                        {
                                                            type = TextConverter.PascalCase(type);
                                                        }

            
            #line default
            #line hidden
            this.Write("   * @param ");
            
            #line 241 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(" `");
            
            #line 241 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type + parameterIsModel));
            
            #line default
            #line hidden
            this.Write("`.\r\n");
            
            #line 242 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                                    }
                                                }
                                            }

            
            #line default
            #line hidden
            this.Write("   * @returns A `Subscription<any>`.\r\n   */\r\n  public on");
            
            #line 249 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 250 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                            if (apiA.Parameters.AsEnumerable() != null && apiA.Parameters.AsEnumerable().Count() > 0)
                                            {
                                                ApiParameterInfo last = apiA.Parameters.AsEnumerable().Last();
                                                foreach (ApiParameterInfo apiParameter in apiA.Parameters.AsEnumerable())
                                                {
                                                    if (apiParameter.Id != null)
                                                    {
                                                        string parameterIsModel = IsModel(apiParameter.TypeScriptType());
                                                        string type = apiParameter.TypeScriptType();
                                                        if (!parameterIsModel.Equals(""))
                                                        {
                                                            type = TextConverter.PascalCase(type);
                                                        }
                                                        if (apiParameter.Equals(last))
                                                        {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 267 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 267 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type + parameterIsModel));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 268 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                                        }
                                                        else
                                                        {

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 273 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 273 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(type + parameterIsModel));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 274 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                                        }
                                                    }
                                                }
                                            }

            
            #line default
            #line hidden
            this.Write("  ) {\r\n    return this._");
            
            #line 281 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(api.Id)));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 281 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiA.Id)));
            
            #line default
            #line hidden
            this.Write("(\r\n");
            
            #line 282 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                            if (apiA.Parameters.AsEnumerable() != null && apiA.Parameters.AsEnumerable().Count() > 0)
                                            {
                                                ApiParameterInfo last = apiA.Parameters.AsEnumerable().Last();
                                                foreach (ApiParameterInfo apiParameter in apiA.Parameters.AsEnumerable())
                                                {
                                                    if (apiParameter.Id != null && apiParameter.Equals(last))
                                                    {

            
            #line default
            #line hidden
            this.Write("      ");
            
            #line 291 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 292 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                                    }
                                                    else if (apiParameter.Id != null)
                                                    {

            
            #line default
            #line hidden
            this.Write("      ");
            
            #line 297 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(apiParameter.Id)));
            
            #line default
            #line hidden
            this.Write(",\r\n");
            
            #line 298 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                                    }
                                                }
                                            }


            
            #line default
            #line hidden
            this.Write("    ).subscribe();\r\n  }\r\n\r\n");
            
            #line 307 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }
        }

        if (_languages.AsEnumerable() != null && _languages.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: onLanguage.\r\n   * That method enables to quit the language\r\n " +
                    "  * page with an html button.\r\n   */\r\n  public onLanguage() {\r\n    this._nav.pus" +
                    "h(LanguagePage);\r\n  }\r\n\r\n");
            
            #line 330 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

        if (_menu.AsEnumerable() != null && _menu.AsEnumerable().Count() > 0)
        {

            
            #line default
            #line hidden
            this.Write("  /**\r\n   * method: ionViewWillEnter.\r\n   * Base event from Ionic to trigger\r\n   " +
                    "* global menu loading associated with\r\n   * each layout\'s specific menu.\r\n   */\r" +
                    "\n  public ionViewWillEnter() {\r\n    this._events.publish(\'menu\', this._menu);\r\n " +
                    " }\r\n");
            
            #line 345 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("}\r\n");
            
            #line 349 "C:\Users\Temoe\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutComponentTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
