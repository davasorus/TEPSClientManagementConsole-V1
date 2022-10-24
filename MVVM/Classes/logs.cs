using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class logs
    {
        private static ObservableCollection<loggingObj> _logs = new ObservableCollection<loggingObj>();

        public static ObservableCollection<loggingObj> Collection
        {
            get { return _logs; }
        }
    }
}