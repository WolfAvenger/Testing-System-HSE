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
        private string A { get; set; }
        [JsonProperty]
        private string B { get; set; }
        [JsonProperty]
        private string C { get; set; }
        [JsonProperty]
        private string D { get; set; }
        [JsonProperty]
        private List<int> CorrectAnswer { get; set; }
        [JsonProperty]
        private List<int> GivenAnswer { get; set; }
        [JsonProperty]
        private string QuestionText { get; set; }

        public List<string> Answers = new List<string>(4);

        public Question(string a, string b, string c, string d, string Q, List<int> correct = null)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            QuestionText = Q;
            CorrectAnswer = correct;
            Answers.Add(A);
            Answers.Add(B);
            Answers.Add(C);
            Answers.Add(D);
            GivenAnswer = new List<int>();
        }

        public string GetA() { return A; }
        public string GetB() { return B; }
        public string GetC() { return C; }
        public string GetD() { return D; }
        public string GetQuestionText() { return QuestionText; }

        public List<int> GetGivenAnswersIndexes() { return GivenAnswer; }

        public void SetGivenAnswer(List<int> a) { GivenAnswer = a; }

    }
}
