﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfW38_KISS_Navigation.View;

namespace WpfW38_KISS_Navigation.ViewModel
{
    class BlueViewModel : Model.Bindable
    {
        private string id = "Blue";

        public string ID
        {
            get { return id; }
            set { id = value;this.propertyIsChanged(); }
        }

        public BlueViewModel()
        {
            AddTextCMD = new DelegateCommand(Add);
            //ChangePageCMD = new DelegateCommand(Add);
        }

        public ICommand AddTextCMD { get; set; }
        public ICommand ChangePageCMD { get; set; } = new DelegateCommand( () => 
        { 
            ((App)App.Current).ChangeUserControl( new RedView() ); 
        });

        //public ICommand ChangePageCMD2 { get; set; } = new DelegateCommand(ChangeView2);

        //public void ChangeView2<Object>()
        //{
            
        //    ((App)App.Current).ChangeUserControl(new RedView());
        //}

        private void Add() {
            this.ID += " BLUE ";
        }
    }
}
