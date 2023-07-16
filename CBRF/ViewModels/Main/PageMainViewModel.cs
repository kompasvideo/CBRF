﻿using CBRF.Infrastructure;
using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.BIK;
using CBRF.Interfaces.UFEBS_2023_4_1;
using CBRF.Messages;
using CBRF.Pages.BIK;
using CBRF.Services;
using CBRF.ViewModels.Base;
using CBRF.ViewModels.BIK;
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
                return new MyDelegateCommand(() =>
                {
                    directoryBIK.LoadDirectoryBIKAndSaveToDB();
                    MessageBox.Show("Загрузка справочника БИК в БД завершена");
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
                    await messageBus.SendTo<PageDirectoryBIKViewViewModel>(new BIKMessage(""));
                    pageService.ChangePage(new PageDirectoryBIKView());
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
                return new MyDelegateCommand(() =>
                {
                    cbrDsigEnvV110.Load();                    
                    MessageBox.Show("Загрузка значений КА, ЗК в БД завершена");
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
                    //await messageBus.SendTo<PageDirectoryBIKViewViewModel>(new BIKMessage(""));
                    //pageService.ChangePage(new PageDirectoryBIKView());
                });
            }
        }
        #endregion
    }
}