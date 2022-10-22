using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class loggingObj : INotifyPropertyChanged
    {
        private string _logMess;
        private DateTime _logDateTime;

        public string Message
        {
            get { return _logMess; }
            set
            {
                _logMess = value;

                OnPropertyChanged();
            }
        }

        public DateTime Date
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
