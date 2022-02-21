using MvvmCross;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using TemplateXamarinForms.Services;
using TemplateXamarinForms.Models.Entities;
using TemplateXamarinForms.Services.SqlServices;
using TemplateXamarinForms.ViewModels.Navigation;

namespace TemplateXamarinForms.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {

            var assemblyServices = typeof(BaseService).GetTypeInfo().Assembly;
            CreatableTypes(assemblyServices)
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();
            //var assemblySqlService = typeof(BaseSqlService<BaseModel>).GetTypeInfo().Assembly;
            //CreatableTypes(assemblySqlService)
            //  .EndingWith("Service")
            //  .AsInterfaces()
            //  .RegisterAsLazySingleton();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
