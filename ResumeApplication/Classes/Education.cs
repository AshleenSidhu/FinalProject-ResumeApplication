using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
    /// This class represents an education that a person has received.
    /// Inheritance: This class inherits from the ResumeItem class.
    /// </summary>
    public class Education : ResumeItem
    {
        // Properties
        public string Degree { get; set; }
        public string Institution { get; set; }
    }
}
