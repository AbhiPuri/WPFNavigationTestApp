using Prism.Ioc;
using Prism.Modularity;
using System;
using Prism.Regions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationTestApp2.View;
using System.Configuration;

namespace NavigationTestApp2.Module
{
    //class MainModule : IModule
    //{
    //    public void OnInitialized(IContainerProvider containerProvider)
    //    {
    //        ///Setting User value from Configuration File.
    //        ConfigurationManager.AppSettings["userName"] = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
    //        var region = containerProvider.Resolve<IRegionManager>();
    //        region.RegisterViewWithRegion("MainContent", typeof(FirstView));

    //        log4net.Config.BasicConfigurator.Configure();
    //    }

    //    public void RegisterTypes(IContainerRegistry containerRegistry)
    //    {
    //        containerRegistry.RegisterForNavigation<FirstView>();
    //        containerRegistry.RegisterForNavigation<SecondView>();
    //    }
    //}

    public class MainModule : IModule
    {
        private static MainModule instance = null;

        /// For Singleton Class use
        public string SingleUser { get; set; }
        private static object syncLock = new object();

        public void OnInitialized(IContainerProvider containerProvider)
        {
            ///Setting User value from Configuration File.
            //ConfigurationManager.AppSettings["userName"] = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            ///Setting User value from Current/LoggedIn profile.
            //SingleUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainContent", typeof(FirstView));

            log4net.Config.BasicConfigurator.Configure();
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<FirstView>();
            containerRegistry.RegisterForNavigation<SecondView>();
        }

        public static MainModule Instance
        {
            get
            {
                lock (syncLock)
                {
                    if (MainModule.instance == null)
                    {
                        MainModule.instance = new MainModule() { SingleUser = System.Security.Principal.WindowsIdentity.GetCurrent().Name };
                    }
                    return MainModule.instance;
                }
            }
        }
    }
}
