using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
    /// This class represents a skill that a person has.
    /// Inheritance: This class inherits from the ResumeItem class.
    /// </summary>
    public class Skill : ResumeItem
    {
        public string SkillName { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
