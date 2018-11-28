namespace PeriodicalLiterature.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableContract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contracts", "Answer", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contracts", "Answer");
        }
    }
}
