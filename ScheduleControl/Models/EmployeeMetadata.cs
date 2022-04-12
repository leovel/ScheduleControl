using System.Collections.Generic;
using System.Linq;

namespace ScheduleControl.Models
{
    public class EmployeeMetadata
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public double TotalExpectedServiceTime => Details.Sum(d => d.ExpectedServiceTime);
        public double TotalServiceTime => Details.Sum(d => d.ServiceTime);

        public string ServiceTimeDesc => $"{TotalServiceTime}h / {TotalExpectedServiceTime}h";

        public List<DayClockInOut> Details { get; set; } = new List<DayClockInOut>();
    }
}
