using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    [JsonObject(MemberSerialization.OptIn)]
    class Pack
    {
        [JsonProperty]
        private List<Question> Questions { get; set; }
        [JsonProperty]
        private string StudentName { get; set; }

        public Pack(List<Question> q)
        {
            q = Questions;
        }
        public Pack()
        {
            Questions = new List<Question>();
        }

        public void SetAnswer(List<int> answer, int index)
        {
            Questions[index].SetGivenAnswer(answer);
        }

        public void AddQuestion(Question q)
        {
            Questions.Add(q);
        }

        public List<Question> GetQuestions() { return Questions; }

        public void GetPack()
        {
            using (StreamReader r = new StreamReader(new FileStream("pack.txt", FileMode.Open)))
            {
                Pack p = JsonConvert.DeserializeObject<Pack>(r.ReadToEnd());
                Questions = p.Questions;
            }
        }

        public static Pack GetPackFromRepo(string repo_path)
        {
            return null;
        }

        public void SendPack()
        {
            //return false;
            using (StreamWriter w = new StreamWriter(new FileStream(@"pack_fin.txt", FileMode.Create)))
            {
                w.WriteLine(JsonConvert.SerializeObject(this));
            }
        }

        public void CreatePack()
        {
            Example();
            using (StreamWriter w = new StreamWriter(new FileStream(@"pack.txt", FileMode.Create)))
            {
                w.WriteLine(JsonConvert.SerializeObject(this));
            }
        }

        public void Example()
        {
            for (int i=0; i<3; i++)
            {
                Question q = new Question("1_"+i, "2_"+ i, "3_" + i, "4_" + i, "Q"+i);
                AddQuestion(q);
            }
        }

        public void SetStudentName(string name) { StudentName = name; }
    }
}
