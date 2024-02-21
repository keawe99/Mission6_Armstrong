using System.ComponentModel.DataAnnotations;

namespace Mission6_Armstrong.Models
{
    public class Application
    {
        public int ApplicationID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Category { get; set; }
        public bool Edited { get; set; }
        public string Notes { get; set; }
    }
}
