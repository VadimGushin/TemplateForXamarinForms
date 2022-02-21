using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TemplateXamarinForms.iOS.Effects;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("TemplateXamarinForms")]
[assembly: ExportEffect(typeof(TemplateEffect), "TemplateEffect")]
namespace TemplateXamarinForms.iOS.Effects
{
    public class TemplateEffect : PlatformEffect
    {
        protected override void OnAttached()
        {

        }

        protected override void OnDetached()
        {

        }
    }
}