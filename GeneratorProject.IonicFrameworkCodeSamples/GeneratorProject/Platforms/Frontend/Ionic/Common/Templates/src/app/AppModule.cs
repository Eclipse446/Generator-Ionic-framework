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
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Scaffold.Generators.Helpers;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class AppModule : AppBaseClass
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
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
            
            #line 29 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

    SmartAppInfo smartApp = (SmartAppInfo)Model;
    if (smartApp != null && smartApp.Id != null)
    {

            
            #line default
            #line hidden
            this.Write(@"import { NgModule, ErrorHandler } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { IonicApp, IonicModule, IonicErrorHandler } from 'ionic-angular';
import { StatusBar } from '@ionic-native/status-bar';
import { SplashScreen } from '@ionic-native/splash-screen';
import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { ");
            
            #line 41 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(smartApp.Id));
            
            #line default
            #line hidden
            this.Write(" } from \'./app.component\';\r\n");
            
            #line 42 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      if (smartApp.Api.AsEnumerable() != null)
      {

            
            #line default
            #line hidden
            this.Write("import { DataService } from \'../services/data.service\';\r\n");
            
            #line 47 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

      if (smartApp.Concerns.AsEnumerable() != null && _rootLayout != null && _rootLayout.Id != null && _rootConcern != null && _rootConcern.Id != null)
      {
        string concern = TextConverter.PascalCase(_rootConcern.Id);
        string layout = TextConverter.PascalCase(_rootLayout.Id);
        string layoutModule = concern + layout;
        string layoutModuleToLower = TextConverter.CamelCase(concern) + "-" + TextConverter.CamelCase(layout);

            
            #line default
            #line hidden
            this.Write("import { ");
            
            #line 57 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutModule));
            
            #line default
            #line hidden
            this.Write("PageModule } from \'../pages/");
            
            #line 57 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(concern)));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 57 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.CamelCase(layout)));
            
            #line default
            #line hidden
            this.Write("/");
            
            #line 57 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutModuleToLower));
            
            #line default
            #line hidden
            this.Write(".module\';\r\n");
            
            #line 58 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 62 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      if (_languages.AsEnumerable() != null && _languages.AsEnumerable().Count() > 0)
      {

            
            #line default
            #line hidden
            this.Write(@"import { LanguagePageModule } from '../pages/language/language.module';
import { TranslateModule, TranslateLoader } from '@ngx-translate/core';
import { TranslateHttpLoader } from '@ngx-translate/http-loader';

export function createTranslateLoader(http: HttpClient) {
  return new TranslateHttpLoader(http, './assets/i18n/', '.json');
}
");
            
            #line 73 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

            
            #line default
            #line hidden
            this.Write("\r\n/**\r\n * class: AppModule.\r\n");
            
            #line 79 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      if (smartApp.Description != null)
      {

            
            #line default
            #line hidden
            this.Write(" * ");
            
            #line 83 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(smartApp.Description));
            
            #line default
            #line hidden
            this.Write(".\r\n * This is the main module of the application.\r\n * This module is generated fr" +
                    "om multiple domains.\r\n");
            
            #line 86 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }
      else
      {

            
            #line default
            #line hidden
            this.Write(" * This is the main module of the application.\r\n * This module is generated from " +
                    "multiple domains.\r\n");
            
            #line 93 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

            
            #line default
            #line hidden
            this.Write(" */\r\n@NgModule({\r\n  declarations: [\r\n    ");
            
            #line 99 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(smartApp.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n  ],\r\n  imports: [\r\n    BrowserModule,\r\n    CommonModule,\r\n    HttpClientModule" +
                    ",\r\n");
            
            #line 105 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      if (smartApp.Concerns.AsEnumerable() != null && _rootLayout != null && _rootLayout.Id != null && _rootConcern != null && _rootConcern.Id != null)
      {
        string concern = TextConverter.PascalCase(_rootConcern.Id);
        string layout = TextConverter.PascalCase(_rootLayout.Id);
        string layoutModule = concern + layout;

            
            #line default
            #line hidden
            this.Write("    ");
            
            #line 112 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(layoutModule));
            
            #line default
            #line hidden
            this.Write("PageModule,\r\n");
            
            #line 113 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }
      
      if (_languages.AsEnumerable() != null && _languages.AsEnumerable().Count() > 0)
      {

            
            #line default
            #line hidden
            this.Write("    LanguagePageModule,\r\n    TranslateModule.forRoot({\r\n      loader: {\r\n        " +
                    "provide: TranslateLoader,\r\n        useFactory: (createTranslateLoader),\r\n       " +
                    " deps: [HttpClient]\r\n      }\r\n    }),\r\n");
            
            #line 127 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

            
            #line default
            #line hidden
            this.Write("    IonicModule.forRoot(");
            
            #line 130 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(smartApp.Id)));
            
            #line default
            #line hidden
            this.Write(")\r\n  ],\r\n  bootstrap: [IonicApp],\r\n  entryComponents: [\r\n    ");
            
            #line 134 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(TextConverter.PascalCase(smartApp.Id)));
            
            #line default
            #line hidden
            this.Write("\r\n  ],\r\n  providers: [\r\n");
            
            #line 137 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      if (smartApp.Api.AsEnumerable() != null)
      {

            
            #line default
            #line hidden
            this.Write("    DataService,\r\n");
            
            #line 142 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

      }

            
            #line default
            #line hidden
            this.Write("    StatusBar,\r\n    SplashScreen,\r\n    { provide: ErrorHandler, useClass: IonicEr" +
                    "rorHandler }\r\n  ]\r\n})\r\nexport class AppModule {}\r\n");
            
            #line 151 "C:\Users\PC\Documents\Gits\Ionic-framework\GeneratorProject.IonicFrameworkCodeSamples\GeneratorProject\Platforms\Frontend\Ionic\Common\Templates\src\app\AppModule.tt"

    }

            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
