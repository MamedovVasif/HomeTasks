using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Xml;

namespace Models
{
    public static class Convertjson
    {
        public static void Downloadjson( string FileName)
        {
            string link = "https://www.cbar.az/currencies/08.04.2022.xml";

            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(link).Result;
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(response);
            string jsonText = JsonConvert.SerializeXmlNode(doc);
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\User\source\repos\ConsoleApp1\ConsoleApp1" + FileName + ".json");
            streamWriter.Write(jsonText);
            streamWriter.Close();

        }


    }
}