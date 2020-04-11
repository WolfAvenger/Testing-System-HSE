using System.Collections.Generic;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    [JsonObject(MemberSerialization.OptIn)]
    class Question
    {
        [JsonProperty]
        private List<Answer> AllAnswers = new List<Answer>(4);
        [JsonProperty]
        private string text { get; set; }
        [JsonProperty]
        private string image { get; set; }
        [JsonProperty]
        private string html { get; set; }

        public Question(List<Answer> ans, string Q, string imgB, string html)
        {
            AllAnswers = ans;
            text = Q;
            image = imgB;
            this.html = html;
        }

        public List<Answer> getAnswers() { return AllAnswers; }
        public string GetQuestionText() { return text; }
        public string GetHTML() { return html; }
        public string GetQuestionImageEncoded() { return image; }

        public void SetGivenAnswer(int ID, bool state) 
        { 
            for (var i = 0; i< AllAnswers.Count; i++)
            {
                if (AllAnswers[i].GetID() == ID)
                {
                    AllAnswers[i].SetChooseState(state);
                    break;
                }
            }
        }

    }
}
