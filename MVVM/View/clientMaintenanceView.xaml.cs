using System;
using System.Linq;
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

            if (clientMaintenenaceViewModel._installedCatalogID.ToString() != null)
            {
                prodClientInstallHistory.IsEnabled = true;
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

        private void prodClientInstallHistory_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var catalog = installedCatalogObjs.Collection.FirstOrDefault(o => o.ClientName == prodClientMachineName.Text);

            if (catalog != null)
            {
                if (!string.IsNullOrEmpty(catalog.ModifiedDate_time))
                {
                    clientMaintenance_InstalledProductSubViewModel._dateTimeModified = DateTime.Parse(catalog.ModifiedDate_time);
                }
                else
                {
                    clientMaintenance_InstalledProductSubViewModel._dateTimeModified = DateTime.MinValue;
                }

                clientMaintenance_InstalledProductSubViewModel._prodClientName = catalog.ClientName;
                clientMaintenance_InstalledProductSubViewModel._prodSQL3532CompactState = catalog.SQLCompact3532_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQL3564CompactState = catalog.SQLCompact3564_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQL0464CompactState = catalog.SQLCompact0464_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQLCLR0832CompactState = catalog.SQLCLR200832_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQLCLR0864CompactState = catalog.SQLCLR200864_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQLCLR1232CompactState = catalog.SQLCLR201232_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodSQLCLR1264CompactState = catalog.SQLCLR201264_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodScenePDState = catalog.ScenePD_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodUpdaterState = catalog.Updater_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodGISComp32CompactState = catalog.GisComponents32_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodGISComp64CompactState = catalog.GisComponents64_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodDotNetState = catalog.DotNet_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodDBProviderState = catalog.DBProvider_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodLERMSState = catalog.LERMS_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodCADState = catalog.CAD_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodFireMobileState = catalog.FireMobile_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodLEMobilePDState = catalog.LEMobile_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodMobileMergePDState = catalog.MobileMerge_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodCADObserverState = catalog.MobileMerge_Installed;
                clientMaintenance_InstalledProductSubViewModel._prodMobileUpdaterConfig = catalog.MobileAgencyConfiguration;
            }
            else
            {
                clientMaintenance_InstalledProductSubViewModel._prodClientName = "ERROR: No record of install";
            }
        }
    }
}