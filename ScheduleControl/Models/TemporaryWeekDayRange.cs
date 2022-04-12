using System;

namespace ScheduleControl.Models
{
    public class TemporaryWeekDayRange
    {
        public static Shift BaseShift { get; set; } = new Shift();
        public string Description { get; set; } = string.Empty;
        public Shift AlternativeShift { get; set; } = BaseShift.DeltaTimeDeepClone();

        private DateTime from = DateTime.Today.AddDays(-7);

        public DateTime From
        {
            get => from;
            set
            {
                value = value.Date;
                from = value > To ? To.Date : value;
            }
        }

        private DateTime to = DateTime.Today.AddDays(1);

        public DateTime To
        {
            get => to;
            set
            {
                value = value.Date.AddDays(1).AddMilliseconds(-1);
                to = value < From ? From.Date.AddDays(1).AddMilliseconds(-1) : value;
            }
        }

        public bool Active { get; set; } = true;

        public bool Contains(DateTime date) => date >= From && date <= To;
    }
}
