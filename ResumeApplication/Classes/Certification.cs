using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
    /// This class represents a certification that a person has earned.
    /// Inheritance: This class inherits from the ResumeItem class.
    /// </summary>
    public class Certification : ResumeItem
    {
        // Properties
        public string CertificationName { get; set; }
        public string IssuingOrganization { get; set; }
        public DateTime IssueDate { get; set; } // Ensure this property exists
        public DateTime ExpirationDate { get; set; } // Ensure this property exists
    }

}
