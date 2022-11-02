using Newtonsoft.Json;
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

        public async Task<string> postInstallDotNet(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallSQLCE35(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallGIS(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallDBProviders(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallUpdater(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallScenePD(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> PostInstallSQLCE40(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallVS2010(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallSQLCLR2008(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

        public async Task<string> postInstallSQLCLR2012(int ID, string essServer, string mspServer, string cadServer, string gisServer, string gisInstance, string mobileServer, int instance, List<string> policeList, List<string> fireList)
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
                Instance = instance,
                PoliceList = policeList,
                FireList = fireList
            };

            var package = JsonConvert.SerializeObject(Obj);

            var stringContent = new StringContent(package, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endPoint, stringContent);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();

                loggingClass.logEntryWriter(json, "info");

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

    public List<string> PoliceList = new List<string>();

    public List<string> FireList = new List<string>();
}