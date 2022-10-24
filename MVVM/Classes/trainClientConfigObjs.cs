using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class trainClientConfigObjs
    {
        private static ObservableCollection<trainClientConfigObj> _logs = new ObservableCollection<trainClientConfigObj>();

        public static ObservableCollection<trainClientConfigObj> Collection
        {
            get { return _logs; }
        }
    }
}