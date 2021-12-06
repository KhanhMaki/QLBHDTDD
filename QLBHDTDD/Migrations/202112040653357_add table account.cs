namespace QLBHDTDD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addtableaccount : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Accountodels", newName: "AccountModels");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.AccountModels", newName: "Accountodels");
        }
    }
}
