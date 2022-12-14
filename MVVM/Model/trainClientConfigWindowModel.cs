using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class trainClientConfigWindowModel
    {
        private ObservableCollection<trainClientConfigObj> _logs = trainClientConfigObjs.Collection;

        public ObservableCollection<trainClientConfigObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}