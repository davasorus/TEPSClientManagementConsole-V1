using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class oriObjs
    {
        private static ObservableCollection<oriObj> _logs = new ObservableCollection<oriObj>();

        public static ObservableCollection<oriObj> Collection
        {
            get { return _logs; }
        }
    }
}