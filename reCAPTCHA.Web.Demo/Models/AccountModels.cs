using System.ComponentModel.DataAnnotations;

namespace reCAPTCHA.Web.Demo.Models
{
    public class RegisterModel
    {
        public RegisterModel()
        {
            IsSuccess = false;
        }

        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }

        public bool IsSuccess { get; set; }
    }
}
