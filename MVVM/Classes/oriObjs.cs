using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
