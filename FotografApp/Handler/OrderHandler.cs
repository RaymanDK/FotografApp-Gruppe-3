﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FotografApp.Model;
using FotografApp.Persistency;
using FotografApp.View;
using FotografApp.ViewModel;

namespace FotografApp.Handler
{
    class OrderHandler
    {
        private MainViewModel _viewModel { get; set; }

        public OrderHandler(MainViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public void CreateOrder()
        {
            //Register.ValidateOrderRegistration(Singleton.Instance.CurrentUser, , MainViewModel.MDateTime);
        }

        public void DeleteOrder()
        {
            DatabasePersistencyHandler.Instance.RemoveOrder(null);
        }

        public void UpdateOrder()
        {
            
        }
    }
}
