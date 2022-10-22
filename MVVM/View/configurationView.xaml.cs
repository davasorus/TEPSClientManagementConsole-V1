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

        public configurationView()
        {
            InitializeComponent();
        }

        private void prodEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            jsonClass.saveStartupSettings();
        }

        private void TrainEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }

        private void TestEnvironmentConfigBtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
        }
    }
}