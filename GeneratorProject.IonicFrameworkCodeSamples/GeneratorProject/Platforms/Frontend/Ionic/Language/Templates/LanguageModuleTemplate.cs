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
    
    #line 1 "C:\Users\PC\Documents\Gits\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Language\Templates\LanguageModuleTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class LanguageModuleTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n/*\r\n * You should add your licence here, here is an example :\r\n *\r\n * SonarQube" +
                    ", open source software quality management tool.\r\n * Copyright (C) 2008-2013 Sona" +
                    "rSource\r\n * mailto:contact AT sonarsource DOT com\r\n *\r\n * SonarQube is free soft" +
                    "ware; you can redistribute it and/or\r\n * modify it under the terms of the GNU Le" +
                    "sser General Public\r\n * License as published by the Free Software Foundation; ei" +
                    "ther\r\n * version 3 of the License, or (at your option) any later version.\r\n *\r\n " +
                    "* SonarQube is distributed in the hope that it will be useful,\r\n * but WITHOUT A" +
                    "NY WARRANTY; without even the implied warranty of\r\n * MERCHANTABILITY or FITNESS" +
                    " FOR A PARTICULAR PURPOSE.  See the GNU\r\n * Lesser General Public License for mo" +
                    "re details.\r\n *\r\n * You should have received a copy of the GNU Lesser General Pu" +
                    "blic License\r\n * along with this program; if not, write to the Free Software Fou" +
                    "ndation,\r\n * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA." +
                    "\r\n */\r\nimport { NgModule } from \'@angular/core\';\r\nimport { IonicPageModule } fro" +
                    "m \'ionic-angular\';\r\nimport { TranslateModule } from \'@ngx-translate/core\';\r\nimpo" +
                    "rt { LanguagePage } from \'./language\';\r\n\r\n/**\r\n * class: LanguagePageModule.\r\n *" +
                    " This is the module of the language page which\r\n * manage internationalization i" +
                    "n the application.\r\n * This module is generated from SmartApp domain.\r\n */\r\n@NgM" +
                    "odule({\r\n  declarations: [\r\n    LanguagePage\r\n  ],\r\n  imports: [\r\n    IonicPageM" +
                    "odule.forChild(LanguagePage),\r\n    TranslateModule.forChild()\r\n  ]\r\n})\r\nexport c" +
                    "lass LanguagePageModule {}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}