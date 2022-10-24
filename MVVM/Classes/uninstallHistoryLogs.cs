using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class uninstallHistoryLogs
    {
        private static ObservableCollection<uninstallHistoryObj> _logs = new ObservableCollection<uninstallHistoryObj>();

        public static ObservableCollection<uninstallHistoryObj> Collection
        {
            get { return _logs; }
        }
    }
}