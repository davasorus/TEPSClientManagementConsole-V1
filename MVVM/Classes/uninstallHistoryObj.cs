using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class uninstallHistoryObj : INotifyPropertyChanged
    {
        private string _clientName;
        private string _enrolledInstance;
        private string _action;
        private DateTime _transactionDate_Time;

        public string ClientName
        {
            get { return _clientName; }
            set
            {
                _clientName = value;

                OnPropertyChanged();
            }
        }

        public string EnrolledInstanceType
        {
            get { return _enrolledInstance; }
            set
            {
                _enrolledInstance = value;

                OnPropertyChanged();
            }
        }

        public string ErrorMessage
        {
            get { return _action; }
            set
            {
                _action = value;

                OnPropertyChanged();
            }
        }

        public DateTime TransactionDate_Time
        {
            get { return _transactionDate_Time; }
            set
            {
                _transactionDate_Time = value;

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
