using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Models
{
    public class Certification : ResumeItem
    {
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; } // Ensure this property exists
        public DateTime ExpirationDate { get; set; } // Ensure this property exists
    }

}
