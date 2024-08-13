using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeApplication.Classes
{
    /// <summary>
	/// This class represents a project that a person has worked on.
	/// Inheritance: This class does not inherit from any other classes.
	/// </summary>
	
    public class Project
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Technologies { get; set; }
        public string GitHubLink { get; set; }
    }
    
}
