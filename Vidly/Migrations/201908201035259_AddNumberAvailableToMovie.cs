namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable", c => c.Byte(nullable: false));
            Sql("UPDATE mOVIES set NumberAvailable = numberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumberAvailable");
        }
    }
}
