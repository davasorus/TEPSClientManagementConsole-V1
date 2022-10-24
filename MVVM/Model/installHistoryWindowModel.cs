using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class installHistoryWindowModel
    {
        private ObservableCollection<installHistoryObj> _logs = installHistoryLogs.Collection;

        public ObservableCollection<installHistoryObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}