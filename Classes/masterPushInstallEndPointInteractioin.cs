﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TEPSClientManagementConsole_V1.MVVM.ViewModel;

namespace TEPSClientManagementConsole_V1.Classes
{
    internal class masterPushInstallEndPointInteraction : UserControl
    {
        private loggingClass loggingClass = new loggingClass();

        #region pre req installs

        public async Task<string> postInstallDotNet(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallDotNet/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed DotNet successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallSQLCE35(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallSQLCE35/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed SQL Compact 3.5 successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallGIS(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallGIS/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed GIS Components successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallDBProviders(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallDBProviders/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed DBProviders successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallUpdater(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallUpdater/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed Enterprise Updater successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallScenePD(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallScenePD/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed ScenePD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> PostInstallSQLCE40(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallSQLCE40/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed SQL Compact 4.0 successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallVS2010(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallVS2010/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed Visual Studio Tool 2010 successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallSQLCLR2008(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallSQLCLR2008/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed SQL CLR Types 2008 successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallSQLCLR2012(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallSQLCLR2012/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed SQL CLR Types 2012 successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        #endregion pre req installs

        #region client installs

        public async Task<string> postInstallMSP(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallMSP/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed MSP successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallCAD(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallCAD/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed CAD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postInstallIncidentObserver(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostInstallIncidentObserver/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed CAD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postLawMobile(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<oriClass> policeList)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostLawMobile/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance,
                PoliceList = policeList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed CAD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postFireMobile(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<fdidClass> fireList)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostFireMobile/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed CAD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        public async Task<string> postMobileMerge(string machineName, int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<oriClass> policeList)
        {
            string result = "";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }

            var endPoint = $"http://{configurationViewModel._prodMasterServiceServer}:8081/Push/PostMobileMerge/{ID}";

            apiObj Obj = new apiObj()
            {
                ESSServer = essServer,
                MSPServer = mspServer,
                CADServer = cadServer,
                GISServer = gisServer,
                GISInstance = gisInstance,
                MobileServer = mobileServer,
                Instance = instance,
                PoliceList = policeList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                loggingClass.logEntryWriter($"{machineName} installed CAD successfully", "info");

                result = "true";
            }
            else
            {
                string logEntry1 = $" Failed to call the Web Api: {response.StatusCode}";

                loggingClass.logEntryWriter(logEntry1, "error");

                string content = await response.Content.ReadAsStringAsync();
                string logEntry2 = $" Content: {content}";

                loggingClass.logEntryWriter(logEntry2, "error");

                result = "false";
            }

            return result;
        }

        #endregion client installs
    }
}

internal class apiObj
{
    public string ESSServer { get; set; }

    public string MSPServer { get; set; }

    public string CADServer { get; set; }

    public string GISServer { get; set; }

    public string GISInstance { get; set; }

    public string MobileServer { get; set; }

    public int Instance { get; set; }

    public List<oriClass> PoliceList = new List<oriClass>();

    public List<fdidClass> FireList = new List<fdidClass>();
}