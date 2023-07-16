using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.BIK;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF.Messages;
using CBRF.Pages.Main;
using CBRF.Services;
using CBRF.Services.BIK;
using CBRF.ViewModels.Base;
using CBRF_DB.Models;
using CBRF_DB.Models.UFEBS_2023_4_1;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CBRF.ViewModels.UFEBS_2023_4_1
{
    public class PageCbrDsigEnvV110ViewModel : ViewModel
    {
        public ObservableCollection<SigEnvelope> SigEnvelopes { get; set; }

        #region Внутренние поля 
        /// <summary>
        /// класс, переключающий страницы на xaml-окне
        /// </summary>
        private readonly PageService pageService;

        /// <summary>
        /// класс, отправляющий сообщения другим страницам
        /// </summary>
        private readonly MessageBus messageBus;
        private readonly ICbrDsigEnvV110 cbrDsigEnvV110;
        #endregion

        #region Конструктор
        public PageCbrDsigEnvV110ViewModel(PageService pageService, MessageBus messageBus, ICbrDsigEnvV110 cbrDsigEnvV110)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
            this.cbrDsigEnvV110 = cbrDsigEnvV110;
            messageBus.Receive<Message>(this, message =>
            {
                SigEnvelopes = new ObservableCollection<SigEnvelope>(cbrDsigEnvV110.ViewSigEnvelopeInDb());
                return Task.CompletedTask;
            });
        }
        #endregion

        #region Комманды

        /// <summary>
        /// Закрыть
        /// </summary>
        public ICommand CloseClick
        {
            get
            {
                return new MyDelegateCommand(() =>
                {
                    pageService.ChangePage(new PageMain());
                });
            }
        }
        #endregion
    }
}
