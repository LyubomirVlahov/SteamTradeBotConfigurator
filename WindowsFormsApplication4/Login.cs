using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml;

namespace WindowsFormsApplication4
{
    public class Login
    {
        private string settingJSONPath = @"c:\settings.json";
        private string licensePath = @"c:\license.xml";

        public void writeJsonToFile(JObject obj)
        {
            File.WriteAllText(settingJSONPath, obj.ToString());

            // write JSON directly to a file
            using (StreamWriter file = File.CreateText(settingJSONPath))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                obj.WriteTo(writer);
            }
        }

        public JObject EditJson(JObject o, LogginDetails ld)
        {
            JObject settings = (JObject)o;
            JArray bots = (JArray)o["Bots"];
            JObject bot = (JObject)bots[0];

            bot["Username"] = ld.UserName;
            bot["Password"] = ld.Password;
            bot["DisplayName"] = ld.DisplayName;
            bot["DisplayNamePrefix"] = ld.DisplayNamePrefix;
            bot["ChatResponse"] = ld.ChatResponse;

            return settings;
        }

        public JObject readJsonFile()
        {
            JObject o1 = JObject.Parse(File.ReadAllText(settingJSONPath));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(settingJSONPath))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject o2 = (JObject)JToken.ReadFrom(reader);
                return o2;
            }
        }

        public string readUserName()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(licensePath);
            XmlNode name = doc.SelectSingleNode("/license/name");

            return name.InnerText;
        }

        public LogginDetails getDetailsValues(JObject obj)
        {
            JArray bots = (JArray)obj["Bots"];
            JObject bot = (JObject)bots[0];

            return new LogginDetails(readUserName(), "", bot["DisplayName"].ToString(), bot["DisplayNamePrefix"].ToString(), bot["ChatResponse"].ToString());
        }
         
        
    }
}
