using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username {get; set;}

        [Required]
        [StringLength(16, MinimumLength=4, ErrorMessage="Passwords must be between 4 and 16 characters")]
        public string Password {get; set;}
  
    }
}