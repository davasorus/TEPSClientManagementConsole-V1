using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class installedCatalogObj : INotifyPropertyChanged
    {
        private string _clientName { get; set; }
        private bool _sqlCompact3532_Installed { get; set; }
        private bool _sqlCompact3564_Installed { get; set; }
        private bool _sqlCompact0464_Installed { get; set; }
        private bool _sqlCLR200832_Installed { get; set; }
        private bool _sqlCLR200864_Installed { get; set; }
        private bool _scenePD_Installed { get; set; }
        private bool _updater_Installed { get; set; }
        private bool _gisComponents32_Installed { get; set; }
        private bool _gisComponents64_Installed { get; set; }
        private bool _dotNet_Installed { get; set; }
        private bool _sqlCLR201232_Installed { get; set; }
        private bool _sqlCLR201264_Installed { get; set; }
        private bool _dbProvider_Installed { get; set; }
        private bool _lerms_Installed { get; set; }
        private bool _cad_Installed { get; set; }
        private bool _cadObserver_Installed { get; set; }
        private bool _fireMobile_Installed { get; set; }
        private bool _leMobile_Installed { get; set; }
        private bool _mobileMerge_Installed { get; set; }
        private string _mobileAgencyConfiguration { get; set; }
        private string _modifiedDate_time { get; set; }

        public string ClientName
        {
            get { return _clientName; }
            set
            {
                _clientName = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCompact3532_Installed
        {
            get { return _sqlCompact3532_Installed; }
            set
            {
                _sqlCompact3532_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCompact3564_Installed
        {
            get { return _sqlCompact3564_Installed; }
            set
            {
                _sqlCompact3564_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCompact0464_Installed
        {
            get { return _sqlCompact0464_Installed; }
            set
            {
                _sqlCompact0464_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCLR200832_Installed
        {
            get { return _sqlCLR200832_Installed; }
            set
            {
                _sqlCLR200832_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCLR200864_Installed
        {
            get { return _sqlCLR200864_Installed; }
            set
            {
                _sqlCLR200864_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCLR201232_Installed
        {
            get { return _sqlCLR201232_Installed; }
            set
            {
                _sqlCLR201232_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool SQLCLR201264_Installed
        {
            get { return _sqlCLR201264_Installed; }
            set
            {
                _sqlCLR201264_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool ScenePD_Installed
        {
            get { return _scenePD_Installed; }
            set
            {
                _scenePD_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool Updater_Installed
        {
            get { return _updater_Installed; }
            set
            {
                _updater_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool GisComponents32_Installed
        {
            get { return _gisComponents32_Installed; }
            set
            {
                _gisComponents32_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool GisComponents64_Installed
        {
            get { return _gisComponents64_Installed; }
            set
            {
                _gisComponents64_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool DotNet_Installed
        {
            get { return _dotNet_Installed; }
            set
            {
                _dotNet_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool DBProvider_Installed
        {
            get { return _dbProvider_Installed; }
            set
            {
                _dbProvider_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool LERMS_Installed
        {
            get { return _lerms_Installed; }
            set
            {
                _lerms_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool CAD_Installed
        {
            get { return _cad_Installed; }
            set
            {
                _cad_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool CADObserver_Installed
        {
            get { return _cadObserver_Installed; }
            set
            {
                _cadObserver_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool FireMobile_Installed
        {
            get { return _fireMobile_Installed; }
            set
            {
                _fireMobile_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool LEMobile_Installed
        {
            get { return _leMobile_Installed; }
            set
            {
                _leMobile_Installed = value;

                OnPropertyChanged();
            }
        }

        public bool MobileMerge_Installed
        {
            get { return _mobileMerge_Installed; }
            set
            {
                _mobileMerge_Installed = value;

                OnPropertyChanged();
            }
        }

        public string MobileAgencyConfiguration
        {
            get { return _mobileAgencyConfiguration; }
            set
            {
                _mobileAgencyConfiguration = value;

                OnPropertyChanged();
            }
        }

        public string ModifiedDate_time
        {
            get { return _modifiedDate_time; }
            set
            {
                _modifiedDate_time = value;

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