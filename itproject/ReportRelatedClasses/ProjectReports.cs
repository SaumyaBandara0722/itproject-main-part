using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itproject.ReportRelatedClasses
{
    class ProjectReports
    {
        public int ProjectID { get; set; }
        public int OrderID { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

    }
}
