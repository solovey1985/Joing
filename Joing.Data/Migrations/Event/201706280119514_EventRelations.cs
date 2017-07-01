namespace Joing.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventRelations : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Events.Locations", "Id", "Events.Events");
            DropIndex("Events.Locations", new[] { "Id" });
        }
        
        public override void Down()
        {
            CreateIndex("Events.Locations", "Id");
            AddForeignKey("Events.Locations", "Id", "Events.Events", "Id");
        }
    }
}
