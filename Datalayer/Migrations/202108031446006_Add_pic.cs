namespace Datalayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_pic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageComments", "ImageName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PageComments", "ImageName");
        }
    }
}
