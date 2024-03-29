namespace BlogProjectRedeux.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditedBlogPosts : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlogComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Author = c.String(),
                        Content = c.String(),
                        BlogPost_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BlogPosts", t => t.BlogPost_Id)
                .Index(t => t.BlogPost_Id);
            
            AddColumn("dbo.BlogPosts", "PostTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BlogComments", "BlogPost_Id", "dbo.BlogPosts");
            DropIndex("dbo.BlogComments", new[] { "BlogPost_Id" });
            DropColumn("dbo.BlogPosts", "PostTime");
            DropTable("dbo.BlogComments");
        }
    }
}
