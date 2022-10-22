using System.Windows.Controls;

namespace TEPSClientManagementConsole_V1.MVVM.View
{
    /// <summary>
    /// Interaction logic for configurationView.xaml
    /// </summary>
    public partial class configurationView : UserControl
    {
        public configurationView()
        {
            InitializeComponent();
        }

        private void appServerNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(appServerNameProd.Text))
            {

            }
        }

        private void essServerNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cadServerNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void gisServerNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void gisInstanceNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mobileServerNameProd_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}