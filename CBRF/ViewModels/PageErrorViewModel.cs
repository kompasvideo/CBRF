using CBRF.Infrastructure;
using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.BIK;
using CBRF.Messages;
using CBRF.Pages;
using CBRF.Pages.Main;
using CBRF.Services;
using CBRF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CBRF.ViewModels
{
    public class PageErrorViewModel : ViewModel
    {
        private string errorStr = "";
        public string ErrorStr
        {
            get { return errorStr; }
            set
            {
                if (errorStr.Equals(value) == false)
                {
                    errorStr = value;
                    // Call OnPropertyChanged whenever the property is updated
                    OnPropertyChanged("ErrorStr");
                }
            }
        }
        #region Внутренние поля 
        /// <summary>
        /// класс, переключающий страницы на xaml-окне
        /// </summary>
        private readonly PageService pageService;

        /// <summary>
        /// класс, отправляющий сообщения другим страницам
        /// </summary>
        private readonly MessageBus messageBus;
        #endregion

        #region Конструктор
        public PageErrorViewModel(PageService pageService, MessageBus messageBus)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
            messageBus.Receive<Message>(this, message =>
            {
                ErrorStr = StatData.ErrorMessage;
                return Task.CompletedTask;
            });
        }
        #endregion

        #region Комманды
        /// <summary>
        /// Нажата кнопка OK
        /// </summary>
        public ICommand OKClick
        {
            get
            {
                return new MyDelegateCommand(() =>
                {
                    StatData.Error = false;
                    pageService.ChangePage(new PageMain());
                });
            }
        }
        #endregion
    }
}
