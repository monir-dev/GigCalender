using System.ComponentModel.DataAnnotations;

namespace Auth.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}