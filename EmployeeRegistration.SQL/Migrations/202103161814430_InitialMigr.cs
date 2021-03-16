namespace EmployeeRegistration.SQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDetails",
                c => new
                    {
                        pKey = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 15),
                        LastName = c.String(maxLength: 15),
                        EmailID = c.String(),
                        EmployeeID = c.Int(nullable: false),
                        EmployeeLocation = c.String(),
                        Image = c.String(),
                        CreatedAt = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.pKey);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeDetails");
        }
    }
}
