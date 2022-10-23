using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
