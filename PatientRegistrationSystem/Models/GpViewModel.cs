using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PatientRegistrationSystem.Models
{
    public class GpViewModel
    {
        
        public int id { get; set; }
        [Display(Name="Name")]
        public string name { get; set; }
        [Display(Name="EmailAddress")]
        public string email { get; set; }
        [Display(Name="Address")]
        public string address { get; set; }
        [Display(Name="Date Of Birth")]
        public string DOB { get; set; }
        public bool Isconfirmed { get; set; }

        [RegularExpression("^([1-9]|0[1-9]|1[0-9]|2[0-9]|3[0-1])[- / .]([1-9]|0[1-9]|1[0-2])[- / .](1[9][0-9][0-9]|2[0][0-9][0-9])$", ErrorMessage = "Invalid date")]
        [Display(Name="Date of Appointment")]
        public string prefdate { get; set; }

        [Required(ErrorMessage="Please Enter the time")]
        [Display(Name="Time of Appointment")]
        public string time { get; set; }

        
    }
}