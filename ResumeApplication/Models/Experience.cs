using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Models
{
    public class Experience : ResumeItem
    {
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
    }
}
