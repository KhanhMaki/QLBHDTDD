namespace QLBHDTDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Role : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Roleid = c.String(nullable: false, maxLength: 128),
                        Rolename = c.String(),
                        Roles_Roleid = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Roleid)
                .ForeignKey("dbo.Roles", t => t.Roles_Roleid)
                .Index(t => t.Roles_Roleid);
            
            AddColumn("dbo.AccountModels", "Roleid", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Roles", "Roles_Roleid", "dbo.Roles");
            DropIndex("dbo.Roles", new[] { "Roles_Roleid" });
            DropColumn("dbo.AccountModels", "Roleid");
            DropTable("dbo.Roles");
        }
    }
}
