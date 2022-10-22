using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class logWindowModel
    {
        private ObservableCollection<loggingObj> _logs = logs.Collection;

        public ObservableCollection<loggingObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}