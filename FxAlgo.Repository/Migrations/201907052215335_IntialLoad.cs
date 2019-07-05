namespace FxAlgo.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialLoad : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AskPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Open = c.Decimal(nullable: false, precision: 18, scale: 2),
                        High = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Low = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Close = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.BidPrices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Open = c.Decimal(nullable: false, precision: 18, scale: 2),
                        High = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Low = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Close = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.BidPrices");
            DropTable("dbo.AskPrices");
        }
    }
}
