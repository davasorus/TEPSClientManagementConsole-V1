﻿using TEPSClientManagementConsole_V1.Core;

namespace TEPSClientManagementConsole_V1.MVVM.ViewModel
{
    internal class mainViewModel : observableObject
    {
        public relayCommand dashboardViewCommand { get; set; }

        public relayCommand configurationViewCommand { get; set; }

        public dashboardViewModel dashboardVM { get; set; }

        public configurationViewModel configurationVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public mainViewModel()
        {
            dashboardVM = new dashboardViewModel();
            configurationVM = new configurationViewModel();

            CurrentView = dashboardVM;

            dashboardViewCommand = new relayCommand(o =>
            {
                CurrentView = dashboardVM;
            });

            configurationViewCommand = new relayCommand(o =>
            {
                CurrentView = configurationVM;
            });
        }
    }
}