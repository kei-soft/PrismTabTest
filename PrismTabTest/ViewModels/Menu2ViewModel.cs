using System;
using System.Collections.Generic;
using System.Linq;

using Prism.Commands;
using Prism.Mvvm;

namespace PrismTabTest.ViewModels
{
    public class Menu2ViewModel : BindableBase
    {
        private string _title = "Menu2";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public Menu2ViewModel()
        {

        }
    }
}
