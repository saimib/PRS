namespace PatientRegistrationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserProfile_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false, maxLength: 20),
                        confirmpassword = c.String(),
                    })
                .PrimaryKey(t => t.UserProfile_id);
            
            CreateTable(
                "dbo.UserDetails",
                c => new
                    {
                        UserDetail_id = c.Int(nullable: false, identity: true),
                        f_id = c.Int(nullable: false),
                        DOB = c.String(nullable: false),
                        Address = c.String(),
                        TypeofInjury = c.String(),
                        Illness = c.String(),
                        prefdate = c.String(),
                    })
                .PrimaryKey(t => t.UserDetail_id);
            
            CreateTable(
                "dbo.Gpdetails",
                c => new
                    {
                        Gp_id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false, maxLength: 20),
                        confirmpassword = c.String(),
                    })
                .PrimaryKey(t => t.Gp_id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Gpdetails");
            DropTable("dbo.UserDetails");
            DropTable("dbo.UserProfiles");
        }
    }
}
