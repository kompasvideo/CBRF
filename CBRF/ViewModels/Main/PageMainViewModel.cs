using CBRF.Infrastructure;
using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.BIK;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF.Messages;
using CBRF.Pages;
using CBRF.Pages.BIK;
using CBRF.Pages.UFEBS_2023_4_1;
using CBRF.Services;
using CBRF.ViewModels.Base;
using CBRF.ViewModels.BIK;
using CBRF.ViewModels.UFEBS_2023_4_1;
using System.Threading;
using System.Windows;
using System.Windows.Input;

namespace CBRF.ViewModels.Main
{
    public class PageMainViewModel : ViewModel
    {
        #region Внутренние поля 
        /// <summary>
        /// класс, переключающий страницы на xaml-окне
        /// </summary>
        private readonly PageService pageService;

        /// <summary>
        /// класс, отправляющий сообщения другим страницам
        /// </summary>
        private readonly MessageBus messageBus;
        private readonly IDirectoryBIK directoryBIK;
        private readonly ICbrDsigEnvV110 cbrDsigEnvV110;
        #endregion

        #region Конструктор
        public PageMainViewModel(PageService pageService, MessageBus messageBus, IDirectoryBIK directoryBIK,
            ICbrDsigEnvV110 cbrDsigEnvV110)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
            this.directoryBIK = directoryBIK;
            this.cbrDsigEnvV110 = cbrDsigEnvV110;
        }
        #endregion

        #region Комманды
        /// <summary>
        /// Загрузить справочник БИК в БД
        /// </summary>
        public ICommand LoadCommand
        {
            get
            {
                return new MyDelegateCommand(async () =>
                {
                    directoryBIK.LoadDirectoryBIKAndSaveToDB();
                    //MessageBox.Show("Загрузка справочника БИК в БД завершена");
                    await messageBus.SendTo<PageMessageViewModel>(new Message("Загрузка справочника БИК в БД завершена"));
                    pageService.ChangePage(new PageMessage());
                });
            }
        }

        /// <summary>
        /// Просмотреть справочник БИК из БД
        /// </summary>        
        public ICommand ViewCommand
        {
            get
            {
                return new MyDelegateCommand(async () =>
                {                    
                    await messageBus.SendTo<PageDirectoryBIKViewViewModel>(new Message(""));
                    if (! StatData.Error) pageService.ChangePage(new PageDirectoryBIKView());
                    else pageService.ChangePage(new PageError());
                });
            }
        }

        /// <summary>
        /// Загрузить значение КА, ЗК в БД
        /// </summary>
        public ICommand LoadKAZKCommand
        {
            get
            {
                return new MyDelegateCommand(async() =>
                {
                    if (cbrDsigEnvV110.LoadXmlAndSaveToDB())
                    {
                        await messageBus.SendTo<PageMessageViewModel>(new Message("Загрузка значений КА, ЗК в БД завершена"));
                        pageService.ChangePage(new PageMessage());
                    }
                    else
                    {
                        await messageBus.SendTo<PageErrorViewModel>(new Message("Ошибка валидации xml файла"));
                        pageService.ChangePage(new PageError());
                    }
                    //MessageBox.Show("");
                });
            }
        }

        /// <summary>
        /// Просмотреть значение КА, ЗК из БД
        /// </summary>        
        public ICommand ViewKAZKCommand
        {
            get
            {
                return new MyDelegateCommand(async () =>
                {
                    if (!StatData.Error)
                    {
                        await messageBus.SendTo<PageCbrDsigEnvV110ViewModel>(new Message(""));
                        pageService.ChangePage(new PageCbrDsigEnvV110());
                    }
                    else
                    {
                        await messageBus.SendTo<PageErrorViewModel>(new Message(""));
                        pageService.ChangePage(new PageError());
                    }
                });
            }
        }

        /// <summary>
        /// Загрузить Конверт для КА в БД
        /// </summary>
        public ICommand LoadKACommand
        {
            get
            {
                return new MyDelegateCommand(async () =>
                {
                    cbrDsigEnvV110.LoadXmlAndSaveToDB();
                    //MessageBox.Show("Загрузка Конверта для КА в БД завершена");
                    await messageBus.SendTo<PageMessageViewModel>(new Message("Загрузка справочника БИК в БД завершена"));
                    pageService.ChangePage(new PageMessage());
                });
            }
        }

        /// <summary>
        /// Просмотреть Конверт для КА из БД
        /// </summary>        
        public ICommand ViewKACommand
        {
            get
            {
                return new MyDelegateCommand(async () =>
                {
                    if (!StatData.Error)
                    {
                        await messageBus.SendTo<PageCbrDsigV110ViewModel>(new Message(""));
                        pageService.ChangePage(new PageCbrDsigV110());
                    }
                    else
                    {
                        await messageBus.SendTo<PageErrorViewModel>(new Message(""));
                        pageService.ChangePage(new PageError());
                    }
                });
            }
        }
        #endregion
    }
}
