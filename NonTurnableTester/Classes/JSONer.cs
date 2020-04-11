using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace NonTurnableTester.Classes
{
    class JsonSender
    {
        private Config Config { get; set; }
        public JsonSender()
        {
            Config = new Config();
            Config.Deser();
        }

        public Config GetConfig()
        {
            return Config;
        }
        public Pack GetPack(bool from_repo)
        {
            Pack p = null;
            if (!from_repo)
            {
                try
                {
                    using (StreamReader r = new StreamReader(new FileStream(Config.REPO_PATH, FileMode.Open)))
                    {
                        p = JsonConvert.DeserializeObject<Pack>(r.ReadToEnd());
                    }
                }
                catch
                {
                    MessageBox.Show("Файла с пакетом вопросов не существует в указанном в файле конфигурации пути.");
                    Environment.Exit(0);
                }
            }
            else throw new NotImplementedException();
            return p;
        }

        public void SendPack(bool to_repo, Pack p)
        {
            if (!to_repo)
            {
                using (StreamWriter w = new StreamWriter(new FileStream(Config.REPO_PATH, FileMode.Create)))
                {
                    w.WriteLine(JsonConvert.SerializeObject(p));
                }
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
