using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    [JsonObject(MemberSerialization.OptIn)]
    class Answer
    {
        [JsonProperty]
        private bool Chosen { get; set; }
        [JsonProperty] 
        private int ID { get; set; }
        [JsonProperty]
        private bool Correct { get; set; }
        [JsonProperty]
        private string Text { get; set; }

        public Answer(string text, int ID, bool correct = false)
        {
            Text = text;
            this.ID = ID;
            Correct = correct;
            Chosen = false;
        }

        public bool IsChosen() { return Chosen; }
        public int GetID() { return ID; }
        public string GetText() { return Text; }
        public bool IsCorrect() { return Correct; }
        public void SetChooseState(bool state) { Chosen = state; }
    }
}
