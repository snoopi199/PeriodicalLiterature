namespace PeriodicalLiterature.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableContract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contracts", "FileId", c => c.Guid(nullable: false));
            AddColumn("dbo.Contracts", "ContractId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contracts", "ContractId");
            DropColumn("dbo.Contracts", "FileId");
        }
    }
}
