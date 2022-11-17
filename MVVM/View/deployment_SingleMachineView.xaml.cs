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
            loadClientDropDown();
            loadORIDropDown();
            loadFireDropDown();
        }

        #region functions

        private void loadClientDropDown()
        {
            var message = 0;

            if (prodClientConfigObjs.Collection.Count != null)
            {
                message = prodClientConfigObjs.Collection.Count;
            }

            if (message == 0)
            {
                loadClientDropDown();
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

        private void loadORIDropDown()
        {
            var message = 0;

            if (oriObjs.Collection.Count != null)
            {
                message = oriObjs.Collection.Count;
            }

            if (message == 0)
            {
                loadORIDropDown();
            }
            else
            {
                foreach (var name in oriObjs.Collection)
                {
                    if (!orisComBx.Items.Contains(name.ORI))
                    {
                        this.Dispatcher.Invoke(new Action(() => orisComBx.Items.Add(name.ORI)));
                    }
                }
            }
        }

        private void loadFireDropDown()
        {
            var message = 0;

            if (fdidObjs.Collection.Count != null)
            {
                message = fdidObjs.Collection.Count;
            }

            if (message == 0)
            {
                loadFireDropDown();
            }
            else
            {
                foreach (var name in fdidObjs.Collection)
                {
                    if (!fdidsComBx.Items.Contains(name.FDID))
                    {
                        this.Dispatcher.Invoke(new Action(() => fdidsComBx.Items.Add(name.FDID)));
                    }
                }
            }
        }

        #endregion functions

        #region ui interaction

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
                    this.Dispatcher.Invoke(() => activeDeploymentObjs.Collection.Add(new activeDeploymentObj
                    {
                        client_Name = deploymentDataHolder.machineName,
                        Step = 1,
                        Out_Of = deploymentDataHolder.totalNumber
                    }));
                    deploymentDistributorClass.entrance(deploymentDataHolder.machineName, deploymentDataHolder.environmentType, deploymentDataHolder.totalNumber, deploymentDataHolder.enrolledItems, 1, deploymentDataHolder.selectedORIs, deploymentDataHolder.selectedFDIDs);
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

        private void orisComBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in deploymentDataHolder.selectedORIs)
            {
                if (item.ORI.Contains(orisComBx.SelectedValue.ToString()))
                {
                    deploymentDataHolder.selectedORIs.RemoveAt(item.FieldName[0]);
                }
            }

            deploymentDataHolder.selectedORIs.Add(new oriClass { FieldName = $"ORI{orisComBx.SelectedIndex}", ORI = orisComBx.SelectedValue.ToString() });
        }

        private void fdidsComBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in deploymentDataHolder.selectedFDIDs)
            {
                if (item.FDID.Contains(fdidsComBx.SelectedValue.ToString()))
                {
                    deploymentDataHolder.selectedFDIDs.RemoveAt(item.FieldName[0]);
                }
            }

            deploymentDataHolder.selectedFDIDs.Add(new fdidClass { FieldName = $"FDID{fdidsComBx.SelectedIndex}", FDID = fdidsComBx.SelectedValue.ToString() });
        }

        #endregion ui interaction

        #region uninstall Steps

        //not implemented
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

        //not implemented
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

        private void UninstallMSPChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallMSP"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallMSP");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallMSP");
            }
        }

        private void UninstallCADChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallCAD"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallCAD");
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

        //not implemented
        private void uninstallFireClientChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallFireMobile"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallFireMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallFireMobile");
            }
        }

        private void uninstallPoliceClientChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallLawMobile"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallLawMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallLawMobile");
            }
        }

        //not implemented
        private void uninstallMergeClientChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallMobileMerge"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallMobileMerge");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallMobileMerge");
            }
        }

        private void UninstallMSPhkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallMSP"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallMSP");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallMSP");
            }
        }

        private void UninstallCADChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("UninstallCAD"))
            {
                deploymentDataHolder.enrolledItems.Remove("UninstallCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("UninstallCAD");
            }
        }

        private void UninstallCADObserverChkBx1_Click(object sender, RoutedEventArgs e)
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

        //pre package
        private void installMSPChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMSPPackage"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMSPPackage");

                deploymentDataHolder.enrolledItems.Remove("installdotNet");
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
                deploymentDataHolder.enrolledItems.Remove("installMSP");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMSPPackage");

                deploymentDataHolder.enrolledItems.Add("installdotNet");
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
                deploymentDataHolder.enrolledItems.Add("installUpdater");
                deploymentDataHolder.enrolledItems.Add("installMSP");
            }
        }

        //pre package
        private void installCADChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installCADPackage"))
            {
                deploymentDataHolder.enrolledItems.Remove("installCADPackage");

                deploymentDataHolder.enrolledItems.Remove("installdotNet");
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
                deploymentDataHolder.enrolledItems.Remove("install2010VSTool");
                deploymentDataHolder.enrolledItems.Remove("installSQLCLRType");
                deploymentDataHolder.enrolledItems.Remove("installDBProviders");
                deploymentDataHolder.enrolledItems.Remove("installCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installCADPackage");

                deploymentDataHolder.enrolledItems.Add("installdotNet");
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
                deploymentDataHolder.enrolledItems.Add("installUpdater");
                deploymentDataHolder.enrolledItems.Add("install2010VSTool");
                deploymentDataHolder.enrolledItems.Add("installSQLCLRType");

                deploymentDataHolder.enrolledItems.Add("installCAD");
            }
        }

        private void installLawMobileChkBx_Click(object sender, RoutedEventArgs e)
        {
            //prepackage
            if (deploymentDataHolder.enrolledItems.Contains("installLawMobilePackage"))
            {
                deploymentDataHolder.enrolledItems.Remove("installLawMobilePackage");

                deploymentDataHolder.enrolledItems.Remove("installdotNet");
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
                deploymentDataHolder.enrolledItems.Remove("installDBProviders");
                deploymentDataHolder.enrolledItems.Remove("installLawMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installLawMobilePackage");

                deploymentDataHolder.enrolledItems.Add("installdotNet");
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
                deploymentDataHolder.enrolledItems.Add("installDBProviders");
                deploymentDataHolder.enrolledItems.Add("installUpdater");
                deploymentDataHolder.enrolledItems.Add("installLawMobile");
            }
        }

        private void installFireMobileChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installFireMobilePackage"))
            {
                deploymentDataHolder.enrolledItems.Remove("installFireMobilePackage");

                deploymentDataHolder.enrolledItems.Remove("installdotNet");
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
                deploymentDataHolder.enrolledItems.Remove("installDBProviders");
                deploymentDataHolder.enrolledItems.Remove("installFireMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installFireMobilePackage");

                deploymentDataHolder.enrolledItems.Add("installdotNet");
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
                deploymentDataHolder.enrolledItems.Add("installDBProviders");
                deploymentDataHolder.enrolledItems.Add("installUpdater");
                deploymentDataHolder.enrolledItems.Add("installFireMobile");
            }
        }

        private void installMobileMergeChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMobileMergePackage"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMobileMergePackage");

                deploymentDataHolder.enrolledItems.Remove("installdotNet");
                deploymentDataHolder.enrolledItems.Remove("installSQLCE35");
                deploymentDataHolder.enrolledItems.Remove("installGISComponents");
                deploymentDataHolder.enrolledItems.Remove("installUpdater");
                deploymentDataHolder.enrolledItems.Remove("installDBProviders");
                deploymentDataHolder.enrolledItems.Remove("installMobileMerge");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMobileMergePackage");

                deploymentDataHolder.enrolledItems.Add("installdotNet");
                deploymentDataHolder.enrolledItems.Add("installSQLCE35");
                deploymentDataHolder.enrolledItems.Add("installGISComponents");
                deploymentDataHolder.enrolledItems.Add("installDBProviders");
                deploymentDataHolder.enrolledItems.Add("installUpdater");
                deploymentDataHolder.enrolledItems.Add("installMobileMerge");
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

        private void installMSPChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMSP"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMSP");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMSP");
            }
        }

        private void installCADChkBx_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installCAD"))
            {
                deploymentDataHolder.enrolledItems.Remove("installCAD");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installCAD");
            }
        }

        private void installLawMobileChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installLawMobile"))
            {
                deploymentDataHolder.enrolledItems.Remove("installLawMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installLawMobile");
            }
        }

        private void installFireMobileChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installFireMobile"))
            {
                deploymentDataHolder.enrolledItems.Remove("installFireMobile");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installFireMobile");
            }
        }

        private void installMobileMergeChkBx1_Click(object sender, RoutedEventArgs e)
        {
            if (deploymentDataHolder.enrolledItems.Contains("installMobileMerge"))
            {
                deploymentDataHolder.enrolledItems.Remove("installMobileMerge");
            }
            else
            {
                deploymentDataHolder.enrolledItems.Add("installMobileMerge");
            }
        }

        #endregion install steps
    }
}

public class deploymentDataHolder
{
    public static string machineName { get; set; }
    public static string environmentType { get; set; }

    public static int totalNumber { get; set; }

    public static List<string> enrolledItems = new List<string>();

    public static List<oriClass> selectedORIs = new List<oriClass>();

    public static List<fdidClass> selectedFDIDs = new List<fdidClass>();
}

public class oriClass
{
    public string FieldName { get; set; }
    public string ORI { get; set; }
}

public class fdidClass
{
    public string FieldName { get; set; }
    public string FDID { get; set; }
}