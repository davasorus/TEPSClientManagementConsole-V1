using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class testClientConfigObjs
    {
        private static ObservableCollection<testClientConfigObj> _logs = new ObservableCollection<testClientConfigObj>();

        public static ObservableCollection<testClientConfigObj> Collection
        {
            get { return _logs; }
        }
    }
}