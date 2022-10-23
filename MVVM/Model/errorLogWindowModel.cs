using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.Model
{
    public class errorLogWindowModel
    {
        private ObservableCollection<serverErrorObj> _logs = ServerErrorLogs.Collection;

        public ObservableCollection<serverErrorObj> logsCollection
        {
            get { return _logs; }
            set
            {
                _logs = value;
            }
        }
    }
}
