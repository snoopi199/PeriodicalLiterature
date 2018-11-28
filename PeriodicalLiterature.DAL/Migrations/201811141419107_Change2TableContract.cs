namespace PeriodicalLiterature.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change2TableContract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contracts", "CoverId", c => c.Guid(nullable: false));
            DropColumn("dbo.Contracts", "ContractId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contracts", "ContractId", c => c.Guid(nullable: false));
            DropColumn("dbo.Contracts", "CoverId");
        }
    }
}
