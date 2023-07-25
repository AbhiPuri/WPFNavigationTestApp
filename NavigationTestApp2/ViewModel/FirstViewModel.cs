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
    public class FirstViewModel
    {
        public FirstViewModel(IRegionManager iregionManager)
        {
            IregionManager = iregionManager;
            NavigateCommand = new DelegateCommand(Nevigate);
        }

        private void Nevigate()
        {
            IregionManager.RequestNavigate("MainContent", "SecondView");
        }


        public ICommand NavigateCommand { get; }
        public IRegionManager IregionManager { get; }
    }
}
