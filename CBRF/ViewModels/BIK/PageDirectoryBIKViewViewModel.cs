﻿using CBRF.Infrastructure;
using CBRF.Infrastructure.Commands;
using CBRF.Interfaces.BIK;
using CBRF.Messages;
using CBRF.Pages;
using CBRF.Pages.Main;
using CBRF.Services;
using CBRF.ViewModels.Base;
using CBRF_DB.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;

namespace CBRF.ViewModels.BIK
{
    public class PageDirectoryBIKViewViewModel : ViewModel
    {
        public ObservableCollection<BICDirectoryEntry> ParticipantInfo { get; set; }

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
        #endregion

        #region Конструктор
        public PageDirectoryBIKViewViewModel(PageService pageService, MessageBus messageBus, IDirectoryBIK directoryBIK)
        {
            this.pageService = pageService;
            this.messageBus = messageBus;
            this.directoryBIK = directoryBIK;
            messageBus.Receive<Message>(this, message =>
            {
                var item = directoryBIK.ViewDirectoryBIKInDB();
                if (item != null && item.Count > 0) ParticipantInfo = new ObservableCollection<BICDirectoryEntry>(item);
                else
                {
                    ParticipantInfo = new ObservableCollection<BICDirectoryEntry>();
                    StatData.Error = true;
                    StatData.ErrorMessage = "Нет БД БИК";
                    messageBus.SendTo<PageErrorViewModel>(new Message(""));                    
                }
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

