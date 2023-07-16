using CBRF.Infrastructure.Commands;
using CBRF.Pages.BIK;
using CBRF.Pages.Main;
using CBRF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CBRF.ViewModels.Main
{
    public class HeaderViewModel
    {
        #region Внутренние поля и переменные   
        private PageService pageService;
        private MessageBus messageBus;

        #endregion
        public HeaderViewModel(PageService pageService, MessageBus messageBus)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
        }
        public ICommand MainPageClick
        {
            get
            {
                return new MyDelegateCommand(() =>
                {
                    pageService.ChangePage(new PageMain());
                });
            }
        }
    }
}
