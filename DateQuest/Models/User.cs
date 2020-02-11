using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DateQuest.Models
{
public class User {
        [Key]
        public int UserId { get; set; }

        [Required (ErrorMessage = "What's your first name?")]
        [MinLength (2, ErrorMessage = "At least 2 letters for a first name!")]
        [Display(Name="First Name: ")]
        public string FirstName { get; set; }

        [Required (ErrorMessage = "What's your first name?")]
        [MinLength (2, ErrorMessage = "At least 2 letters for a last name!")]
        [Display(Name="Last Name: ")]
        public string LastName { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Need a password!")]
        [Display(Name="Email: ")]
        public string Email { get; set; }

        [DataType (DataType.Password)]
        [Required (ErrorMessage = "Ya need a password!")]
        [MinLength (8, ErrorMessage = "Password must be 8 characters or longer!")]
        [Display(Name="Password: ")]

        public string Password { get; set; }

        [NotMapped]
        [Required (ErrorMessage = "Confirm Password is required!")]
        [Compare ("Password", ErrorMessage=("Password doesn't match!"))]
        [DataType (DataType.Password)]
        public string ConfirmPassword { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}