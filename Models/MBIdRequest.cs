using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace musicbrainz.Models
{    
    public class MBIdRequest
    {
        private const string BaseUrl = "http://musicbrainz.org/ws/2/artist/";
        private const string FilterQuery = "?&fmt=json&inc=url-rels+release-groups";
        public bool DoSearch(string MBId)
        {
            if (MBId == null || MBId == "")
            {
                throw new Exception("MBId not set");
            }
            WebClient WC = new WebClient();            
            WC.Headers.Add("User-Agent", "C# App");
            Stream data = WC.OpenRead(BaseUrl + MBId + FilterQuery);
            StreamReader reader = new StreamReader(data);
            string jsonData = reader.ReadToEnd();
            var deserializedJson = JsonConvert.DeserializeObject<Dictionary<object, object>>(jsonData);
            var relationsJson = deserializedJson["relations"].ToString();
            int pos1 = relationsJson.IndexOf("\"type\": \"wikidata\"");
            //"\"type\":\"wikidata\"
            /*
            var details = JObject.Parse(deserializedJson.ToString());
            var R = details.Root;
            var details2 = JObject.Parse(R.ToString()); 
            */
            return true;
        }


    }
}
