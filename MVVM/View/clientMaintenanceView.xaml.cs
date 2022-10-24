using System;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.Classes;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1.MVVM.View
{
    /// <summary>
    /// Interaction logic for clientMaintenanceView.xaml
    /// </summary>
    public partial class clientMaintenanceView : UserControl
    {
        public clientMaintenanceView()
        {
            InitializeComponent();
        }

        private void prodDataUILoad()
        {
            this.Dispatcher.Invoke(new Action(() => prodClientMachineName.Text = clientMaintenenaceViewModel._prodClientName));
            this.Dispatcher.Invoke(new Action(() => prodClientEnrolledInstance.Text = clientMaintenenaceViewModel._prodInstalledCatalog_ID));
            this.Dispatcher.Invoke(new Action(() => prodClientHealthCheck.Text = clientMaintenenaceViewModel._prodPassedHealthCheck.ToString()));
            this.Dispatcher.Invoke(new Action(() => prodClientHealthCheckDate.Text = clientMaintenenaceViewModel._healthCheckDateTime.ToString()));
            this.Dispatcher.Invoke(new Action(() => prodClientModifiedDateTime.Text = clientMaintenenaceViewModel._dateTimeModified.ToString()));

            if(clientMaintenenaceViewModel._installedCatalogID.ToString() != null)
            {
                prodClientInstallHistory.IsEnabled= true;
            }
        }

        private void prodClientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            prodClientConfigObj prod = (prodClientConfigObj)prodClientGrid.SelectedItems[0];

            var clientName = "";
            bool healthCheck = false;
            DateTime heathCheckDateTime = DateTime.MinValue;
            DateTime modifiedDateTime = DateTime.MinValue;
            int catalogID = 0;

            try
            {
                clientName = prod.ClientName;
                healthCheck = prod.PassedHeathCheck;
                heathCheckDateTime = DateTime.Parse(prod.LastHeathCheckDate_Time);
                modifiedDateTime = DateTime.Parse(prod.Date_TimeModified);
                catalogID = int.Parse(prod.InstalledCatalog_ID);
            }
            catch (Exception ex)
            {
            }

            clientMaintenenaceViewModel._prodClientName = clientName;
            clientMaintenenaceViewModel._prodInstalledCatalog_ID = "Prod";
            clientMaintenenaceViewModel._prodPassedHealthCheck = healthCheck;
            clientMaintenenaceViewModel._healthCheckDateTime = heathCheckDateTime;
            clientMaintenenaceViewModel._dateTimeModified = modifiedDateTime;
            clientMaintenenaceViewModel._installedCatalogID = catalogID;

            prodDataUILoad();
        }

        private void testClientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            testClientConfigObj test = (testClientConfigObj)testClientGrid.SelectedItems[0];

            var clientName = test.ClientName;
            var catalogName = test.InstalledCatalog_ID;
        }

        private void trainClientGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            trainClientConfigObj train = (trainClientConfigObj)trainClientGrid.SelectedItems[0];

            var clientName = train.ClientName;
            var catalogName = train.InstalledCatalog_ID;
        }
    }
}