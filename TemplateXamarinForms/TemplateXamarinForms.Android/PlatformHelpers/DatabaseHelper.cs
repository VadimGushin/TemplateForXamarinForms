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
using TemplateXamarinForms.Interfaces.Helpers;

namespace TemplateXamarinForms.Droid.PlatformHelpers
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public string GetPathDatabase()
        {
            return System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
        }
    }
}