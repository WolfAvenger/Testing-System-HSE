using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace NonTurnableTester
{
    [JsonObject(MemberSerialization.OptIn)]
    class PackSettings
    {
        [JsonProperty]
        private DateTimeOffset Duration { get; set; }
        [JsonProperty]
        private DateTimeOffset EndTime { get; set; }
        [JsonProperty]
        private List<string> InPriority { get; set; }
        [JsonProperty]
        private int Mins { get; set; }

        public void SetFinishTime()
        {
            DateTime now = DateTime.Now;
            Duration = new DateTimeOffset(now.AddMinutes(Mins), TimeZoneInfo.Local.GetUtcOffset(now));
            if (EndTime < Duration)
            {
                Duration = EndTime;
            }
        }

        public List<string> GetPriorities() { return InPriority; }
        public void SetPriorities(List<string> p) { InPriority = p; }
        public DateTimeOffset GetFinishTime() { return Duration; }
    }
}
