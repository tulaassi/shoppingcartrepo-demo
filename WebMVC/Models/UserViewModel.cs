using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebMVC.Models
{
    public class UserViewModel
    {
    
            public int Id { get; set; }

            [Required(ErrorMessage = "First Name is required")][StringLength(50, MinimumLength = 3)][Display(Name = "First Name")] public string FirstName { get; set; }

            //[Required(ErrorMessage = "Last Name is required")]         [StringLength(50, MinimumLength = 0)]        [Display(Name = "Last Name")]        public string LastName { get; set; }

            [Required(ErrorMessage = "Age is required")][Range(typeof(int), "18", "60", ErrorMessage = "Age must be between 18 and 40")] public int Age { get; set; }

            [Display(Name = "Email Address")][Required(ErrorMessage = "Email Address is required")][StringLength(60)][DataType(DataType.EmailAddress, ErrorMessage = "Invalid Email Address")] public string Email { get; set; }

            [Display(Name = "Mobile Number")][StringLength(10)][Required(ErrorMessage = "Mobile Number is required")][RegularExpression("[6-9][0-9]{9}", ErrorMessage = "Mobile Number must begin with 6,7,8 or 9")] public string MobileNumber { get; set; }

            [Required(ErrorMessage = "Password is required")][StringLength(10)][DataType(DataType.Password)] public string Password { get; set; }

            [Required(ErrorMessage = "Confirm Password is required")]
            [DataType(DataType.Password)]

            [StringLength(10)][Display(Name = "Re-Enter Password")][Compare("Password")] public string ConfirmPassword { get; set; }
        }
    }



