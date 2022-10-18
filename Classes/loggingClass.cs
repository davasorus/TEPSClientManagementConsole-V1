﻿using NLog;
using NLog.Config;
using NLog.Targets;
using System.Collections.Generic;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.Classes
{
    internal class loggingClass : UserControl
    {
        public Queue<string> que = new Queue<string>();

        private readonly string logFileName = "TEPSManagementConsoleLog.json";

        private static Logger _logger;

        //adds log messages to log collection (which is then seen via the internal log viewer view
        public void logEntryWriter(string logMessage, string level)
        {
            //this.Dispatcher.Invoke(() => logs.Collection.Add(new loggingObj { Message = logMessage, Date = DateTime.Now }));

            nLogLogger(logMessage, level);
        }

        //adds messages to unified snackbar
        public void queEntrywriter(string message)
        {
            this.Dispatcher.Invoke(() => snackbarQues.Collection.Add(new snackBarQueObj { Message = message }));
        }

        public void initializeNLogLogger()
        {
            var config = new LoggingConfiguration();

            var target =
                new FileTarget
                {
                    FileName = logFileName
                };

            config.AddTarget("logfile", target);

            var rule = new LoggingRule("*", LogLevel.Debug, target);

            config.LoggingRules.Add(rule);

            LogManager.Configuration = config;
        }

        //more performant logging for moving files
        public void nLogLogger(string message, string level)
        {
            _logger = LogManager.GetLogger(level);

            switch (level)
            {
                case "info":
                    _logger.Info(message);
                    break;

                case "debug":
                    _logger.Debug(message);
                    break;

                case "error":
                    _logger.Error(message);
                    break;

                default:
                    break;
            }
        }
    }
}