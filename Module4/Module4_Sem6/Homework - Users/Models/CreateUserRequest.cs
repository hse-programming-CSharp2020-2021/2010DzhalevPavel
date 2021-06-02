using System.ComponentModel.DataAnnotations;

namespace Homework___Users.Models
{
    public class CreateUserRequest
    {
        [Display(Name = "User name")]
        [Required]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        
        [Display(Name = "Email address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
    }
}