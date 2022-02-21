using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using TemplateXamarinForms.Interfaces.Helpers;
using UIKit;

namespace TemplateXamarinForms.iOS.PlatformHelpers
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public string GetPathDatabase()
        {
            var result = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return result;
        }
    }
}