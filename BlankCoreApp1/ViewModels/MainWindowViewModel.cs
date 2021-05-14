using System;
using System.Windows.Input;

using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;

namespace BlankCoreApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;

        public ICommand MenuCommand { get; set; }

        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;
            //_regionManager.RegisterViewWithRegion
            MenuCommand = new DelegateCommand<string>(OnMenu);
        }

        private void OnMenu(string obj)
        {
            _regionManager.RequestNavigate("ContentRegion", obj);

            //switch (obj)
            //{
            //    case "View1":
            //        //_regionManager.RequestNavigate("ContentRegion", "Menu1");
            //        break;

            //    case "View2":
            //        //_regionManager.RequestNavigate("ContentRegion", "Menu2");
            //        break;

            //    case "People":
            //        //_regionManager.RequestNavigate("ContentRegion", "Menu2");
            //        break;

            //    default:
            //        break;
            //}
        }
    }
}
