namespace Eoh_DataService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        EmployeeNumber = c.String(nullable: false, maxLength: 16, unicode: false),
                        EmployedDate = c.DateTime(nullable: false),
                        TerminatedDate = c.DateTime(),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .Index(t => t.PersonId);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 128, unicode: false),
                        LastName = c.String(nullable: false, maxLength: 128, unicode: false),
                        BirthDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "PersonId", "dbo.People");
            DropIndex("dbo.Employees", new[] { "PersonId" });
            DropTable("dbo.People");
            DropTable("dbo.Employees");
        }
    }
}
