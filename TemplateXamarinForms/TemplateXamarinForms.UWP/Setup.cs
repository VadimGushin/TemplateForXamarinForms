using MvvmCross;
using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateXamarinForms.Interfaces.Helpers;
using TemplateXamarinForms.Core.UI;
using TemplateXamarinForms.UWP.PlatformHelpers;
using MvvmCross.IoC;

namespace TemplateXamarinForms.UWP
{
    public class Setup : MvxFormsWindowsSetup<Core.App, FormsApp>
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
