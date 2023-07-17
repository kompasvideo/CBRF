using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF.Messages;
using CBRF.Pages.Main;
using CBRF.Services;
using CBRF.ViewModels.Base;
using CBRF_DB.Models.UFEBS_2023_4_1;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CBRF.ViewModels.UFEBS_2023_4_1
{
    public class PageCbrDsigV110ViewModel : ViewModel
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
        private readonly ICbrDsigV110 cbrDsigV110;
        #endregion

        #region Конструктор
        public PageCbrDsigV110ViewModel(PageService pageService, MessageBus messageBus, ICbrDsigV110 cbrDsigV110)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
            this.cbrDsigV110 = cbrDsigV110;
            messageBus.Receive<Message>(this, message =>
            {
                SigEnvelopes = new ObservableCollection<SigEnvelope>(cbrDsigV110.ViewSigEnvelopeInDb());
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
