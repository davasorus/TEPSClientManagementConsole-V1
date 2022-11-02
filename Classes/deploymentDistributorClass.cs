using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.Classes;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1.Classes
{
    public class deploymentDistributorClass : UserControl
    {
        private loggingClass loggingClass = new loggingClass();
        private masterPushInstallEndPointInteraction masterPushInstallEndPointInteraction = new masterPushInstallEndPointInteraction();

        public async void entrance(string machineName, string envronmentType, int totalNumber, List<string> enrolledItems, int i)
        {
            await uninstallSteps(machineName, envronmentType, totalNumber, enrolledItems, i);

            await installSteps(machineName, envronmentType, totalNumber, enrolledItems, i);

            await removeProcess(machineName);
        }

        #region functions

        public async Task removeProcess(string machineName)
        {
            try
            {
                var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                int index = activeDeploymentObjs.Collection.IndexOf(client);

                this.Dispatcher.Invoke(() => activeDeploymentObjs.Collection.RemoveAt(index));
            }
            catch (Exception ex)
            {
                loggingClass.logEntryWriter(ex.ToString(), "error");
            }
        }

        #endregion functions

        #region distribution logic and parameter building

        public async Task uninstallSteps(string machineName, string envronmentType, int totalNumber, List<string> enrolledItems, int i)
        {
        }

        public async Task installSteps(string machineName, string envronmentType, int totalNumber, List<string> enrolledItems, int i)
        {
            int j = i;
            if (enrolledItems.Contains("installdotNet"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "Dot Net Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installDotNet(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed DotNet successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install DotNet");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installSQLCE35"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "SQL Compact 3.5 Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await install35SQLCompact(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed SQL Compact 3.5 successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install SQL Compact 3.5");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installGISComponents"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "GIS Components Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installGISComponents(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed GIS Components successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install GIS Components");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installDBProviders"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "DB Provider Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installDBProviders(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed DB Provider successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install DB Provider");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installUpdater"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "Enterprise Updater Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installUpdater(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed Enterprise Updater successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install Enterprise Updater");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installScenePD"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "ScenePD Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installScenePD(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed ScenePD successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install ScenePD");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installSQLCE4"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "SQL Compact 4.0 Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await install40SqlCompact(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed SQL Compact 4.0 successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install SQL Compact 4.0");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("install2010VSTool"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "Visual Studio 2010 Tools Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await install2010VSTools(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed Visual Studio 2010 Tools successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install Visual Studio 2010 Tools");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installSQLCLRType"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "SQL CLR 2008 Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installSQLCLR08Types(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed SQL CLR 2008 successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install SQL CLR 2008");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }

                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "SQL CLR 2012 Install");

                    var response = await installSQLCLR12Types(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed SQL CLR 2012 successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install SQL CLR 2012");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }

            if (enrolledItems.Contains("installMSP"))
            {
                try
                {
                    var client = activeDeploymentObjs.Collection.FirstOrDefault(o => o.client_Name == machineName);

                    this.Dispatcher.Invoke(() => client.Currently_Running = "MSP Client Install");

                    this.Dispatcher.Invoke(() => client.Step = j++);

                    var response = await installMSP(machineName, envronmentType);

                    if (response.Equals(true))
                    {
                        loggingClass.queEntrywriter($"{machineName} installed MSP Client successfully");
                    }
                    else
                    {
                        client.Errors_Found = true;

                        loggingClass.queEntrywriter($"{machineName} failed to install MSP Client");
                    }
                }
                catch (Exception ex)
                {
                    loggingClass.logEntryWriter(ex.ToString(), "error");
                }
            }
            if (enrolledItems.Contains("installCAD"))
            {
            }
            if (enrolledItems.Contains("installLawMobile"))
            {
            }
            if (enrolledItems.Contains("installFireMobile"))
            {
            }
            if (enrolledItems.Contains("installMobileMerge"))
            {
            }
            if (enrolledItems.Contains("installCADObserver"))
            {
            }
        }

        #endregion distribution logic and parameter building

        #region install code

        public async Task<bool> installDotNet(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallDotNet(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> install35SQLCompact(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installGISComponents(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallGIS(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installDBProviders(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallDBProviders(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installUpdater(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallUpdater(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installScenePD(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallScenePD(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> install40SqlCompact(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.PostInstallSQLCE40(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> install2010VSTools(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallVS2010(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installSQLCLR08Types(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCLR2008(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installSQLCLR12Types(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCLR2012(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installMSP(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallMSP(machineName,(int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installCAD(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installLawMobile(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installFireMobile(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installMobileMerge(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        public async Task<bool> installCADObserver(string machineName, string envronmentType)
        {
            bool response = false;
            var ID = 0;
            var essName = "";
            var mspName = "";
            var cadName = "";
            var gisServerName = "";
            var gisInstanceName = "";
            var mobileName = "";
            var instance = 0;
            List<string> policeList = new List<string>();
            List<string> fireList = new List<string>();

            if (envronmentType.Contains("Prod"))
            {
                instance = 2;
            }
            if (envronmentType.Contains("test"))
            {
                instance = 3;
            }
            if (envronmentType.Contains("Train"))
            {
                instance = 4;
            }

            if (instance == 2)
            {
                var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);

                ID = (int)(client?.ID);
                essName = configurationViewModel._prodEssServerName;
                mspName = configurationViewModel._prodAppServerName;
                cadName = configurationViewModel._prodCadServerName;
                gisServerName = configurationViewModel._prodGisServerName;
                gisInstanceName = configurationViewModel._prodGisInstanceName;
                mobileName = configurationViewModel._prodMobileServerName;
                //policeList
                //fireList
            }
            if (instance == 3)
            {
                var client = testClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }
            if (instance == 4)
            {
                var client = trainClientConfigObjs.Collection.FirstOrDefault(o => o.ClientName == machineName);
                //ID = client?.ID;
            }

            var reply = await masterPushInstallEndPointInteraction.postInstallSQLCE35(machineName, (int)ID, essName, mspName, cadName, gisServerName, gisInstanceName, mobileName, instance, policeList, fireList);

            if (reply.Contains("true"))
            {
                response = true;
            }
            else
            {
                response = false;
            }

            return response;
        }

        #endregion install code
    }
}