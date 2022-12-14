using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.Classes;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1.Classes
{
    internal class masterMangeEndPointInteractionClass : UserControl
    {
        private loggingClass loggingClass = new loggingClass();

        #region update DB values

        public async Task PostUpdateSettingProd()
        {
            try
            {
                var httpClient = new HttpClient();
                var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

                if (defaultRequestHeaders.Accept == null ||
                   !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new
                      MediaTypeWithQualityHeaderValue("application/json"));
                }

                settingsDBObj obj = new settingsDBObj()
                {
                    MobileServer = configurationViewModel._prodMobileServerName,
                    ESSServer = configurationViewModel._prodEssServerName,
                    RecordsServer = configurationViewModel._prodAppServerName,
                    CADServer = configurationViewModel._prodCadServerName,
                    GISServer = configurationViewModel._prodGisServerName,
                    GISInstance = configurationViewModel._prodGisInstanceName,
                    Instance = "2",
                    ClientInstallationPath = configurationViewModel._prodClientInstallServerName
                };

                var package = JsonConvert.SerializeObject(obj);

                var stringcontent = new StringContent(package, Encoding.UTF8, "application/json");

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB";

                HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringcontent);

                if (response.IsSuccessStatusCode)
                {
                    loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
                    loggingClass.queEntrywriter("DB Updated");
                }
                else
                {
                    string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                    loggingClass.logEntryWriter(logEntry1, "error");

                    string content = await response.Content.ReadAsStringAsync();
                    string logEntry2 = $" Content: {content}";

                    loggingClass.logEntryWriter(logEntry2, "error");
                }
            }
            catch (Exception ex)
            {
                loggingClass.queEntrywriter("There was an error updating settings DB");

                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                throw ex;
            }
        }

        //Not Implemented
        public async Task PostUpdateSettingTest()
        {
            try
            {
                var httpClient = new HttpClient();
                var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

                if (defaultRequestHeaders.Accept == null ||
                   !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new
                      MediaTypeWithQualityHeaderValue("application/json"));
                }

                settingsDBObj obj = new settingsDBObj()
                {
                    MobileServer = configurationViewModel._prodMobileServerName,
                    ESSServer = configurationViewModel._prodEssServerName,
                    RecordsServer = configurationViewModel._prodAppServerName,
                    CADServer = configurationViewModel._prodCadServerName,
                    GISServer = configurationViewModel._prodGisServerName,
                    GISInstance = configurationViewModel._prodGisInstanceName,
                    Instance = "3",
                    ClientInstallationPath = configurationViewModel._prodClientInstallServerName
                };

                var package = JsonConvert.SerializeObject(obj);

                var stringcontent = new StringContent(package, Encoding.UTF8, "application/json");

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB";

                HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringcontent);

                if (response.IsSuccessStatusCode)
                {
                    loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
                    loggingClass.queEntrywriter("DB Updated");
                }
                else
                {
                    string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                    loggingClass.logEntryWriter(logEntry1, "error");

                    string content = await response.Content.ReadAsStringAsync();
                    string logEntry2 = $" Content: {content}";

                    loggingClass.logEntryWriter(logEntry2, "error");
                }
            }
            catch (Exception ex)
            {
                loggingClass.queEntrywriter("There was an error updating settings DB");

                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                throw ex;
            }
        }

        //Not Implemented
        public async Task PostUpdateSettingTrain()
        {
            try
            {
                var httpClient = new HttpClient();
                var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

                if (defaultRequestHeaders.Accept == null ||
                   !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new
                      MediaTypeWithQualityHeaderValue("application/json"));
                }

                settingsDBObj obj = new settingsDBObj()
                {
                    MobileServer = configurationViewModel._prodMobileServerName,
                    ESSServer = configurationViewModel._prodEssServerName,
                    RecordsServer = configurationViewModel._prodAppServerName,
                    CADServer = configurationViewModel._prodCadServerName,
                    GISServer = configurationViewModel._prodGisServerName,
                    GISInstance = configurationViewModel._prodGisInstanceName,
                    Instance = "4",
                    ClientInstallationPath = configurationViewModel._prodClientInstallServerName
                };

                var package = JsonConvert.SerializeObject(obj);

                var stringcontent = new StringContent(package, Encoding.UTF8, "application/json");

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB";

                HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringcontent);

                if (response.IsSuccessStatusCode)
                {
                    loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
                    loggingClass.queEntrywriter("DB Updated");
                }
                else
                {
                    string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                    loggingClass.logEntryWriter(logEntry1, "error");

                    string content = await response.Content.ReadAsStringAsync();
                    string logEntry2 = $" Content: {content}";

                    loggingClass.logEntryWriter(logEntry2, "error");
                }
            }
            catch (Exception ex)
            {
                loggingClass.queEntrywriter("There was an error updating settings DB");

                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                throw ex;
            }
        }

        #endregion update DB values

        public async Task GetAllClients()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetAllClients";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (prodClientConfigObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => prodClientConfigObjs.Collection.Clear()));
                }

                if (testClientConfigObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => testClientConfigObjs.Collection.Clear()));
                }

                if (prodClientConfigObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => trainClientConfigObjs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<clientConfigObj>>(json);

                foreach (var obj in objects)
                {
                    try
                    {
                        string lastHeathTime = "";
                        string InstalledCatalog_ID = "";
                        string DateTimeModified = "";

                        try
                        {
                            if (obj.MostRecentHealthCheckDate_Time != null)
                            {
                                lastHeathTime = obj.MostRecentHealthCheckDate_Time.ToString();
                            }

                            if (obj.InstalledCatalog_ID != null)
                            {
                                InstalledCatalog_ID = obj.InstalledCatalog_ID.ToString();
                            }

                            if (obj.Date_TimeModified != null)
                            {
                                DateTimeModified = obj.Date_TimeModified.ToString();
                            }
                        }
                        catch (Exception ex)
                        {
                        }

                        if (obj.EnrolledInstanceType_ID.Equals(2))
                        {
                            this.Dispatcher.Invoke(() => prodClientConfigObjs.Collection.Add(new prodClientConfigObj
                            {
                                ID = obj.Id,
                                ClientName = obj.ClientName,
                                PassedHeathCheck = obj.PassedHealthCheck,
                                LastHeathCheckDate_Time = lastHeathTime,
                                InstalledCatalog_ID = InstalledCatalog_ID,
                                EnrolledInstanceType_ID = "Prod",
                                Date_TimeModified = DateTimeModified
                            }));
                        }
                        else if (obj.EnrolledInstanceType_ID.Equals(3))
                        {
                            this.Dispatcher.Invoke(() => testClientConfigObjs.Collection.Add(new testClientConfigObj
                            {
                                ClientName = obj.ClientName,
                                PassedHeathCheck = obj.PassedHealthCheck,
                                LastHeathCheckDate_Time = lastHeathTime,
                                InstalledCatalog_ID = InstalledCatalog_ID,
                                EnrolledInstanceType_ID = "Test",
                                Date_TimeModified = DateTimeModified
                            }));
                        }
                        else if (obj.EnrolledInstanceType_ID.Equals(4))
                        {
                            this.Dispatcher.Invoke(() => trainClientConfigObjs.Collection.Add(new trainClientConfigObj
                            {
                                ClientName = obj.ClientName,
                                PassedHeathCheck = obj.PassedHealthCheck,
                                LastHeathCheckDate_Time = lastHeathTime,
                                InstalledCatalog_ID = InstalledCatalog_ID,
                                EnrolledInstanceType_ID = "Train",
                                Date_TimeModified = DateTimeModified
                            }));
                        }
                    }
                    catch (Exception ex)
                    {
                        loggingClass.logEntryWriter(ex.ToString(), "error");
                    }
                }

                if (prodClientConfigObjs.Collection.Count > 1)
                {
                    loggingClass.logEntryWriter("Prod Client Data Received", "info");
                    loggingClass.queEntrywriter("Prod Client Data Received");
                }

                if (testClientConfigObjs.Collection.Count > 1)
                {
                    //loggingClass.logEntryWriter("Test Client Data Received", "info");
                    //loggingClass.queEntrywriter("Test Client Data Received");
                }

                if (prodClientConfigObjs.Collection.Count > 1)
                {
                    //loggingClass.logEntryWriter("Train Client Data Received", "info");
                    //loggingClass.queEntrywriter("Train Client Data Received");
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetAllCatalogs()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetAllInstalledCatalogs";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (installedCatalogObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => installedCatalogObjs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                try
                {
                    var objects = JsonConvert.DeserializeObject<List<installCatalogObj>>(json);

                    foreach (var obj in objects)
                    {
                        var client = prodClientConfigObjs.Collection.FirstOrDefault(o => o.ID == obj.Id);

                        if (client != null)
                        {
                            string machineName = client.ClientName;

                            string DateTimeModified = "";

                            if (obj.ModifiedDate_time != null)
                            {
                                DateTimeModified = obj.ModifiedDate_time.ToString();
                            }

                            this.Dispatcher.Invoke(() => installedCatalogObjs.Collection.Add(new installedCatalogObj
                            {
                                ClientName = machineName,
                                SQLCompact3532_Installed = obj.SQLCompact3532_Installed,
                                SQLCompact3564_Installed = obj.SQLCompact3564_Installed,
                                SQLCompact0464_Installed = obj.SQLCompact0464_Installed,
                                SQLCLR200832_Installed = obj.SQLCLR200832_Installed,
                                SQLCLR200864_Installed = obj.SQLCLR200864_Installed,
                                SQLCLR201232_Installed = obj.SQLCLR201232_Installed,
                                SQLCLR201264_Installed = obj.SQLCLR201264_Installed,
                                ScenePD_Installed = obj.ScenePD_Installed,
                                Updater_Installed = obj.Updater_Installed,
                                GisComponents32_Installed = obj.GISComponents32_Installed,
                                GisComponents64_Installed = obj.GISComponents64_Installed,
                                DotNet_Installed = obj.DotNet_Installed,
                                DBProvider_Installed = obj.DBProvider_Installed,
                                LERMS_Installed = obj.LERMS_Installed,
                                CAD_Installed = obj.CAD_Installed,
                                CADObserver_Installed = obj.CADObserver_Installed,
                                FireMobile_Installed = obj.FireMobile_Installed,
                                LEMobile_Installed = obj.LEMobile_Installed,
                                MobileMerge_Installed = obj.MobileMerge_Installed,
                                MobileAgencyConfiguration = obj.MobileAgencyConfiguration,
                                ModifiedDate_time = DateTimeModified
                            }));
                        }
                    }

                    if (installedCatalogObjs.Collection.Count > 1)
                    {
                        loggingClass.logEntryWriter("Installed Catalog Data Received", "info");
                        loggingClass.queEntrywriter("Installed Catalog Data Received");
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetTop1000Errors()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/Get1000Errors";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (ServerErrorLogs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => ServerErrorLogs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<serverErrorObj>>(json);

                foreach (var obj in objects)
                {
                    this.Dispatcher.Invoke(() => ServerErrorLogs.Collection.Add(new serverErrorObj { ClientName = obj.ClientName, ErrorMessage = obj.ErrorMessage, ErrorDate_Time = obj.ErrorDate_Time }));
                }

                if (ServerErrorLogs.Collection.Count > 1)
                {
                    loggingClass.logEntryWriter("Server Error Data Received", "info");
                    loggingClass.queEntrywriter("Server Error Data Received");
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetInstallLogs()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetAllInstallLogs";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (installHistoryLogs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => installHistoryLogs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<installLogObj>>(json);

                try
                {
                    foreach (var obj in objects)
                    {
                        if (obj.EnrolledInstanceType.Equals(2))
                        {
                            this.Dispatcher.Invoke(() => installHistoryLogs.Collection.Add(new installHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Prod", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                        else if (obj.EnrolledInstanceType.Equals(3))
                        {
                            this.Dispatcher.Invoke(() => installHistoryLogs.Collection.Add(new installHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Test", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                        else if (obj.EnrolledInstanceType.Equals(4))
                        {
                            this.Dispatcher.Invoke(() => installHistoryLogs.Collection.Add(new installHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Train", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                    }

                    if (installHistoryLogs.Collection.Count > 1)
                    {
                        loggingClass.logEntryWriter("Prod Install History Data Received", "info");
                        loggingClass.queEntrywriter("Prod Install History Data Received");
                    }

                    if (installHistoryLogs.Collection.Count > 1)
                    {
                        //loggingClass.logEntryWriter("Test Install History Data Received", "info");
                        //loggingClass.queEntrywriter("Test Install History Data Received");
                    }

                    if (installHistoryLogs.Collection.Count > 1)
                    {
                        //loggingClass.logEntryWriter("Train Install History Data Received", "info");
                        //loggingClass.queEntrywriter("Train Install History Data Received");
                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetuninstallLogs()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetAllUnInstallLogs";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (uninstallHistoryLogs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => uninstallHistoryLogs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<uninstallLogObj>>(json);

                try
                {
                    foreach (var obj in objects)
                    {
                        if (obj.EnrolledInstanceType.Equals(2))
                        {
                            this.Dispatcher.Invoke(() => uninstallHistoryLogs.Collection.Add(new uninstallHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Prod", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                        else if (obj.EnrolledInstanceType.Equals(3))
                        {
                            this.Dispatcher.Invoke(() => uninstallHistoryLogs.Collection.Add(new uninstallHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Test", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                        else if (obj.EnrolledInstanceType.Equals(4))
                        {
                            this.Dispatcher.Invoke(() => uninstallHistoryLogs.Collection.Add(new uninstallHistoryObj { ClientName = obj.ClientName, EnrolledInstanceType = "Train", ErrorMessage = obj.Action, TransactionDate_Time = obj.TransactionDate_Time }));
                        }
                    }

                    if (uninstallHistoryLogs.Collection.Count > 1)
                    {
                        loggingClass.logEntryWriter("Prod UnInstall History Data Received", "info");
                        loggingClass.queEntrywriter("Prod UnInstall History Data Received");
                    }

                    if (uninstallHistoryLogs.Collection.Count > 1)
                    {
                        //loggingClass.logEntryWriter("Test UnInstall History Data Received", "info");
                        //loggingClass.queEntrywriter("Test UnInstall History Data Received");
                    }

                    if (uninstallHistoryLogs.Collection.Count > 1)
                    {
                        //loggingClass.logEntryWriter("Train UnInstall History Data Received", "info");
                        //loggingClass.queEntrywriter("Train UnInstall History Data Received");
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetORIs()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetORIs";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (oriObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => oriObjs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<oriObj>>(json);

                try
                {
                    foreach (var obj in objects)
                    {
                        this.Dispatcher.Invoke(() => oriObjs.Collection.Add(new oriObj { ORI = obj.ORI, EnrolledInstanceType_ID = obj.EnrolledInstanceType_ID }));
                    }

                    if (oriObjs.Collection.Count > 1)
                    {
                        loggingClass.logEntryWriter("ORI Data Received", "info");
                        loggingClass.queEntrywriter("ORI Data Received");
                    }
                }
                catch (Exception ex)
                {
                   
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }

        public async Task GetFDIDs()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/GetFDIDs";

            HttpResponseMessage response = await httpClient.GetAsync(endPoint);

            if (response.IsSuccessStatusCode)
            {
                if (fdidObjs.Collection.Count > 1)
                {
                    this.Dispatcher.Invoke(new Action(() => uninstallHistoryLogs.Collection.Clear()));
                }

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<fdidObj>>(json);

                try
                {
                    foreach (var obj in objects)
                    {
                        this.Dispatcher.Invoke(() => fdidObjs.Collection.Add(new fdidObj { FDID = obj.FDID, EnrolledInstanceType_ID = obj.EnrolledInstanceType_ID }));
                    }

                    if (fdidObjs.Collection.Count > 1)
                    {
                        loggingClass.logEntryWriter("FDID Data Received", "info");
                        loggingClass.queEntrywriter("FDID Data Received");
                    }
                }
                catch (Exception ex)
                {
                    
                }
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");
            }
        }
    }
}

internal class settingsDBObj
{
    public string MobileServer { get; set; }
    public string ESSServer { get; set; }
    public string RecordsServer { get; set; }
    public string CADServer { get; set; }
    public string GISServer { get; set; }
    public string GISInstance { get; set; }
    public string Instance { get; set; }
    public string ClientInstallationPath { get; set; }
}

internal class trelloConfigObj
{
    public string TrelloKey { get; set; }
    public string TrelloToken { get; set; }
    public string TrelloError { get; set; }
}

internal class installLogObj
{
    public string ClientName { get; set; }
    public int EnrolledInstanceType { get; set; }
    public string Action { get; set; }
    public DateTime TransactionDate_Time { get; set; }
}

internal class uninstallLogObj
{
    public string ClientName { get; set; }
    public int EnrolledInstanceType { get; set; }
    public string Action { get; set; }
    public DateTime TransactionDate_Time { get; set; }
}

internal class clientConfigObj
{
    public int Id { get; set; }
    public string ClientName { get; set; }
    public bool PassedHealthCheck { get; set; }
    public object MostRecentHealthCheckDate_Time { get; set; }
    public object InstalledCatalog_ID { get; set; }
    public object MostRecentInstallDate_Time { get; set; }
    public int EnrolledInstanceType_ID { get; set; }
    public DateTime InitialCreationDate_Time { get; set; }
    public DateTime? Date_TimeModified { get; set; }
}

internal class installCatalogObj
{
    public int Id { get; set; }
    public int Client_ID { get; set; }
    public bool SQLCompact3532_Installed { get; set; }
    public bool SQLCompact3564_Installed { get; set; }
    public bool SQLCompact0464_Installed { get; set; }
    public bool SQLCLR200832_Installed { get; set; }
    public bool SQLCLR200864_Installed { get; set; }
    public bool ScenePD_Installed { get; set; }
    public bool Updater_Installed { get; set; }
    public bool GISComponents32_Installed { get; set; }
    public bool GISComponents64_Installed { get; set; }
    public bool DotNet_Installed { get; set; }
    public bool SQLCLR201232_Installed { get; set; }
    public bool SQLCLR201264_Installed { get; set; }
    public bool DBProvider_Installed { get; set; }
    public bool LERMS_Installed { get; set; }
    public bool CAD_Installed { get; set; }
    public bool CADObserver_Installed { get; set; }
    public bool FireMobile_Installed { get; set; }
    public bool LEMobile_Installed { get; set; }
    public bool MobileMerge_Installed { get; set; }
    public string? MobileAgencyConfiguration { get; set; }
    public DateTime? InitialInstallDate_Time { get; set; }
    public DateTime? ModifiedDate_time { get; set; }
}