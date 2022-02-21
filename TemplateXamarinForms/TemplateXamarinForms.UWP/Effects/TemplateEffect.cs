using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateXamarinForms.UWP.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ResolutionGroupName("TemplateXamarinForms")]
[assembly: ExportEffect(typeof(TemplateEffect), "TemplateEffect")]
namespace TemplateXamarinForms.UWP.Effects
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
