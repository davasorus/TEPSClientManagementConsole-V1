using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class prodClientConfigObjs
    {
        private static ObservableCollection<prodClientConfigObj> _logs = new ObservableCollection<prodClientConfigObj>();

        public static ObservableCollection<prodClientConfigObj> Collection
        {
            get { return _logs; }
        }
    }
}