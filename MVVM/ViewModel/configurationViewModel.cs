using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class configurationViewModel : INotifyPropertyChanged
    {
        public static string _trelloKey;
        public static string _trelloToken;
        public static string _trelloErrorID;

        public string trelloKey
        {
            get { return _trelloKey; }
            set
            {
                _trelloKey = value;
                OnPropertyChanged();
            }
        }

        public string trelloToken
        {
            get { return _trelloToken; }
            set
            {
                _trelloToken = value;
                OnPropertyChanged();
            }
        }

        public string trelloErrorID
        {
            get { return _trelloErrorID; }
            set
            {
                _trelloErrorID = value;
                OnPropertyChanged();
            }
        }

        public static string _prodAppServerName;
        public static string _prodCadServerName;
        public static string _prodEssServerName;
        public static string _prodGisServerName;
        public static string _prodGisInstanceName;
        public static string _prodMobileServerName;
        public static string _prodMasterServiceServer;
        public static string _prodClientInstallServerName;

        public string prodAppServerName
        {
            get { return _prodAppServerName; }
            set
            {
                _prodAppServerName = value;
                OnPropertyChanged();
            }
        }

        public string prodCadServerName
        {
            get { return _prodCadServerName; }
            set
            {
                _prodCadServerName = value;
                OnPropertyChanged();
            }
        }

        public string prodEssServerName
        {
            get { return _prodEssServerName; }
            set
            {
                _prodEssServerName = value;
                OnPropertyChanged();
            }
        }

        public string prodGisServerName
        {
            get { return _prodGisServerName; }
            set
            {
                _prodGisServerName = value;
                OnPropertyChanged();
            }
        }

        public string prodGisInstanceName
        {
            get { return _prodGisInstanceName; }
            set
            {
                _prodGisInstanceName = value;
                OnPropertyChanged();
            }
        }

        public string prodMobileServerName
        {
            get { return _prodMobileServerName; }
            set
            {
                _prodMobileServerName = value;
                OnPropertyChanged();
            }
        }

        public string prodMasterServiceServer
        {
            get { return _prodMasterServiceServer; }
            set
            {
                _prodMasterServiceServer = value;
                OnPropertyChanged();
            }
        }

        public string prodClientInstallServerName
        {
            get { return _prodClientInstallServerName; }
            set
            {
                _prodClientInstallServerName = value;
                OnPropertyChanged();
            }
        }

        public static string testAppServerName { get; set; }
        public static string testCadServerName { get; set; }
        public static string testEssServerName { get; set; }
        public static string testGisServerName { get; set; }
        public static string testGisInstanceName { get; set; }
        public static string testMobileServerName { get; set; }
        public static string testMasterServiceServer { get; set; }
        public static string testClientInstallServerName { get; set; }

        public static string trainAppServerName { get; set; }
        public static string trainCadServerName { get; set; }
        public static string trainEssServerName { get; set; }
        public static string trainGisServerName { get; set; }
        public static string trainGisInstanceName { get; set; }
        public static string trainMobileServerName { get; set; }
        public static string trainMasterServiceServer { get; set; }
        public static string trainClientInstallServerName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        //notifies the collection that the object has changed, and should be displayed
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}