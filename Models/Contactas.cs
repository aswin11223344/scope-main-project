using System.ComponentModel.DataAnnotations;

namespace project_ScopeIndia.Models
{
    public class Contactas
    {
        [Required(ErrorMessage ="name is required")]   
        
        public string Name { get; set; }

        [Required(ErrorMessage ="Email is required")]
        [EmailAddress]
        public string Email { get; set; }

        public string Subject { get; set; }

        public string Msg { get; set; }
    }
}
