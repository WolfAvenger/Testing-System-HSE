using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonTurnableTester
{
    class PackSettings
    {
        private DateTimeOffset Duration { get; set; }
        private DateTimeOffset EndTime { get; set; }

        public PackSettings(int minutes, DateTimeOffset end)
        {
            EndTime = end;
            DateTime now = new DateTime();
            //Duration = new DateTimeOffset(now.AddMinutes(minutes), TimeZoneInfo.Local.GetUtcOffset(now));
        }

        public DateTimeOffset GetFinishTime()
        {
            if (EndTime < Duration)
            {
                return EndTime;
            }
            else
            {
                return Duration;
            }
        }
    }
}
