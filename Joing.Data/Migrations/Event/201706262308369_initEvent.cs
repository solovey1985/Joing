namespace Joing.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initEvent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Events.Conditions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        ValueType = c.Int(nullable: false),
                        Logic = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        CreateBy = c.Guid(nullable: false),
                        UpadatedAt = c.DateTime(),
                        UpdatedAt = c.Guid(),
                        Event_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Events.Events", t => t.Event_Id)
                .Index(t => t.Event_Id);
            
            CreateTable(
                "Events.Events",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Privacy = c.Int(nullable: false),
                        StartedAt = c.DateTime(nullable: false),
                        EndAt = c.DateTime(),
                        CanceledAt = c.DateTime(),
                        InterruptedAt = c.DateTime(),
                        CreatedAt = c.DateTime(nullable: false),
                        CreateBy = c.Guid(nullable: false),
                        UpadatedAt = c.DateTime(),
                        UpdatedAt = c.Guid(),
                        Place_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Events.Locations", t => t.Place_Id)
                .Index(t => t.Place_Id);
            
            CreateTable(
                "Events.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Address = c.String(),
                        Longitude = c.Double(),
                        Latitude = c.Double(),
                        MapUrl = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Events.Events", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Events.Events", "Place_Id", "Events.Locations");
            DropForeignKey("Events.Locations", "Id", "Events.Events");
            DropForeignKey("Events.Conditions", "Event_Id", "Events.Events");
            DropIndex("Events.Locations", new[] { "Id" });
            DropIndex("Events.Events", new[] { "Place_Id" });
            DropIndex("Events.Conditions", new[] { "Event_Id" });
            DropTable("Events.Locations");
            DropTable("Events.Events");
            DropTable("Events.Conditions");
        }
    }
}
