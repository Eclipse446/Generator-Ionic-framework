// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a �t� g�n�r� par un outil.
//     Version du runtime�: 15.0.0.0
//  
//     Les changements apport�s � ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est r�g�n�r�.
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
    
    #line 1 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutStyleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LayoutStyleTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write(@"
// You should add your licence here, here is an example :
//
// SonarQube, open source software quality management tool.
// Copyright (C) 2008-2013 SonarSource
// mailto:contact AT sonarsource DOT com
//
// SonarQube is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 3 of the License, or (at your option) any later version.
//
// SonarQube is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program; if not, write to the Free Software Foundation,
// Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
");
            
            #line 21 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutStyleTemplate.tt"

    if (_concernId != null && _layout != null && _layout.Id != null)
    {
        string layoutToLower = _concernId.ToLower() + "-" + _layout.Id.ToLower();

            
            #line default
            #line hidden
            
            #line 26 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutStyleTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutToLower));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n  // TO DO\r\n}\r\n");
            
            #line 30 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Layout\Templates\LayoutStyleTemplate.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
