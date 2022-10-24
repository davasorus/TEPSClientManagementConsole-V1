using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class prodClientConfigWindowModel
    {
        private ObservableCollection<prodClientConfigObj> _logs = prodClientConfigObjs.Collection;

        public ObservableCollection<prodClientConfigObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}
