﻿using Newtonsoft.Json;
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

        #region update settings Table

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

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB/1";

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

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB/1";

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

                var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/manage/PostUpdateSettingsDB/1";

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

        #endregion update settings Table

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
                loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
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
                loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
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
                //loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");

                var json = await response.Content.ReadAsStringAsync();

                var objects = JsonConvert.DeserializeObject<List<serverErrorObj>>(json);

                foreach (var obj in objects)
                {
                    string date = obj.Date.ToString();

                    var parsedDate = DateTime.Parse(date);

                    DateTime jsonDate = parsedDate.ToLocalTime();

                    this.Dispatcher.Invoke(() => ServerErrorLogs.Collection.Add(new serverErrorObj { ClientName = obj.ClientName, Message = obj.Message, Date = jsonDate }));
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
                loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
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
                loggingClass.logEntryWriter(response.Content.ReadAsStringAsync().Result, "info");
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