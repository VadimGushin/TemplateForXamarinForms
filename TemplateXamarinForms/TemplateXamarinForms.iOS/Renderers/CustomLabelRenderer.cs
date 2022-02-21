using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TemplateXamarinForms.Core.UI.Views.CustomElements;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(TemplateXamarinForms.iOS.Renderers.CustomLabelRenderer))]
namespace TemplateXamarinForms.iOS.Renderers
{
    class CustomLabelRenderer:LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
        }
    }
}