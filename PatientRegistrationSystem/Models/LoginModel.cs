using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientRegistrationSystem.Models
{
    public class LoginModel
    {

        [EmailAddress(ErrorMessage="Invalid Email Address")]
        [Required(ErrorMessage="Please Enter the Email Adddress")]
        [Display(Name="Email Address")]
        public string email { get; set; }

        [Required(ErrorMessage="Please Enter the Password")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string password { get; set; }


    }
}