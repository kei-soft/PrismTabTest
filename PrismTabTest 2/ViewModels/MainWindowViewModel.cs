using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

using Prism.Commands;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

using PrismTabTest.Views;

namespace PrismTabTest.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly IRegionManager _regionManager;
        private readonly IModuleManager _moduleManager;

        public ICommand MenuCommand { get; set; }

        public ICommand LoadModuleCommand { get; set; }

        private string _title = "Prism Application";

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager, IModuleManager moduleManager)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;

            MenuCommand = new DelegateCommand<string>(OnMenu);
            LoadModuleCommand = new DelegateCommand(OnLoadModule);
        }

        private void OnLoadModule()
        {
            _moduleManager.LoadModuleCompleted += _moduleManager_LoadModuleCompleted;
            _moduleManager.LoadModule("Module2Module");
        }

        private void _moduleManager_LoadModuleCompleted(object sender, LoadModuleCompletedEventArgs e)
        {
            _moduleManager.LoadModuleCompleted -= _moduleManager_LoadModuleCompleted;
            MessageBox.Show("Load Module Complete");
        }

        private void OnMenu(string obj)
        {
            _regionManager.RequestNavigate("ContentRegion", obj, callback =>
            {
                if (callback.Error == null) return;

                // 에러 난 경우 모듈 로딩 -  이렇게 하면 어플리케이션 동작시 빨라지고 사용할때 모듈을 로드해서 사용한다.
                Debug.WriteLine("");
                _moduleManager.LoadModule("Module2Module");
                OnMenu(obj);
            });

            //switch (obj)
            //{
            //    case "Menu1":
            //        _regionManager.RequestNavigate("ContentRegion", "Menu1");
            //        break;

            //    case "Menu2":
            //        _regionManager.RequestNavigate("ContentRegion", "Menu2");

            //        break;

            //    case "ViewA":
            //        _regionManager.RequestNavigate("ContentRegion", "ViewA");
            //        break;

            //    case "ViewB":
            //        _regionManager.RequestNavigate("ContentRegion", "ViewB");
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
