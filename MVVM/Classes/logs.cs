﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEPSClientManagementConsole_V1.MVVM.Classes
{
    public static class logs
    {
        private static ObservableCollection<loggingObj> _logs = new ObservableCollection<loggingObj>();

        public static ObservableCollection<loggingObj> Collection
        {
            get { return _logs; }
        }
    }
}
