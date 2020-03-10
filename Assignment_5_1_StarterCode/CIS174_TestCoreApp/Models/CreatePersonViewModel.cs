using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class CreatePersonViewModel
    {
        [Required]
        [StringLength(25, ErrorMessage = "Enter a name between 1 and 25 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required]
        [StringLength(25, ErrorMessage = "Enter a name between 2 and 25 characters")]
        [MinLength(2, ErrorMessage = "Enter a name between 2 and 25 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Range(1, 120, ErrorMessage = "Age must be between 1 and 120")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Enter a valid Integer")]
        public int Age { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:mm-dd-yyyy}", ApplyFormatInEditMode = true)]
        [Range(typeof(DateTime), "1/1/1900", "12/31/2018",
            ErrorMessage = "Value for {0} must be between {1} and {2}")]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Maximum length is 100")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword", ErrorMessage = "Passwords do not match")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }



        public IEnumerable<SelectListItem> Countries { get; set; }
          = new List<SelectListItem>
         {
            new SelectListItem{Text="Please select Country"},
            new SelectListItem{ Value="USA", Text="USA"},
            new SelectListItem{ Value="Mexico", Text="Mexico"},
            new SelectListItem{ Value="Canada", Text="Canada"},
         };
    }
}
