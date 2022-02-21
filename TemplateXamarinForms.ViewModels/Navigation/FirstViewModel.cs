using MvvmCross.Commands;
using System.Threading.Tasks;
using TemplateXamarinForms.Interfaces.Helpers;
using TemplateXamarinForms.Interfaces.Services;
using TemplateXamarinForms.Interfaces.SqlServices;
using TemplateXamarinForms.Models.Entities;
using TemplateXamarinForms.ViewModels.Base;

namespace TemplateXamarinForms.ViewModels.Navigation
{
    public class FirstViewModel : BaseViewModel
    {
        #region Variables
        private readonly ITemplateService _templateService;
        private readonly ITemplateHelper _templateHelper;
        private readonly IBaseSqlService<Template> _baseTemplateSqlService;
        private readonly ISecondTemplateSqlService _secondTemplateSqlService;
        #endregion Variables

        #region Constructors
        public FirstViewModel(
            IBaseSqlService<Template> baseTemplateSqlService,
            ISecondTemplateSqlService secondTemplateSqlService,
            ITemplateService templateService,
            ITemplateHelper templateHelper)
        {
            _templateService = templateService;
            _templateHelper = templateHelper;
            _baseTemplateSqlService = baseTemplateSqlService;
            //    _secondTemplateSqlService = secondTemplateSqlService;
            _baseTemplateSqlService.Cleane();
            var temp = _baseTemplateSqlService.GetAll();
            _baseTemplateSqlService.Insert(new Template() { TestModel = new SecondTemplate() { FullName = "third" }, Name = "test" });
            temp = _baseTemplateSqlService.GetAll();

            HelloString = _templateHelper.ExampleMethod();
        }
        #endregion Constructors

        #region Properties
        private string _helloString;
        public string HelloString
        {
            get => _helloString;
            set
            {
                _helloString = value;
                RaisePropertyChanged(() => HelloString);
            }
        }
        #endregion Properties

        #region Commands  
        public IMvxAsyncCommand ChangeTextCommand { get => new MvxAsyncCommand(OnChangeText); }
        #endregion Commands

        #region Methods
        private async Task OnChangeText()
        {
            HelloString = $"{HelloString} +";
        }
        #endregion Methods

    }
}
