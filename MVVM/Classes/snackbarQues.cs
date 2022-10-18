using System.Collections.ObjectModel;

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