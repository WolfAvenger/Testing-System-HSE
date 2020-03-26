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
        public DateTimeOffset TIME_TEST_END { get; set; }
        public int COMPUTER_ID { get; set; }

        public Config()
        {
            /*REPO_PATH = @"http:\localhost:3000";
            TIME_TEST_END = new DateTimeOffset(DateTime.UtcNow).AddMinutes(50);*/
        }

        public void SerExample()
        {
            REPO_PATH = @"http:\localhost:3000";
            TIME_TEST_END = new DateTimeOffset(DateTime.UtcNow).AddMinutes(50);
            COMPUTER_ID = 42;
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
                TIME_TEST_END = c.TIME_TEST_END;
                COMPUTER_ID = c.COMPUTER_ID;
            }
            
        }
        
    }
}
