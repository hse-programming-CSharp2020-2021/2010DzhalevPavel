using System.ComponentModel.DataAnnotations;

namespace Homework___Users.Models
{
    public class UserInfo
    {
        public string UserName { get; set; }
        
        public string Email { get; set; }
        [Required] public int Id { get; set; }

        public UserInfo(string name, string email, int id)
        {
            UserName = name;
            Email = email;
            Id = id;
        }
        
    }
}