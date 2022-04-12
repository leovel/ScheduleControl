using System.Collections.Generic;
using System.ComponentModel;

namespace ScheduleControlTemplate.Models
{
    public class EmployeeMetadata
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public List<DayClockInOut> Details { get; set; } = new List<DayClockInOut>();
    }

    [DataObject]
    public class EmployeeMetadataDataSource
    {
        public List<EmployeeMetadata> Metadata { get; set; }
    }
}
