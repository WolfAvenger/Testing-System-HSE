using System;
using System.Collections.Generic;
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

        public Question(List<Answer> ans, string Q)
        {
            AllAnswers = ans;
            QuestionText = Q;
        }

        public List<Answer> getAnswers() { return AllAnswers; }
        public string GetQuestionText() { return QuestionText; }

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
