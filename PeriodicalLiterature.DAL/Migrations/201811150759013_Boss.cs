namespace PeriodicalLiterature.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Boss : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdminRegisters",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 10),
                        SecondName = c.String(nullable: false, maxLength: 10),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 20),
                        Boss_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bosses", t => t.Boss_Id)
                .Index(t => t.Boss_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AdminRegisters", "Boss_Id", "dbo.Bosses");
            DropIndex("dbo.AdminRegisters", new[] { "Boss_Id" });
            DropTable("dbo.AdminRegisters");
        }
    }
}
