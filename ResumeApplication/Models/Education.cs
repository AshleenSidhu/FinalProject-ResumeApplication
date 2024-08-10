using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Models
{
    public class Education : ResumeItem
    {
        public string Degree { get; set; }
        public string Institution { get; set; }
    }
}
