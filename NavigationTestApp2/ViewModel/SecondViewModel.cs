using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationTestApp2.ViewModel
{
    public class SecondViewModel
    {
        public SecondViewModel(IRegionManager iregionManager)
        {
            NavigateCommand = new DelegateCommand(Navigate);
            IregionManager = iregionManager;
        }

        private void Navigate()
        {
            IregionManager.RequestNavigate("MainContent", "FirstView");
        }

        public ICommand NavigateCommand { get; }

        public IRegionManager IregionManager { get; }
    }
}
