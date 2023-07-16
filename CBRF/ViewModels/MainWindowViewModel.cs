using CBRF.Pages.Main;
using CBRF.Services;
using CBRF.ViewModels.Base;
using System.Windows.Controls;

namespace CBRF.ViewModels
{
    sealed public class MainWindowViewModel : ViewModel
    {
        #region Внутренние поля и переменные
        private readonly PageService pageService;
        private Page _pageSource;
        public Page PageSource
        {
            get { return _pageSource; }
            set
            {
                if (_pageSource.Equals(value) == false)
                {
                    _pageSource = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("PageSource");
                }
            }
        }
        #endregion
        public MainWindowViewModel(PageService pageService)
        {
            this.pageService = pageService;
            _pageSource = new PageMain();
            this.pageService.OnPageChanged += (page) => _pageSource = PageSource = page;           
            this.pageService.ChangePage(new PageMain());
        }
    }
}
