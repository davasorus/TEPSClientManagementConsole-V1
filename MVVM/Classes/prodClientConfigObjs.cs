using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
