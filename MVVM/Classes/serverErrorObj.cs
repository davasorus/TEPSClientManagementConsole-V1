using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class serverErrorObj : INotifyPropertyChanged
    {
        private string _clientName;
        private string _logMess;
        private DateTime _logDateTime;

        public string ClientName
        {
            get { return _clientName; }
            set
            {
                _clientName = value;

                OnPropertyChanged();
            }
        }

        public string ErrorMessage
        {
            get { return _logMess; }
            set
            {
                _logMess = value;

                OnPropertyChanged();
            }
        }

        public DateTime ErrorDate_Time
        {
            get { return _logDateTime; }
            set
            {
                _logDateTime = value;

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