using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEPSClientManagementConsole_V1.Core;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class mainViewModel : observableObject
    {
        //public relayCommand somethingViewCommand {get; set;}

        //public somethingViewModel somethingVM {get; set;}

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public mainViewModel()
        {
            //somethingVM = new somethingViewModel();

            //CurrentView = somethingVM; //this is the default page


            //somethingViewCommand = new relayCommand(o =>
            //{
            //   CurrentView = somethingVM;
            //});
        }
    }
}
