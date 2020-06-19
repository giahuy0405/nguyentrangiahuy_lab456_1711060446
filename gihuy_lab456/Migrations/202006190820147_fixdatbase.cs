namespace gihuy_lab456.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixdatbase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Attendances", "FolloweeId", c => c.String());
            AddColumn("dbo.Attendances", "FollowerId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Attendances", "FollowerId");
            DropColumn("dbo.Attendances", "FolloweeId");
        }
    }
}
