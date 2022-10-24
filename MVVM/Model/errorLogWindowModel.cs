using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class errorLogWindowModel
    {
        private ObservableCollection<serverErrorObj> _logs = ServerErrorLogs.Collection;

        public ObservableCollection<serverErrorObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}