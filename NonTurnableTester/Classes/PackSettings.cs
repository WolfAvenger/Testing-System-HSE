using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public PackSettings(int minutes, DateTimeOffset end, List<string> p)
        {
            EndTime = end;
            DateTime now = DateTime.Now;
            Duration = new DateTimeOffset(now.AddMinutes(minutes), TimeZoneInfo.Local.GetUtcOffset(now));
            InPriority = p;
        }

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
