using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class installHistoryLogs
    {
        private static ObservableCollection<installHistoryObj> _logs = new ObservableCollection<installHistoryObj>();

        public static ObservableCollection<installHistoryObj> Collection
        {
            get { return _logs; }
        }
    }
}