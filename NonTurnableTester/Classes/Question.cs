using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    [JsonObject(MemberSerialization.OptIn)]
    class Question
    {
        [JsonProperty]
        private List<Answer> AllAnswers = new List<Answer>(4);
        [JsonProperty]
        private string QuestionText { get; set; }
        [JsonProperty]
        private string QuestionImageEncoded { get; set; }
        [JsonProperty]
        private string QuestionHTML { get; set; }

        public Question(List<Answer> ans, string Q, string imgB, string html)
        {
            AllAnswers = ans;
            QuestionText = Q;
            QuestionImageEncoded = imgB;
            QuestionHTML = html;
        }

        public List<Answer> getAnswers() { return AllAnswers; }
        public string GetQuestionText() { return QuestionText; }
        public string GetHTML() { return QuestionHTML; }
        public string GetQuestionImageEncoded() { return QuestionImageEncoded; }

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
