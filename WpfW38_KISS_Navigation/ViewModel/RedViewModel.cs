﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfW38_KISS_Navigation.View;

namespace WpfW38_KISS_Navigation.ViewModel
{
    class RedViewModel : Model.Bindable
    {
        private string id = "Red";

        public string ID
        {
            get { return id; }
            set { id = value; this.propertyIsChanged(); }
        }

        public RedViewModel()
        {
            AddTextCMD = new DelegateCommand(Add);
        }

        private void Add()
        {
            this.ID += " RED ";
        }


        public ICommand AddTextCMD { get; set; }
        public ICommand ChangePageCMD { get; set; } = new DelegateCommand(() => 
        { 
            ((App)App.Current).ChangeUserControl( new BlueView() ); 
        });
    }
}
