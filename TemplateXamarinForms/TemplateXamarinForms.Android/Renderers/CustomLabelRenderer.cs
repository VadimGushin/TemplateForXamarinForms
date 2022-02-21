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
using TemplateXamarinForms.Core.UI.Views.CustomElements;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(TemplateXamarinForms.Droid.Renderers.CustomLabelRenderer))]
namespace TemplateXamarinForms.Droid.Renderers
{
    public class CustomLabelRenderer: LabelRenderer
    {
        public CustomLabelRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
        }

    }
}