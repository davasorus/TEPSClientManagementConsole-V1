using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class activeDeploymentObj : INotifyPropertyChanged
    {
        private string _clientName { get; set; }
        private string _currentlyRunning { get; set; }
        private int _currentNumber { get; set; }
        private int _totalNumber { get; set; }
        private bool _errorsFound { get; set; }

        public string client_Name
        {
            get { return _clientName; }
            set
            {
                _clientName = value;
                OnPropertyChanged();
            }
        }

        public string Currently_Running
        {
            get { return _currentlyRunning; }
            set
            {
                _currentlyRunning = value;
                OnPropertyChanged();
            }
        }

        public int Step
        {
            get { return _currentNumber; }
            set
            {
                _currentNumber = value;
                OnPropertyChanged();
            }
        }

        public int Out_Of
        {
            get { return _totalNumber; }
            set
            {
                _totalNumber = value;
                OnPropertyChanged();
            }
        }

        public bool Errors_Found
        {
            get { return _errorsFound; }
            set
            {
                _errorsFound = value;
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