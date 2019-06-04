namespace CalendarSystem.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "Month_Id", "dbo.Months");
            DropIndex("dbo.Appointments", new[] { "Month_Id" });
            RenameColumn(table: "dbo.Appointments", name: "Month_Id", newName: "MonthID");
            AlterColumn("dbo.Appointments", "MonthID", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "MonthID");
            AddForeignKey("dbo.Appointments", "MonthID", "dbo.Months", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "MonthID", "dbo.Months");
            DropIndex("dbo.Appointments", new[] { "MonthID" });
            AlterColumn("dbo.Appointments", "MonthID", c => c.Int());
            RenameColumn(table: "dbo.Appointments", name: "MonthID", newName: "Month_Id");
            CreateIndex("dbo.Appointments", "Month_Id");
            AddForeignKey("dbo.Appointments", "Month_Id", "dbo.Months", "Id");
        }
    }
}
