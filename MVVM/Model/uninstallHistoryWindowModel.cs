using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class uninstallHistoryWindowModel
    {
        private ObservableCollection<uninstallHistoryObj> _logs = uninstallHistoryLogs.Collection;

        public ObservableCollection<uninstallHistoryObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}