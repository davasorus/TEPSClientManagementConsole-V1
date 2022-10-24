using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class clientMaintenenaceViewModel : INotifyPropertyChanged
    {
        public static string _prodClientName;
        public static string _prodInstalledCatalog_ID;

        public static bool _prodPassedHealthCheck;
        public static DateTime _healthCheckDateTime;

        public static int _installedCatalogID;
        public static DateTime _dateTimeModified;

        public string prodClientName
        {
            get { return _prodClientName; }
            set
            {
                _prodClientName = value;
                OnPropertyChanged();
            }
        }

        public string prodInstalledCatalog_ID
        {
            get { return _prodInstalledCatalog_ID; }
            set
            {
                _prodInstalledCatalog_ID = value;
                OnPropertyChanged();
            }
        }

        public bool prodPassedHealthCheck
        {
            get { return _prodPassedHealthCheck; }
            set
            {
                _prodPassedHealthCheck = value;
                OnPropertyChanged();
            }
        }

        public DateTime prodHealthCheckDateTime
        {
            get { return _healthCheckDateTime; }
            set
            {
                _healthCheckDateTime = value;
                OnPropertyChanged();
            }
        }

        public int prodInstalledCatalogID
        {
            get { return _installedCatalogID; }
            set
            {
                _installedCatalogID = value;
                OnPropertyChanged();
            }
        }

        public DateTime prodDateTimeModified
        {
            get { return _dateTimeModified; }
            set
            {
                _dateTimeModified = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //notifies the collection that the object has changed, and should be displayed
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}