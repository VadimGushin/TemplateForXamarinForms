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
using TemplateXamarinForms.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("TemplateXamarinForms")]
[assembly: ExportEffect(typeof(TemplateEffect), "TemplateEffect")]
namespace TemplateXamarinForms.Droid.Effects
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