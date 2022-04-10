using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Models
{
    public class WeekDay
    {
        public DayOfWeek Day { get; set; } = DayOfWeek.Monday;
        public TimeOnly OnDutyTime { get; set; } = new(8, 0);
        public TimeOnly OffDutyTime { get; set; } = new(15, 30);

        public int EarlyError { get; set; } = 10;
        public int LateError { get; set; } = 5;

        public bool Active { get; set; } = true;
    }
}
