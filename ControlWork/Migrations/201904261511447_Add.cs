namespace ControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Issuers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Text = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Cost = c.Int(nullable: false),
                        Duration = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Login = c.String(),
                        Password = c.String(),
                        RepeatPassword = c.String(),
                        Address = c.String(),
                        Purse = c.Int(nullable: false),
                        Since = c.DateTime(nullable: false),
                        Subscription_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Subscriptions", t => t.Subscription_Id)
                .Index(t => t.Subscription_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Subscription_Id", "dbo.Subscriptions");
            DropIndex("dbo.Users", new[] { "Subscription_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Publications");
            DropTable("dbo.Issuers");
        }
    }
}
