using System.Windows.Controls;
using TEPSClientManagementConsole_V1.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.View
{
    /// <summary>
    /// Interaction logic for configurationView.xaml
    /// </summary>
    public partial class configurationView : UserControl
    {
        private jsonClass jsonClass = new jsonClass();
        private masterMangeEndPointInteractionClass masterMangeEndPointInteractionClass = new masterMangeEndPointInteractionClass();

        public configurationView()
        {
            InitializeComponent();
        }

        private void prodEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            jsonClass.saveStartupSettings();

            masterMangeEndPointInteractionClass.PostUpdateSettingProd();

            if (!String.IsNullOrEmpty(configurationViewModel._prodMasterServiceServer))
            {
                masterMangeEndPointInteractionClass.GetAllClients();

                 masterMangeEndPointInteractionClass.GetAllCatalogs();

                 masterMangeEndPointInteractionClass.GetTop1000Errors();

                 masterMangeEndPointInteractionClass.GetInstallLogs();

                 masterMangeEndPointInteractionClass.GetuninstallLogs();
            }
        }

        private void TrainEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            jsonClass.saveStartupSettings();

            //masterMangeEndPointInteractionClass.PostUpdateSettingTest();
        }

        private void TestEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            jsonClass.saveStartupSettings();

            //masterMangeEndPointInteractionClass.PostUpdateSettingTrain();
        }
    }
}