using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateXamarinForms.Interfaces.Helpers;
using Windows.Storage;

namespace TemplateXamarinForms.UWP.PlatformHelpers
{
    public class DatabaseHelper : IDatabaseHelper
    {
        public string GetPathDatabase()
        {
            return ApplicationData.Current.LocalFolder.Path;
        }
    }
}
