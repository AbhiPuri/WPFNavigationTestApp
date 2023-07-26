using NavigationTestApp2.Module;
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

            ///Returning Complete Class name with Namespace
            //logger = log4net.LogManager.GetLogger(typeof(FirstViewModel));

            ///Returning Only Class name
            logger = log4net.LogManager.GetLogger("FirstViewModel");

            //string user1 = MainModule.Instance.SingleUser;
        }

        private void Nevigate()
        {
            ///Reading User from Config File
            //logger.Info(string.Concat("First view navigation started,", " User:" + ConfigurationManager.AppSettings["userName"] + ", ", (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber()));
            
            ///Reading User From Singleton Class
            logger.Info(string.Concat("First view navigation started,", " User:" + MainModule.Instance.SingleUser + ", ", (new System.Diagnostics.StackFrame(0, true)).GetFileLineNumber()));
            
            IregionManager.RequestNavigate("MainContent", "SecondView");
        }


        public ICommand NavigateCommand { get; }
        public IRegionManager IregionManager { get; }
    }
}
