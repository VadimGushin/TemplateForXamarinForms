using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateXamarinForms.Core.UI.Views.CustomElements;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(TemplateXamarinForms.UWP.Renderers.CustomLabelRenderer))]
namespace TemplateXamarinForms.UWP.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
        }
    }
}
