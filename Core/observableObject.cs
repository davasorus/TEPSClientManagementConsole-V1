using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TEPSClientManagementConsole_V1.Core
{
    //object that is piped to the UI that displays changes made without special UI-object linking code
    internal class observableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}