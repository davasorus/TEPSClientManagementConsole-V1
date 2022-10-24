using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class prodClientConfigObj : INotifyPropertyChanged
    {
        private string _clientName;
        private bool _passedHeathCheck;
        private string _lastHeathCheck;
        private string _installedCatalog_ID;
        private string _enrolledInstanceType_ID;
        private string _date_TimeModified;

        public string ClientName
        {
            get { return _clientName; }
            set
            {
                _clientName = value;

                OnPropertyChanged();
            }
        }

        public bool PassedHeathCheck
        {
            get { return _passedHeathCheck; }
            set
            {
                _passedHeathCheck = value;

                OnPropertyChanged();
            }
        }

        public string LastHeathCheckDate_Time
        {
            get { return _lastHeathCheck; }
            set
            {
                _lastHeathCheck = value;

                OnPropertyChanged();
            }
        }

        public string InstalledCatalog_ID
        {
            get { return _installedCatalog_ID; }
            set
            {
                _installedCatalog_ID = value;

                OnPropertyChanged();
            }
        }

        public string EnrolledInstanceType_ID
        {
            get { return _enrolledInstanceType_ID; }
            set
            {
                _enrolledInstanceType_ID = value;

                OnPropertyChanged();
            }
        }

        public string Date_TimeModified
        {
            get { return _date_TimeModified; }
            set
            {
                _date_TimeModified = value;

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