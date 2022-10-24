using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class ServerErrorLogs
    {
        private static ObservableCollection<serverErrorObj> _logs = new ObservableCollection<serverErrorObj>();

        public static ObservableCollection<serverErrorObj> Collection
        {
            get { return _logs; }
        }
    }
}