namespace PatientRegistrationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hospital")]
    public partial class Hospital
    {
        public Guid HospitalID { get; set; }

        [Required]
        [StringLength(100)]
        public string HospitalName { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
