using System;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1.MVVM.View
{
    /// <summary>
    /// Interaction logic for clientMaintenance_InstalledProductSubView.xaml
    /// </summary>
    public partial class clientMaintenance_InstalledProductSubView : UserControl
    {
        public clientMaintenance_InstalledProductSubView()
        {
            InitializeComponent();

            Loaded += ClientMaintenance_InstalledProductSubView_Loaded;
        }

        private void ClientMaintenance_InstalledProductSubView_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Dispatcher.Invoke(new Action(() => prodClientMachineName.Text = clientMaintenance_InstalledProductSubViewModel._prodClientName));
            this.Dispatcher.Invoke(new Action(() => prodClientModifiedDateTime.Text = clientMaintenance_InstalledProductSubViewModel._dateTimeModified.ToString()));
            this.Dispatcher.Invoke(new Action(() => prodMobileUpdaterConfig.Text = clientMaintenance_InstalledProductSubViewModel._prodMobileUpdaterConfig));
            this.Dispatcher.Invoke(new Action(() => prodSqlCompact3532Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQL3532CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCompact3564Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQL3564CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCompact0464Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQL0464CompactState));
            this.Dispatcher.Invoke(new Action(() => prodGisComp32Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodGISComp32CompactState));
            this.Dispatcher.Invoke(new Action(() => prodGisComp64Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodGISComp64CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCLR0832Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQLCLR0832CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCLR0864Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQLCLR0864CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCLR1232Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQLCLR1232CompactState));
            this.Dispatcher.Invoke(new Action(() => prodSqlCLR1264Slider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodSQLCLR1264CompactState));
            this.Dispatcher.Invoke(new Action(() => prodDotNetSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodDotNetState));
            this.Dispatcher.Invoke(new Action(() => prodUpdaterSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodUpdaterState));
            this.Dispatcher.Invoke(new Action(() => prodDBProviderSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodDBProviderState));
            this.Dispatcher.Invoke(new Action(() => prodScenePDSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodScenePDState));
            this.Dispatcher.Invoke(new Action(() => prodCADSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodCADState));
            this.Dispatcher.Invoke(new Action(() => prodFireMobileSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodFireMobileState));
            this.Dispatcher.Invoke(new Action(() => prodLEMobileSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodLEMobilePDState));
            this.Dispatcher.Invoke(new Action(() => prodMergeSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodMobileMergePDState));
            this.Dispatcher.Invoke(new Action(() => prodCADObservSlider.IsChecked = clientMaintenance_InstalledProductSubViewModel._prodCADObserverState));
        }
    }
}