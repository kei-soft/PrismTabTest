using System.Windows;

using Module2.Views;

using Prism.Ioc;
using Prism.Modularity;

using PrismTabTest.ViewModels;
using PrismTabTest.Views;

namespace PrismTabTest
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<Menu1>();
            containerRegistry.RegisterForNavigation<Menu2>();
            containerRegistry.RegisterDialog<ConfirmControl>();

            // 아래 처럼도 가능하네?
            //containerRegistry.RegisterForNavigation<ViewB>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1.Module1Module>(InitializationMode.WhenAvailable);

            // 수동 로드
            moduleCatalog.AddModule<Module2.Module2Module>(InitializationMode.OnDemand);
        }
    }
}
