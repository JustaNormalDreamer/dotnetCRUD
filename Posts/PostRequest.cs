using System.ComponentModel.DataAnnotations; 

namespace techlink.Posts
{
    public class PostRequest
    {
        [Required]
        [StringLength(20, MinimumLength = 8)]
        public string name {
            get;
            set;
        }

        [Required]
        public string description
        {
            get;
            set;
        }

        [Required]
        public bool status
        {
            get;
            set;
        }
    }
}