//using NavigationTestApp2.View;

//using Prism.Modularity;
//using System;
//using System.Collections.Generic;
////using System.ComponentModel;
//using System.Configuration;
//using System.Data;
//using System.Linq;
//using System.Threading.Tasks;
using Prism.Unity;
using System.Windows;
using Prism.Ioc;
using NavigationTestApp2.View;
using Prism.Modularity;
using NavigationTestApp2.Module;

namespace NavigationTestApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            //var shell = Container.Resolve<MainView>();//where Main is a window to display on start up which present in view folder
            var shell = Container.Resolve<MainWindow>();//where Main is a window to display on start up which present in view folder
            return shell;
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<MainModule>();
        }
    }
}
