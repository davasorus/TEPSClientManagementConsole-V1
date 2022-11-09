using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public class oriObj : INotifyPropertyChanged
    {
        private string _ori { get; set; }
        private int _enrolledInstanceType_ID { get; set; }

        public string ORI
        {
            get { return _ori; }
            set
            {
                _ori = value;
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
