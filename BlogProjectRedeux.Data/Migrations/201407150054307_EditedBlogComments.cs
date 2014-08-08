namespace BlogProjectRedeux.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedBlogComments : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogComments", "PostTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogComments", "PostTime");
        }
    }
}
