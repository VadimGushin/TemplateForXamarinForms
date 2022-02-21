using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;
using TemplateXamarinForms.Core;
using TemplateXamarinForms.Interfaces.Helpers;
using TemplateXamarinForms.Core.UI;
using TemplateXamarinForms.Droid.PlatformHelpers;
using MvvmCross.IoC;

namespace TemplateXamarinForms.Droid
{
    public class Setup: MvxFormsAndroidSetup<App, FormsApp>
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