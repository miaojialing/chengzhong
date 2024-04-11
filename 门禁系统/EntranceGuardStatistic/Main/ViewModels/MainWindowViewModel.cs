﻿using AJWPFAdmin.Core.GlobalEvents;
using AJWPFAdmin.Services.EF.Tables;
using AJWPFAdmin.Services;
using Prism.Events;
using Prism.Mvvm;
using System.Windows;

namespace EntranceGuardStatistic.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "车辆计数系统-岗亭端";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private bool _menuOpen;
        public bool MenuOpen
        {
            get { return _menuOpen; }
            set { SetProperty(ref _menuOpen, value); }
        }

        private SystemUser _curUser;
        public SystemUser CurrentUser
        {
            get { return _curUser; }
            set { SetProperty(ref _curUser, value); }
        }

        private SideMenuNavEvent _sideMenuNavEvent;

        public MainWindowViewModel(IEventAggregator eventAggregator, SystemUserService sysUserSvc)
        {
            _curUser = sysUserSvc.CurrnetUser;
            var version = Application.ResourceAssembly.GetName().Version;
            Title = $"车辆计数系统-岗亭端 {version}";
            //_sideMenuNavEvent = eventAggregator.GetEvent<SideMenuNavEvent>();
            //_sideMenuNavEvent.Subscribe((name) =>
            //{
            //    MenuOpen = false;
            //});

        }
    }
}
