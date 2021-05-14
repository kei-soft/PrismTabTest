using System.Windows;

using BlankCoreApp1.Views;

using Prism.Ioc;
using Prism.Modularity;

namespace BlankCoreApp1
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

        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<Module1.Module1Module>(InitializationMode.WhenAvailable);
            moduleCatalog.AddModule<Module2.Module2Module>(InitializationMode.WhenAvailable);
        }
    }
}
