using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Models
{
    public class Shift
    {
        private readonly Dictionary<DayOfWeek, WeekDay> timeTable;
        public Shift()
        {
            timeTable = new Dictionary<DayOfWeek, WeekDay>
            {
                {DayOfWeek.Sunday, new WeekDay { Day = DayOfWeek.Sunday, Active = false }},
                {DayOfWeek.Monday, new WeekDay { Day = DayOfWeek.Monday, Active = true, OnDutyTime = new(8, 0, 0), OffDutyTime = new(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Tuesday, new WeekDay { Day = DayOfWeek.Tuesday, Active = true, OnDutyTime = new(8, 0, 0), OffDutyTime = new(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Wednesday, new WeekDay { Day = DayOfWeek.Wednesday, Active = true, OnDutyTime = new (8, 0, 0), OffDutyTime = new (15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Thursday, new WeekDay { Day = DayOfWeek.Thursday, Active = true, OnDutyTime = new(8, 0, 0), OffDutyTime = new(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Friday, new WeekDay { Day = DayOfWeek.Friday, Active = true, OnDutyTime = new(8, 0, 0), OffDutyTime = new(15, 0, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Saturday, new WeekDay { Day = DayOfWeek.Saturday, Active = false }}
            };
        }

        public Shift(params WeekDay[] weekDays) : this()
        {
            Update(weekDays);
        }

        public IEnumerable<WeekDay> TimeTable => timeTable.Values;

        public void Update(WeekDay weekDay) => timeTable[weekDay.Day] = weekDay;
        public void Update(params WeekDay[] weekDays)
        {
            foreach (var weekDay in weekDays)
            {
                Update(weekDay);
            }
        }

        public WeekDay GetDayDetails(DayOfWeek dayOfWeek) => timeTable[dayOfWeek];
        public WeekDay GetDayDetails(DateTime date) => GetDayDetails(date.DayOfWeek);
    }
}
