using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleControlTemplate.Models
{
    public class TemporaryWeekDayRange
    {
        public string Description { get; set; }
        public Shift AlternativeShift { get; set; }

        public DateOnly From { get; set; }
        public DateOnly To { get; set; }

        public bool Active { get; set; } = true;


    }
}
