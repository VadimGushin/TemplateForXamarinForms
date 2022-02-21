using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using TemplateXamarinForms.Core;
using TemplateXamarinForms.Interfaces.Helpers;
using TemplateXamarinForms.Core.UI;
using TemplateXamarinForms.iOS.PlatformHelpers;
using UIKit;
using MvvmCross.IoC;

namespace TemplateXamarinForms.iOS
{
    public class Setup: MvxFormsIosSetup<App, FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            CreatableTypes()
            .EndingWith("Helper")
            .AsInterfaces()
            .RegisterAsLazySingleton();
            base.InitializeFirstChance();
        }
    }
}