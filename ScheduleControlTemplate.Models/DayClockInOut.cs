using System;
using System.ComponentModel;
using System.Globalization;

namespace ScheduleControl.Models
{
    [DataObject]
    public class DayClockInOut
    {
        public DateTime Date { get; set; }
        private static readonly CultureInfo portuguesse = new CultureInfo("pt");
        public string DayStr => portuguesse.DateTimeFormat.GetDayName(Date.DayOfWeek);

        public TimeSpan OnDutyTime { get; set; }
        public TimeSpan OffDutyTime { get; set; }
        public TimeSpan EarlyError { get; set; } 
        public TimeSpan LateError { get; set; }

        public TimeSpan? ClockIn { get; set; }
        public TimeSpan? ClockOut { get; set; }

        public bool IsHoliday { get; set; }
        public string HolidayDescription { get; set; }

        public bool Absence => !IsHoliday && (ClockIn is null || ClockOut is null);
        public bool LateIn => !IsHoliday && !Absence && ClockIn.Value > OnDutyTime.Add(EarlyError);
        public bool EarlyOut => !IsHoliday && !Absence && ClockOut.Value < OffDutyTime.Subtract(LateError);

        public string Status => IsHoliday ? HolidayDescription :
            Absence ? "Ausência" :
            LateIn && EarlyOut ? "Entrou tarde/Saíu sedo" :
            LateIn ? "Entrou tarde" : EarlyOut ? "Saíu sedo" :
            string.Empty;
    }
}
