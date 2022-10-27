using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class clientMaintenance_InstalledProductSubViewModel : INotifyPropertyChanged
    {
        public static string _prodClientName;
        public static DateTime _dateTimeModified;
        public static bool _prodSQL3532CompactState;
        public static bool _prodSQL3564CompactState;
        public static bool _prodSQL0464CompactState;
        public static bool _prodGISComp32CompactState;
        public static bool _prodGISComp64CompactState;
        public static bool _prodSQLCLR0832CompactState;
        public static bool _prodSQLCLR0864CompactState;
        public static bool _prodSQLCLR1232CompactState;
        public static bool _prodSQLCLR1264CompactState;
        public static bool _prodDotNetState;
        public static bool _prodUpdaterState;
        public static bool _prodDBProviderState;
        public static bool _prodScenePDState;
        public static bool _prodLERMSState;
        public static bool _prodCADState;
        public static bool _prodFireMobileState;
        public static bool _prodLEMobilePDState;
        public static bool _prodMobileMergePDState;
        public static bool _prodCADObserverState;
        public static string _prodMobileUpdaterConfig;

        public string prodClientName
        {
            get { return _prodClientName; }
            set
            {
                _prodClientName = value;
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

        public bool prodSQL3532CompactState
        {
            get { return _prodSQL3532CompactState; }
            set
            {
                _prodSQL3532CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQL3564CompactState
        {
            get { return _prodSQL3564CompactState; }
            set
            {
                _prodSQL3564CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQL0464CompactState
        {
            get { return _prodSQL0464CompactState; }
            set
            {
                _prodSQL0464CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodGISComp32CompactState
        {
            get { return _prodGISComp32CompactState; }
            set
            {
                _prodGISComp32CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodGISComp64CompactState
        {
            get { return _prodGISComp64CompactState; }
            set
            {
                _prodGISComp64CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQLCLR0832CompactState
        {
            get { return _prodSQLCLR0832CompactState; }
            set
            {
                _prodSQLCLR0832CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQLCLR0864CompactState
        {
            get { return _prodSQLCLR0864CompactState; }
            set
            {
                _prodSQLCLR0864CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQLCLR1232CompactState
        {
            get { return _prodSQLCLR1232CompactState; }
            set
            {
                _prodSQLCLR1232CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodSQLCLR1264CompactState
        {
            get { return _prodSQLCLR1264CompactState; }
            set
            {
                _prodSQLCLR1264CompactState = value;
                OnPropertyChanged();
            }
        }

        public bool prodDotNetState
        {
            get { return _prodDotNetState; }
            set
            {
                _prodDotNetState = value;
                OnPropertyChanged();
            }
        }

        public bool prodUpdaterState
        {
            get { return _prodUpdaterState; }
            set
            {
                _prodUpdaterState = value;
                OnPropertyChanged();
            }
        }

        public bool prodDBProviderState
        {
            get { return _prodDBProviderState; }
            set
            {
                _prodDBProviderState = value;
                OnPropertyChanged();
            }
        }

        public bool prodScenePDState
        {
            get { return _prodScenePDState; }
            set
            {
                _prodScenePDState = value;
                OnPropertyChanged();
            }
        }

        public bool prodLERMSState
        {
            get { return _prodLERMSState; }
            set
            {
                _prodLERMSState = value;
                OnPropertyChanged();
            }
        }

        public bool prodCADState
        {
            get { return _prodCADState; }
            set
            {
                _prodCADState = value;
                OnPropertyChanged();
            }
        }

        public bool prodFireMobileState
        {
            get { return _prodFireMobileState; }
            set
            {
                _prodFireMobileState = value;
                OnPropertyChanged();
            }
        }

        public bool prodLEMobilePDState
        {
            get { return _prodLEMobilePDState; }
            set
            {
                _prodLEMobilePDState = value;
                OnPropertyChanged();
            }
        }

        public bool prodMobileMergePDState
        {
            get { return _prodMobileMergePDState; }
            set
            {
                _prodMobileMergePDState = value;
                OnPropertyChanged();
            }
        }

        public bool prodCADObserverState
        {
            get { return _prodCADObserverState; }
            set
            {
                _prodCADObserverState = value;
                OnPropertyChanged();
            }
        }

        public string prodMobileUpdaterConfig
        {
            get { return _prodMobileUpdaterConfig; }
            set
            {
                _prodMobileUpdaterConfig = value;
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