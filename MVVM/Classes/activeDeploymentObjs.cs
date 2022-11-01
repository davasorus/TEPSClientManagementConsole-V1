using System.Collections.ObjectModel;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class activeDeploymentObjs
    {
        private static ObservableCollection<activeDeploymentObj> _logs = new ObservableCollection<activeDeploymentObj>();

        public static ObservableCollection<activeDeploymentObj> Collection
        {
            get { return _logs; }
        }
    }
}