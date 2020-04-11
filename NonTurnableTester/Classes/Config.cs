using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    class Config
    {
        public string REPO_PATH { get; set; }
        public List<string> InPriority { get; set; }

        public void SerExample()
        {
            REPO_PATH = @"";
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
                InPriority = c.InPriority;
            }
            
        }
        
    }
}
