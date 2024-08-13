using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
    /// This class represents a resume item that a person has.
    /// </summary>
    public abstract class ResumeItem
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
    }
}
