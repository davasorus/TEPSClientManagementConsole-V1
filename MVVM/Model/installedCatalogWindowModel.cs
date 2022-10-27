using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class installedCatalogWindowModel
    {
        private ObservableCollection<installedCatalogObj> _logs = installedCatalogObjs.Collection;

        public ObservableCollection<installedCatalogObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}