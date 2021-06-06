namespace LuaChuot.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTable_BeLua : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.BeLuas");
            AddColumn("dbo.BeLuas", "HoBe", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.BeLuas", "NgaySinh", c => c.String());
            AlterColumn("dbo.BeLuas", "GioiTinh", c => c.String());
            AddPrimaryKey("dbo.BeLuas", "HoBe");
            DropColumn("dbo.BeLuas", "TenBe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BeLuas", "TenBe", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.BeLuas");
            AlterColumn("dbo.BeLuas", "GioiTinh", c => c.Int(nullable: false));
            AlterColumn("dbo.BeLuas", "NgaySinh", c => c.Int(nullable: false));
            DropColumn("dbo.BeLuas", "HoBe");
            AddPrimaryKey("dbo.BeLuas", "TenBe");
        }
    }
}
