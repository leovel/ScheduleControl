using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ScheduleControl.Models
{
    [DataObject]
    public class EmployeeMetadata
    {
        public string Id { get; set; }
        public string FullName { get; set; }
        public string Department { get; set; }

        public List<DayClockInOut> Details { get; set; } = new List<DayClockInOut>();
    }

    [DataObject]
    public class EmployeeDataSource: List<EmployeeMetadata>
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<EmployeeMetadata> GetAllByDepartment(string department) => this.Where( e => e.Department == department).ToList();
    }
}
