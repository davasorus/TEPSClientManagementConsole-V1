using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;
using Formatting = Newtonsoft.Json.Formatting;

namespace TEPSClientManagementConsole_V1.Classes
{
    internal class jsonClass : UserControl
    {
        private loggingClass loggingClass = new loggingClass();
        private readonly string jsonFile = "ClientAdminAppsettings.json";

        #region creates JSON

        public void createConfigJSON()
        {
            jsonConfigFileObj _data = new jsonConfigFileObj();

            _data.MobileServerName = "";
            _data.PreReqPath = @"\\MSPServerName\";
            _data.GenerateNumber = "0";
            _data.PoliceClient = "False";
            _data.FireClient = "False";
            _data.MergeClient = "False";
            _data.Version212HigherSelector = "2";
            _data.AutomatedErrorReportingNotified = "False";
            _data.MMSPingName = " ";
            _data.ESSPingName = " ";
            _data.MSPPingName = " ";
            _data.CADPingName = " ";
            _data.RMSPingName = " ";

            var jsonPackage = JsonConvert.SerializeObject(_data, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(jsonFile, jsonPackage);

            string logEntry = "A new Client Admin Tool Settings XML was created.";

            loggingClass.logEntryWriter(logEntry, "info");
        }

        #endregion creates JSON

        #region updates JSON

        //When the XML is modified once it is changed for all other uses with that XML.
        public async void saveStartupSettings()
        {
        }

        //this will remove ORI entries from the Mobile Install App XML
        public async void removeJSONORI()
        {
            try
            {
                string text = jsonFile;

                string[] Lines = File.ReadAllLines(text);
                IEnumerable<string> newLines = Lines.Where(line => !line.Contains(@"ORI"));
                File.WriteAllLines(text, newLines);

                string logEntry = "ORI/s removed from XML.";

                loggingClass.logEntryWriter(logEntry, "info");
            }
            catch (Exception ex)
            {
                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);
            }
        }

        //this will remove FDID entries from the Mobile Install App XML
        public async void removeJSONFDID()
        {
            try
            {
                string text = jsonFile;

                string[] Lines = File.ReadAllLines(text);
                IEnumerable<string> newLines = Lines.Where(line => !line.Contains(@"FDID"));
                File.WriteAllLines(text, newLines);

                string logEntry = "FDID/s removed from XML";

                loggingClass.logEntryWriter(logEntry, "info");
            }
            catch (Exception ex)
            {
                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);
            }
        }

        //this saves ORI entries to the XML to be used again
        public async void createJSONORI(string ORI, string name)
        {
            try
            {
                var jsonFilePackage = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));

                if (jsonNodesexists(name, ORI) == false)
                {
                    ((JArray)jsonFilePackage["PoliceList"]).Add(JToken.FromObject((new jsonConfigFileORIObj { FieldName = name, ORI = ORI })));

                    string output = JsonConvert.SerializeObject(jsonFilePackage, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Could not find a part of the path"))
                {
                    createConfigJSON();
                    saveStartupSettings();

                    createJSONORI(ORI, name);

                    string message = "There was an error saving configuration to file, config file was re-created";

                    loggingClass.logEntryWriter(message, "info");
                    loggingClass.queEntrywriter(message);
                }
                else
                {
                    string logEntry1 = ex.ToString();

                    loggingClass.logEntryWriter(logEntry1, "error");

                    //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);
                }
            }
        }

        //this saves FDID entries to the XML to be used again
        public async void createJSONFDID(string FDID, string name)
        {
            try
            {
                var jsonFilePackage = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));

                JToken fdidToken = jsonFilePackage.SelectToken("FireList");

                if (jsonNodesexists(name, FDID) == false)
                {
                    ((JArray)jsonFilePackage["FireList"]).Add(JToken.FromObject((new jsonConfigFileFDIDObj { FieldName = name, FDID = FDID })));

                    string output = JsonConvert.SerializeObject(jsonFilePackage, Formatting.Indented);
                    File.WriteAllText(jsonFile, output);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Could not find a part of the path"))
                {
                    createConfigJSON();
                    saveStartupSettings();

                    createJSONFDID(FDID, name);

                    string message = "There was an error saving configuration to file, config file was re-created";

                    loggingClass.logEntryWriter(message, "info");
                    loggingClass.queEntrywriter(message);
                }
                else
                {
                    string logEntry1 = ex.ToString();

                    loggingClass.logEntryWriter(logEntry1, "error");

                    //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);
                }
            }
        }

        //mitigates the accidental corruption of the updater config file
        public void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        public void orphanCleanUp()
        {
            string text = jsonFile;

            string[] Lines = File.ReadAllLines(text);
            IEnumerable<string> newLines = Lines.Where(line => !line.Contains(@"{}"));
            File.WriteAllLines(text, newLines);
        }

        #endregion updates JSON

        #region loads data

        //XML Related information. Broken up between loading prior XML information OR creating a new XML with placeholder server location.
        public async void initialLoadofJSON()
        {
            try
            {
                //Checking if the PreReqAppSettings.xml exists, and loading the data if it does.
                if (File.Exists(jsonFile))
                {
                    var jsonFilePackage = JsonConvert.DeserializeObject<jsonConfigFileObj>(File.ReadAllText(jsonFile));

                    try
                    {
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("Object reference not set to an instance of an object"))
                        {
                            string logEntry1 = "there was an error reading from JSON. It will be reset to default. Error Message: " + ex.Message;

                            loggingClass.logEntryWriter(logEntry1, "error");

                            createConfigJSON();
                        }
                        else if (ex.Message.Contains("Bad JSON escape sequence"))
                        {
                            string logEntry1 = "there was an error reading from JSON. It will be reset to default. Error Message: " + ex.Message;

                            loggingClass.logEntryWriter(logEntry1, "error");

                            createConfigJSON();
                        }
                        else if (ex.Message.Contains("Bad JSON escape sequence"))
                        {
                            string logEntry1 = "there was an error reading from JSON. It will be reset to default. Error Message: " + ex.ToString();

                            loggingClass.logEntryWriter(logEntry1, "error");

                            File.Delete(jsonFile);
                            createConfigJSON();
                        }
                        else
                        {
                            string logEntry1 = "there was an error reading from JSON. It will be reset to default. Error Message: " + ex.ToString();

                            loggingClass.logEntryWriter(logEntry1, "error");

                            // await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);

                            createConfigJSON();
                        }
                    }

                    string logEntry = "Prior Settings Loaded";

                    loggingClass.logEntryWriter(logEntry, "info");
                }
                //Creation of a new PreReqAppSettings.xml if one does not already exist.
                else
                {
                    createConfigJSON();
                }
            }
            catch (Exception ex)
            {
                createConfigJSON();

                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);
            }
        }

        //will load old/prior ORI config in XML
        //this is will use the text from the XML file that corresponds to the ORI text fields in the application
        public async Task<string> loadORIJSONAsync(string txt)
        {
            try
            {
                var jsonFilePackage = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));

                JToken oriToken = jsonFilePackage.SelectToken("PoliceList[?(@.FieldName == '" + txt + "')]");

                if (oriToken != null)
                {
                    string ori = oriToken.Value<string>("ORI");

                    return ori;
                }
            }
            catch (Exception ex)
            {
                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);

                return "error";
            }

            return "";
        }

        //will load old/prior FDID config in XML
        //this is will use the text from the XML file that corresponds to the FDID text fields in the application
        public string loadFDIDJSON(string txt)
        {
            try
            {
                var jsonFilePackage = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));

                JToken fdidToken = jsonFilePackage.SelectToken("FireList[?(@.FieldName == '" + txt + "')]");

                if (fdidToken != null)
                {
                    string ori = fdidToken.Value<string>("FDID");

                    return ori;
                }
            }
            catch (Exception ex)
            {
                string logEntry1 = ex.ToString();

                loggingClass.logEntryWriter(logEntry1, "error");

                //await loggingClass.remoteErrorReporting("Client Admin Tool", Assembly.GetExecutingAssembly().GetName().Version.ToString(), ex.ToString(), "Automated Error Reported by " + Environment.UserName);

                return "error";
            }

            return "";
        }

        //looks to see if an XML node already exists and returns a bool if it does or not
        private bool jsonNodesexists(string name, string agencyID)
        {
            var jsonFilePackage = (JObject)JsonConvert.DeserializeObject(File.ReadAllText(jsonFile));

            if (agencyID.Length >= 9)
            {
                JToken oriToken = jsonFilePackage.SelectToken("PoliceList[?(@.FieldName == '" + name + "')]");

                if (oriToken == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                JToken fdidToken = jsonFilePackage.SelectToken("FireList[?(@.FieldName == '" + name + "')]");

                if (fdidToken == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            return true;
        }

        #endregion loads data
    }
}

internal class jsonConfigFileObj
{
    public string MobileServerName { get; set; }

    public string PreReqPath { get; set; }

    public string GenerateNumber { get; set; }

    public string PoliceClient { get; set; }

    public string FireClient { get; set; }

    public string MergeClient { get; set; }

    public string Version212HigherSelector { get; set; }

    public string AutomatedErrorReportingNotified { get; set; }

    public string MMSPingName { get; set; }

    public string ESSPingName { get; set; }

    public string MSPPingName { get; set; }

    public string CADPingName { get; set; }

    public string RMSPingName { get; set; }

    public List<jsonConfigFileORIObj> PoliceList = new List<jsonConfigFileORIObj>();
    public List<jsonConfigFileFDIDObj> FireList = new List<jsonConfigFileFDIDObj>();
}

internal class jsonConfigFileORIObj
{
    public string FieldName { get; set; }

    public string ORI { get; set; }
}

internal class jsonConfigFileFDIDObj
{
    public string FieldName { get; set; }

    public string FDID { get; set; }
}