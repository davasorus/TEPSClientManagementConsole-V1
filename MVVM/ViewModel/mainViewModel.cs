using TEPSClientManagementConsole_V1.Core;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class mainViewModel : observableObject
    {
        public relayCommand dashboardViewCommand { get; set; }
        public relayCommand configurationViewCommand { get; set; }
        public relayCommand inAppLogReaderViewCommand { get; set; }
        public relayCommand clientMaintenanceViewCommand { get; set; }
        public relayCommand serverErrorLogViewCommand { get; set; }
        public relayCommand deploymentHistoryViewCommand { get; set; }
        public relayCommand clientMaintenance_InstalledProductSubViewCommand { get; set; }
        public relayCommand deploymentViewCommand { get; set; }
        public relayCommand deploment_SingleMachineViewCommand { get; set; }

        public dashboardViewModel dashboardVM { get; set; }
        public configurationViewModel configurationVM { get; set; }
        public inAppLogReaderViewModel inAppLogReaderVM { get; set; }
        public clientMaintenenaceViewModel clientMaintenanceVM { get; set; }
        public serverErrorLogViewModel serverErrorLogVM { get; set; }
        public deploymentHistoryViewModel deploymentHistoryVM { get; set; }
        public clientMaintenance_InstalledProductSubViewModel clientMaintenance_InstalledProductSubVM { get; set; }
        public deploymentViewModel deploymentVM { get; set; }
        public deployment_singleMachineViewModel deployment_SingleMachineVM { get; set; }

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
            dashboardVM = new dashboardViewModel();
            configurationVM = new configurationViewModel();
            inAppLogReaderVM = new inAppLogReaderViewModel();
            clientMaintenanceVM = new clientMaintenenaceViewModel();
            serverErrorLogVM = new serverErrorLogViewModel();
            deploymentHistoryVM = new deploymentHistoryViewModel();
            clientMaintenance_InstalledProductSubVM = new clientMaintenance_InstalledProductSubViewModel();
            deploymentVM = new deploymentViewModel();
            deployment_SingleMachineVM = new deployment_singleMachineViewModel();

            CurrentView = dashboardVM;

            dashboardViewCommand = new relayCommand(o =>
            {
                CurrentView = dashboardVM;
            });

            configurationViewCommand = new relayCommand(o =>
            {
                CurrentView = configurationVM;
            });

            inAppLogReaderViewCommand = new relayCommand(o =>
            {
                CurrentView = inAppLogReaderVM;
            });

            clientMaintenanceViewCommand = new relayCommand(o =>
            {
                CurrentView = clientMaintenanceVM;
            });

            serverErrorLogViewCommand = new relayCommand(o =>
            {
                CurrentView = serverErrorLogVM;
            });

            deploymentHistoryViewCommand = new relayCommand(o =>
            {
                CurrentView = deploymentHistoryVM;
            });

            clientMaintenance_InstalledProductSubViewCommand = new relayCommand(o =>
            {
                CurrentView = clientMaintenance_InstalledProductSubVM;
            });

            deploymentViewCommand = new relayCommand(o =>
            {
                CurrentView = deploymentVM;
            });

            deploment_SingleMachineViewCommand = new relayCommand(o =>
            {
                CurrentView = deployment_SingleMachineVM;
            });
        }
    }
}