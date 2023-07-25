using Prism.Ioc;
using Prism.Modularity;
using System;
using Prism.Regions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationTestApp2.View;

namespace NavigationTestApp2.Module
{
    class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var region = containerProvider.Resolve<IRegionManager>();
            region.RegisterViewWithRegion("MainContent", typeof(FirstView));
            //region.RegisterViewWithRegion("MainContent", typeof(FirstView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<FirstView>();
            containerRegistry.RegisterForNavigation<SecondView>();
        }
    }
}
