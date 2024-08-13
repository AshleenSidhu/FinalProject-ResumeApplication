using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
    /// This class represents an experience that a person has had.
    /// Inheritance: This class inherits from the ResumeItem class.
    /// </summary>
    public class Experience : ResumeItem
    {
        // Ensure this class has the following properties
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
    }
}
