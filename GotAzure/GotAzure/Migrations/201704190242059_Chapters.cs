namespace GotAzure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Chapters : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        DateChapter = c.DateTime(nullable: false),
                        SeasonChapter = c.Int(nullable: false),
                        EpisodeChapter = c.Int(nullable: false),
                        YearSeason = c.String(),
                        Description = c.String(),
                        URLImgChapter = c.String(),
                        URLVideo = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Chapters");
        }
    }
}
