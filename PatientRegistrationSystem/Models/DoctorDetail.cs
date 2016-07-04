namespace PatientRegistrationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoctorDetail")]
    public partial class DoctorDetail
    {
        public Guid DoctorDetailID { get; set; }

        public Guid DoctorID { get; set; }

        public Guid HospitalID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Speciality { get; set; }
    }
}
