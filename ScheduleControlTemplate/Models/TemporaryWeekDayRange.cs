using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Models
{
    public class TemporaryWeekDayRange
    {
        public static Shift BaseShift { get; set; } = new();
        public string Description { get; set; } = string.Empty;
        public Shift AlternativeShift { get; set; } = BaseShift;

        public DateTime From { get; set; } = DateTime.Today.AddDays(-7);
        public DateTime To { get; set; } = DateTime.Now;
        public bool Active { get; set; } = true;
    }
}
