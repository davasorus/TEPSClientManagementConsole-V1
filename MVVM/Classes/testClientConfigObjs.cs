using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
