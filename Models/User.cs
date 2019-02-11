using System.ComponentModel.DataAnnotations;

namespace form_submission.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        [Display(Name = "First Name:")]
        public string fname {get; set;}
        [Required]
        [MinLength(4)]
        [Display(Name = "Last Name:")]
        public string lname {get; set;}
        [Required]
        [RegularExpression("[1-9]{1,}")]
        [Display(Name = "Age:")]
        public int age {get; set;}
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string email {get; set;}
        [Required]
        [MinLength(8)]
        [Display(Name="Password")]
        public string password {get; set;}
        public User ()
        {
            
        }
    }

}