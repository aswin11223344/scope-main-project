using System.ComponentModel.DataAnnotations;

namespace project_ScopeIndia.Models
{
    public class Flogin
    {
        [Required(ErrorMessage ="please enter email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "please enter password")]
        [Display(Name ="Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="password does match")]
        public string ConfirmPassword { get; set; }
    }
}
