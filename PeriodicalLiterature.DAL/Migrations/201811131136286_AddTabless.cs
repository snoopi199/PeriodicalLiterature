namespace PeriodicalLiterature.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTabless : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        SecondName = c.String(),
                        Boss_Id = c.Guid(),
                        Boss_Id1 = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bosses", t => t.Boss_Id)
                .ForeignKey("dbo.Bosses", t => t.Boss_Id1)
                .Index(t => t.Boss_Id)
                .Index(t => t.Boss_Id1);
            
            CreateTable(
                "dbo.Contracts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PublisherId = c.Guid(nullable: false),
                        Status = c.String(),
                        TitleEdition = c.String(),
                        Category = c.String(),
                        Language = c.String(),
                        DescriptionEdition = c.String(),
                        Periodical = c.String(),
                        PriceForNewRelease = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PriceForOldRelease = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Admin_Id = c.Guid(),
                        Boss_Id = c.Guid(),
                        Boss_Id1 = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.PublisherId, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .ForeignKey("dbo.Bosses", t => t.Boss_Id)
                .ForeignKey("dbo.Bosses", t => t.Boss_Id1)
                .Index(t => t.PublisherId)
                .Index(t => t.Admin_Id)
                .Index(t => t.Boss_Id)
                .Index(t => t.Boss_Id1);
            
            CreateTable(
                "dbo.Editions",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Status = c.String(),
                        ContractId = c.Guid(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateOfIssue = c.DateTime(nullable: false),
                        Number = c.Byte(nullable: false),
                        DescriptionNumber = c.String(),
                        Pages = c.Int(nullable: false),
                        PictureId = c.Guid(nullable: false),
                        FileId = c.Guid(nullable: false),
                        Rating = c.Double(nullable: false),
                        Admin_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contracts", t => t.ContractId, cascadeDelete: true)
                .ForeignKey("dbo.Admins", t => t.Admin_Id)
                .Index(t => t.ContractId)
                .Index(t => t.Admin_Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Type = c.String(),
                        Date = c.DateTime(nullable: false),
                        Text = c.String(),
                        From = c.Guid(nullable: false),
                        Edition_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Editions", t => t.Edition_Id)
                .Index(t => t.Edition_Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PublisherName = c.String(),
                        Account = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlannedAccount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bosses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        SecondName = c.String(),
                        Account = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FrozenMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contracts", "Boss_Id1", "dbo.Bosses");
            DropForeignKey("dbo.Contracts", "Boss_Id", "dbo.Bosses");
            DropForeignKey("dbo.Admins", "Boss_Id1", "dbo.Bosses");
            DropForeignKey("dbo.Admins", "Boss_Id", "dbo.Bosses");
            DropForeignKey("dbo.Editions", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Contracts", "Admin_Id", "dbo.Admins");
            DropForeignKey("dbo.Contracts", "PublisherId", "dbo.Publishers");
            DropForeignKey("dbo.Editions", "ContractId", "dbo.Contracts");
            DropForeignKey("dbo.Comments", "Edition_Id", "dbo.Editions");
            DropIndex("dbo.Comments", new[] { "Edition_Id" });
            DropIndex("dbo.Editions", new[] { "Admin_Id" });
            DropIndex("dbo.Editions", new[] { "ContractId" });
            DropIndex("dbo.Contracts", new[] { "Boss_Id1" });
            DropIndex("dbo.Contracts", new[] { "Boss_Id" });
            DropIndex("dbo.Contracts", new[] { "Admin_Id" });
            DropIndex("dbo.Contracts", new[] { "PublisherId" });
            DropIndex("dbo.Admins", new[] { "Boss_Id1" });
            DropIndex("dbo.Admins", new[] { "Boss_Id" });
            DropTable("dbo.Bosses");
            DropTable("dbo.Publishers");
            DropTable("dbo.Comments");
            DropTable("dbo.Editions");
            DropTable("dbo.Contracts");
            DropTable("dbo.Admins");
        }
    }
}
