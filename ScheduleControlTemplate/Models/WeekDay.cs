using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Models
{
    public class WeekDay
    {
        public DayOfWeek Day { get; set; } = DayOfWeek.Monday;
        public TimeSpan OnDutyTime { get; set; } = new(8, 0, 0);
        public TimeSpan OffDutyTime { get; set; } = new(15, 30, 0);

        public int EarlyError { get; set; } = 10;
        public int LateError { get; set; } = 5;

        public bool Active { get; set; } = true;

        private readonly CultureInfo portuguesse = new("pt");
        public string DayStr => portuguesse.DateTimeFormat.GetDayName(Day);
    }
}
