﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime : 15.0.0.0
//  
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace GeneratorProject.Platforms.Frontend.Ionic
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Foundation.Jade.Models;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class JsonTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n{\r\n");
            
            #line 3 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

    if (_smartApp != null && _smartApp.Title != null && _smartApp.Concerns.AsEnumerable() != null && _language != null)
    { 
        if (_language == "Fr" || _language == "fr")
        {

            
            #line default
            #line hidden
            this.Write("    \"closeMenu\": \"FermerMenu\",\r\n");
            
            #line 10 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

        }
        else
        {

            
            #line default
            #line hidden
            this.Write("    \"closeMenu\": \"CloseMenu\",\r\n");
            
            #line 16 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

        }

        foreach (ConcernInfo concern in _smartApp.Concerns.AsEnumerable())
        {
            if (concern.Id != null && concern.Title != null && concern.Layouts.AsEnumerable() != null)
            {

            
            #line default
            #line hidden
            this.Write("\r\n    \"");
            
            #line 25 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(concern.Id)));
            
            #line default
            #line hidden
            this.Write("\": {\r\n");
            
            #line 26 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

                foreach (LayoutInfo layout in concern.Layouts.AsEnumerable())
                {
                    if (layout.Id != null && layout.Description != null && layout.Actions.AsEnumerable() != null)
                    {
                        foreach (ActionInfo action in layout.Actions.AsEnumerable())
                        {
                            if (action.Id != null)
                            {

            
            #line default
            #line hidden
            this.Write("        \"");
            
            #line 36 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write("Layout");
            
            #line 36 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("Action\": \"");
            
            #line 36 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(action.Id)));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 37 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

                            }
                        }

            
            #line default
            #line hidden
            this.Write("        \"");
            
            #line 41 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write("LayoutTitle\": \"");
            
            #line 41 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(layout.Title)));
            
            #line default
            #line hidden
            this.Write("\",\r\n        \"");
            
            #line 42 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(layout.Id)));
            
            #line default
            #line hidden
            this.Write("LayoutDescription\": \"");
            
            #line 42 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(layout.Description)));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 43 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

                    }
                }

            
            #line default
            #line hidden
            this.Write("        \"");
            
            #line 47 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(CamelCase(concern.Id)));
            
            #line default
            #line hidden
            this.Write("ConcernTitle\": \"");
            
            #line 47 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(concern.Title)));
            
            #line default
            #line hidden
            this.Write("\"\r\n    },\r\n");
            
            #line 49 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

            }
        }

        if (_smartApp.SmallTitle != null)
        {

            
            #line default
            #line hidden
            this.Write("    \"applicationSmallTitle\": \"");
            
            #line 56 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(_smartApp.SmallTitle)));
            
            #line default
            #line hidden
            this.Write("\",\r\n");
            
            #line 57 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

        }

            
            #line default
            #line hidden
            this.Write("    \"applicationTitle\": \"");
            
            #line 60 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PascalCase(_smartApp.Title)));
            
            #line default
            #line hidden
            this.Write("\"\r\n");
            
            #line 61 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\JsonTemplate.tt"

    }

            
            #line default
            #line hidden
            this.Write("}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
