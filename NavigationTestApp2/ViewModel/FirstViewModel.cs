using Prism.Commands;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationTestApp2.ViewModel
{
    public class FirstViewModel
    {
        log4net.ILog logger;

        public FirstViewModel(IRegionManager iregionManager)
        {
            IregionManager = iregionManager;
            NavigateCommand = new DelegateCommand(Nevigate);
            //logger = log4net.LogManager.GetLogger(typeof(FirstViewModel));
            logger = log4net.LogManager.GetLogger("FirstViewModel");
        }

        private void Nevigate()
        {
            logger.Info(string.Concat("First view navigation started,", " User:" + ConfigurationManager.AppSettings["userName"] + ", ", (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber()));
            IregionManager.RequestNavigate("MainContent", "SecondView");
        }


        public ICommand NavigateCommand { get; }
        public IRegionManager IregionManager { get; }
    }
}
