using System;
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
        [JsonProperty]
        private PackSettings Settings { get; set; }

        public Pack(List<Question> q, PackSettings s)
        {
            Questions = q;
            Settings = s;
        }

        public void SetAnswer(int index, int ID, bool state)
        {
            Questions[index].SetGivenAnswer(ID, state);
        }

        public PackSettings GetSettings() { return Settings; }
        public List<Question> GetQuestions() { return Questions; }
        public void SetStudentName(string name) { StudentName = name; }
    }
}
