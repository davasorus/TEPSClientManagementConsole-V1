using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
