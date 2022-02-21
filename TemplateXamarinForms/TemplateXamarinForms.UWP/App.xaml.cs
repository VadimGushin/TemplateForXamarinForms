using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Forms.Platforms.Uap.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using TemplateXamarinForms.Core.UI;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TemplateXamarinForms.UWP
{
    sealed partial class App
    {
        public App()
        {
            this.InitializeComponent();
        }
    }

    public abstract class ProxyMvxApplication : MvxWindowsApplication<Setup, Core.App, FormsApp, MainPage>
    {
        public ProxyMvxApplication()
        {
        }
    }
}
