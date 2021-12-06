namespace QLBHDTDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Abc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accountodels",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Accountodels");
        }
    }
}
