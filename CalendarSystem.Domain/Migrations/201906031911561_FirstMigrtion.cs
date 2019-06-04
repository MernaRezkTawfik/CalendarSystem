namespace CalendarSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigrtion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfAppointment = c.DateTime(nullable: false),
                        Description = c.String(),
                        Organizer = c.String(),
                        Subject = c.String(),
                        Month_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Months", t => t.Month_Id)
                .Index(t => t.Month_Id);
            
            CreateTable(
                "dbo.Months",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "Month_Id", "dbo.Months");
            DropIndex("dbo.Appointments", new[] { "Month_Id" });
            DropTable("dbo.Months");
            DropTable("dbo.Appointments");
        }
    }
}
