using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.Classes;
using TEPSClientManagementConsole_V1.MVVM.Classes;

namespace TEPSClientManagementConsole_V1.MVVM.View
{
    /// <summary>
    /// Interaction logic for deployment_SingleMachineView.xaml
    /// </summary>
    public partial class deployment_SingleMachineView : UserControl
    {
        private loggingClass loggingClass = new loggingClass();
        private deploymentDistributorClass deploymentDistributorClass = new deploymentDistributorClass();

        public deployment_SingleMachineView()
        {
            InitializeComponent();
            Loaded += Deployment_SingleMachineView_Loaded;
        }

        private void Deployment_SingleMachineView_Loaded(object sender, RoutedEventArgs e)
        {
            loadDropDown();
        }

        private void loadDropDown()
        {
            var message = prodClientConfigObjs.Collection.Count;

            if (message == 0)
            {
                loadDropDown();
            }
            else
            {
                foreach (var name in prodClientConfigObjs.Collection)
                {
                    if (!clientsComBx.Items.Contains(name.ClientName))
                    {
                        this.Dispatcher.Invoke(new Action(() => clientsComBx.Items.Add(name.ClientName)));
                    }
                }
            }
        }

        #region uninstall Steps

        private void uninstallFireClientChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstallFireClient"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstallFireClient");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallFireClient");
            }
        }

        private void uninstallPoliceClientChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstallPoliceClient"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstallPoliceClient");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallPoliceClient");
            }
        }

        private void uninstallMergeClientChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstallMergeClient"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstallMergeClient");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallFireClient");
            }
        }

        private void uninstalNovaPDFChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstalNovaPDF"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstalNovaPDF");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstalNovaPDF");
            }
        }

        private void uninstallGISCompChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstallGISComp"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstallGISComp");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallGISComp");
            }
        }

        private void uninstallSQLCE35ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("uninstallSQLCE35"))
            {
                deploymentDataHolder.enrolledItems.Remove("uninstallSQLCE35");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallSQLCE35");
            }
        }

        private void UninstallUpdaterChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallUpdater"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallUpdater");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallUpdater");
            }
        }

        private void DeleteClientFoldersChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("DeleteClientFolders"))
            {
                deploymentDataHolder.enrolledItems.Remove("DeleteClientFolders");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallFireClient");
            }
        }

        private void RemoveMobileUpdaterEntryChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("RemoveMobileUpdaterEntry"))
            {
                deploymentDataHolder.enrolledItems.Remove("RemoveMobileUpdaterEntry");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("RemoveMobileUpdaterEntry");
            }
        }

        private void UninstallMSPCADChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallMSPCAD"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallMSPCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallMSPCAD");
            }
        }

        private void UninstallSQLCE4ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallSQLCE4"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallSQLCE4");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallSQLCE4");
            }
        }

        private void UninstallScenePDChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallScenePD"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallScenePD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallScenePD");
            }
        }

        private void UninstallCADObserverChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallCADObserver"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallCADObserver");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallCADObserver");
            }
        }

        private void UninstallSQLCLRTypesChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallSQLCLRTypes"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallSQLCLRTypes");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallSQLCLRTypes");
            }
        }

        private void restartMachine1ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("restartMachine1"))
            {
                deploymentDataHolder.enrolledItems.Remove("restartMachine1");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("restartMachine1");
            }
        }

        #endregion uninstall Steps

        #region install steps

        private void installdotNetChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installdotNet"))
            {
                deploymentDataHolder.enrolledItems.Remove("installdotNet");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installdotNet");
            }
        }

        private void installSQLCE35ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installSQLCE35"))
            {
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
            }
        }

        private void installGISComponentsChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installGISComponents"))
            {
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
            }
        }

        private void installDBProvidersChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installDBProviders"))
            {
                deploymentDataHolder.enrolledItems.Remove("installDBProviders");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installDBProviders");
            }
        }

        private void installUpdaterChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installUpdater"))
            {
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installUpdater");
            }
        }

        private void runUpdaterConfigChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("runUpdaterConfig"))
            {
                deploymentDataHolder.enrolledItems.Remove("runUpdaterConfig");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("runUpdaterConfig");
            }
        }

        private void folderPermissions1ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("folderPermissions1"))
            {
                deploymentDataHolder.enrolledItems.Remove("folderPermissions1");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("folderPermissions1");
            }
        }

        private void installMSPCADChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMSPCAD"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMSPCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMSPCAD");
            }
        }

        private void installMobileChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMobile"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMobile");
            }
        }

        private void installCADObserverChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installCADObserver"))
            {
                deploymentDataHolder.enrolledItems.Remove("installCADObserver");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installCADObserver");
            }
        }

        private void installScenePDChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installScenePD"))
            {
                deploymentDataHolder.enrolledItems.Remove("installScenePD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("uninstallFireClient");
            }
        }

        private void installSQLCE4ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installSQLCE4"))
            {
                deploymentDataHolder.enrolledItems.Remove("installSQLCE4");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installSQLCE4");
            }
        }

        private void install2010VSToolChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("install2010VSTool"))
            {
                deploymentDataHolder.enrolledItems.Remove("install2010VSTool");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("install2010VSTool");
            }
        }

        private void installSQLCLRTypeChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installSQLCLRType"))
            {
                deploymentDataHolder.enrolledItems.Remove("installSQLCLRType");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installSQLCLRType");
            }
        }

        private void restartMachine2ChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("restartMachine2"))
            {
                deploymentDataHolder.enrolledItems.Remove("restartMachine2");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("restartMachine2");
            }
        }

        #endregion install steps

        private void clientsComBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deploymentDataHolder.machineName = clientsComBx.SelectedValue.ToString();
        }

        private void environmentComBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            deploymentDataHolder.environmentType = environmentComBx.SelectedValue.ToString();
        }

        private void kickOffClientInstall_Click(object sender, RoutedEventArgs e)
        {
            deploymentDataHolder.totalNumber = deploymentDataHolder.enrolledItems.Count;

            if (!string.IsNullOrEmpty(deploymentDataHolder.machineName))
            {
                if (!string.IsNullOrEmpty(deploymentDataHolder.environmentType))
                {
                    //deploymentDistributorClass
                }
                else
                {
                    loggingClass.queEntrywriter("Deployment Error: Please select an environment");
                }
            }
            else
            {
                loggingClass.queEntrywriter("Deployment ERROR: Please select a client");
            }
        }
    }
}

internal class deploymentDataHolder
{
    public static string machineName { get; set; }
    public static string environmentType { get; set; }

    public static int totalNumber { get; set; }

    public static List<string> enrolledItems { get; set; }
}