namespace PatientRegistrationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public Guid AppointmentID { get; set; }

        public Guid PatientID { get; set; }

        public Guid DoctorID { get; set; }

        public DateTime AppointmentDate { get; set; }

        [Required]
        [StringLength(500)]
        public string Injury { get; set; }

        public bool IsConfirmed { get; set; }

        public bool IsPatientMet { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime LastUpdatedDate { get; set; }

        public virtual DoctorDetail DoctorDetail { get; set; }

        public virtual User User { get; set; }
    }
}
