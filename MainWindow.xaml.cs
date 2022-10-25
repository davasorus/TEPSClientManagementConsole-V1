using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Timers;
using TEPSClientManagementConsole_V1.Classes;
using TEPSClientManagementConsole_V1.MVVM.Classes;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private loggingClass loggingClass = new loggingClass();
        private jsonClass jsonClass = new jsonClass();
        private masterMangeEndPointInteractionClass masterMangeEndPointInteractionClass = new masterMangeEndPointInteractionClass();

        public MainWindow()
        {
            InitializeComponent();

            loggingClass.initializeNLogLogger();

            Loaded += MainWindow_Loaded;

            snackbarQues.Collection.CollectionChanged += Collection_CollectionChanged;

            updateSnackBar("snackbar Testing");
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

            appNameLbl.Text = " TEPS Console";

            appVersionLbl.Text = version;

            loggingClass.nLogLogger(@"----------- Start of log file-----------", "info");

            jsonClass.initialLoadofJSON();

            Task task1 = Task.Factory.StartNew(() => apiLoadData());

             Timer updateCheckTimer = new Timer
            {
                Interval = 60000
            };
            updateCheckTimer.Start();

            updateCheckTimer.Elapsed += updateCheckTimer_Elapsed;

            //preReqStatus.loadDefaultStatuses();

            //Task task1 = Task.Factory.StartNew(() => apiClass.updateAPICheck());

            //Task task2 = Task.Factory.StartNew(() => loadApiMessage());

            //Task task3 = Task.Factory.StartNew(() => apiClass.getAll());
        }

        public async Task apiLoadData()
        {
            if (!String.IsNullOrEmpty(configurationViewModel._prodMasterServiceServer))
            {
                await masterMangeEndPointInteractionClass.GetAllClients();

                await masterMangeEndPointInteractionClass.GetAllCatalogs();

                await masterMangeEndPointInteractionClass.GetTop1000Errors();

                await masterMangeEndPointInteractionClass.GetInstallLogs();

                await masterMangeEndPointInteractionClass.GetuninstallLogs();
            }
        }

        #region button clicks

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Dashboard";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Deployments";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Configuration";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Place Holder";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Utility Updater";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Client Maintenance";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            formNameLbl.Text = "Server Error Log";
        }

        private void mouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void minButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Minimized;
        }

        #endregion button clicks

        #region functions

        private void updateCheckTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Task task1 = Task.Factory.StartNew(() => apiLoadData());
        }

        private void updateSnackBar(string message)
        {
            this.Dispatcher.Invoke(new Action(() => snackBar.IsActive = true));
            this.Dispatcher.Invoke(new Action(() => snackBar.MessageQueue.Enqueue(message)));
        }

        private void Collection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            List<int> nums = new List<int>();

            foreach (var Woj in snackbarQues.Collection)
            {
                updateSnackBar(Woj.Message);

                nums.Add(Woj.Message.IndexOf(Woj.Message));
            }

            foreach (var medina in nums)
            {
                snackbarQues.Collection.RemoveAt(medina);
            }
        }

        #endregion functions
    }
}