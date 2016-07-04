namespace PatientRegistrationSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Role")]
    public partial class Role
    {
        [Key]
        [Column(Order = 0)]
        public int RoleID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RoleName { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }
    }
}
