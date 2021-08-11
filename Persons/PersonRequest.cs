using System.ComponentModel.DataAnnotations; 

namespace techlink.Persons
{
    public class PersonRequest
    {
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string name {
            get;
            set;
        }

        [Required]
        [EmailAddress]
        [StringLength(20, MinimumLength = 8)]
        public string email
        {
            get;
            set;
        }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string password
        {
            get;
            set;
        }

        [Required]
        [StringLength(20, MinimumLength = 8)]
        [Compare("password", ErrorMessage = "Password and confirmation password doesn't match.")]
        public string confirmPassword
        {
            get;
            set;
        }
    }
}