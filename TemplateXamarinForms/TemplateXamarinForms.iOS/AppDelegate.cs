using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using TemplateXamarinForms.Core;
using TemplateXamarinForms.Core.UI;
using UIKit;

namespace TemplateXamarinForms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, App, FormsApp>
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
