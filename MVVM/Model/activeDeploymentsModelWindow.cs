using System.Collections.ObjectModel;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class activeDeploymentsModelWindow
    {
        private ObservableCollection<activeDeploymentObj> _logs = activeDeploymentObjs.Collection;

        public ObservableCollection<activeDeploymentObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}