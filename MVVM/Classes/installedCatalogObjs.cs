using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class installedCatalogObjs
    {
        private static ObservableCollection<installedCatalogObj> _logs = new ObservableCollection<installedCatalogObj>();

        public static ObservableCollection<installedCatalogObj> Collection
        {
            get { return _logs; }
        }
    }
}
