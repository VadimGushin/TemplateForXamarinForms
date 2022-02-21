using System;
using System.Collections.Generic;
using System.Text;
using TemplateXamarinForms.Interfaces.Services;
using TemplateXamarinForms.Services;

namespace TemplateXamarinForms.Services
{
    public class TemplateService : BaseService , ITemplateService
    {
        public string GetString()
        {
            return "Hi";
        }
    }
}
