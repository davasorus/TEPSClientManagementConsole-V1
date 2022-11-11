using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class fdidObjs
    {
        private static ObservableCollection<fdidObj> _logs = new ObservableCollection<fdidObj>();

        public static ObservableCollection<fdidObj> Collection
        {
            get { return _logs; }
        }
    }
}