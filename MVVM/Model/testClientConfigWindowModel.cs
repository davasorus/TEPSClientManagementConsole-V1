using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class testClientConfigWindowModel
    {
        private ObservableCollection<testClientConfigObj> _logs = testClientConfigObjs.Collection;

        public ObservableCollection<testClientConfigObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}