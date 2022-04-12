using System;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleControl.Models
{
    public class Shift
    {
        private readonly Dictionary<DayOfWeek, WeekDay> timeTable;
        public Shift()
        {
            timeTable = new Dictionary<DayOfWeek, WeekDay>
            {
                {DayOfWeek.Sunday, new WeekDay { Day = DayOfWeek.Sunday, Active = false }},
                {DayOfWeek.Monday, new WeekDay { Day = DayOfWeek.Monday, Active = true, OnDutyTime = new TimeSpan(8, 0, 0), OffDutyTime = new TimeSpan(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Tuesday, new WeekDay { Day = DayOfWeek.Tuesday, Active = true, OnDutyTime = new TimeSpan(8, 0, 0), OffDutyTime = new TimeSpan(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Wednesday, new WeekDay { Day = DayOfWeek.Wednesday, Active = true, OnDutyTime = new TimeSpan(8, 0, 0), OffDutyTime = new TimeSpan(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Thursday, new WeekDay { Day = DayOfWeek.Thursday, Active = true, OnDutyTime = new TimeSpan(8, 0, 0), OffDutyTime = new TimeSpan(15, 30, 0), EarlyError = 10, LateError = 5  }},
                {DayOfWeek.Friday, new WeekDay { Day = DayOfWeek.Friday, Active = true, OnDutyTime = new TimeSpan(8, 0, 0), OffDutyTime = new TimeSpan(15, 0, 0), EarlyError = 10, LateError = 5  }},
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

        public Shift DeltaTimeDeepClone(int onDutyDelta = 0, int offDutyDelta = 0)
        {
            var clone = new Shift(TimeTable.Select(wd => new WeekDay
            {
                Day = wd.Day,
                Active = wd.Active,
                OnDutyTime = wd.OnDutyTime.Add(new TimeSpan(0, onDutyDelta, 0)),
                OffDutyTime = wd.OffDutyTime.Add(new TimeSpan(0, offDutyDelta, 0)),
                EarlyError = wd.EarlyError,
                LateError = wd.LateError
            }).ToArray());

            return clone;
        }
    }
}
