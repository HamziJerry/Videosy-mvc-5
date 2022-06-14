namespace Videosy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailabelToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            AddColumn("dbo.Rentals", "DateRented", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateAdded");

            Sql("UPDATE Movies SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rentals", "DateAdded", c => c.DateTime(nullable: false));
            DropColumn("dbo.Rentals", "DateRented");
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
