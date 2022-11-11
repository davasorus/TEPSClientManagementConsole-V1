using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class fdidObj : INotifyPropertyChanged
    {
        private string _fdid { get; set; }
        private int _enrolledInstanceType_ID { get; set; }

        public string FDID
        {
            get { return _fdid; }
            set
            {
                _fdid = value;
                OnPropertyChanged();
            }
        }

        public int EnrolledInstanceType_ID
        {
            get { return _enrolledInstanceType_ID; }
            set
            {
                _enrolledInstanceType_ID = value;
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