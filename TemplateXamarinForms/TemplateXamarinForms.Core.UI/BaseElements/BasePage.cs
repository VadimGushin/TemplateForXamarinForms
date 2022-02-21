using MvvmCross.Forms.Views;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateXamarinForms.Core.UI.BaseElements
{
    public abstract class BasePage<TPage> : MvxContentPage<TPage> where TPage : MvxViewModel
    {
        public BasePage()
        {
        }
    }
}
