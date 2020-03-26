using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace NonTurnableTester
{
    class Config
    {
        public string REPO_PATH { get; set; }

        public void SerExample()
        {
            REPO_PATH = @"http:\localhost:3000";
            using (StreamWriter sw = new StreamWriter("config.cfg"))
            {
                sw.Write(JsonConvert.SerializeObject(this));
            }
        }

        public void Deser()
        {
            using (StreamReader reader = new StreamReader("config.cfg"))
            {
                Config c = JsonConvert.DeserializeObject<Config>(reader.ReadToEnd());
                REPO_PATH = c.REPO_PATH;
            }
            
        }
        
    }
}
