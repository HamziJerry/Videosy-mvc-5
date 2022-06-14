namespace Videosy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddReleasedDateToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
