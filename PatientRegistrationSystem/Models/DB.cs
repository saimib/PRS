namespace PatientRegistrationSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<DoctorDetail> DoctorDetails { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .Property(e => e.Injury)
                .IsUnicode(false);

            modelBuilder.Entity<DoctorDetail>()
                .Property(e => e.Speciality)
                .IsUnicode(false);

            modelBuilder.Entity<DoctorDetail>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.DoctorDetail)
                .HasForeignKey(e => e.DoctorID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hospital>()
                .Property(e => e.HospitalName)
                .IsUnicode(false);

            modelBuilder.Entity<Hospital>()
                .HasMany(e => e.DoctorDetails)
                .WithRequired(e => e.Hospital)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsUnicode(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointments)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.PatientID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DoctorDetails)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.DoctorID)
                .WillCascadeOnDelete(false);
        }
    }
}
