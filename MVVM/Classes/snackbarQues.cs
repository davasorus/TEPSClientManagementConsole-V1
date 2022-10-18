using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class snackbarQues
    {
        private static ObservableCollection<snackBarQueObj> _snackbarQues = new ObservableCollection<snackBarQueObj>();

        public static ObservableCollection<snackBarQueObj> Collection
        {
            get { return _snackbarQues; }
        }
    }
}
