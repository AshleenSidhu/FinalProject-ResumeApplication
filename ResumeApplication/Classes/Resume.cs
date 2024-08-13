using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    public class Resume
    {
        //Personal information
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string LinkedIn { get; set; }
        public string Summary { get; set; }
        //List of experiences, educations, skills, and certifications
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Certification> Certifications { get; set; }
    }
}
