namespace EFCodeWithValidation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeCode = c.String(nullable: false, maxLength: 128),
                        EmployeeName = c.String(),
                        Department = c.String(),
                        Salary = c.Int(nullable: false),
                        JoiningDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeCode);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
