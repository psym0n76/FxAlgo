namespace FxAlgo.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedingData : DbMigration
    {
        public override void Up()
        {

            Sql(@"

            INSERT INTO [dbo].[AskPrices] ([DateTime], [Open], [High], [Low], [Close], [DateStamp]) VALUES (N'2019-07-06 00:00:00', CAST(1.45 AS Decimal(18, 2)), CAST(1.49 AS Decimal(18, 2)), CAST(1.44 AS Decimal(18, 2)), CAST(1.49 AS Decimal(18, 2)), N'2019-07-06 00:00:00')
            INSERT INTO [dbo].[AskPrices] ([DateTime], [Open], [High], [Low], [Close], [DateStamp]) VALUES (N'2019-07-06 00:00:01', CAST(1.49 AS Decimal(18, 2)), CAST(1.49 AS Decimal(18, 2)), CAST(1.41 AS Decimal(18, 2)), CAST(1.42 AS Decimal(18, 2)), N'2019-07-06 00:00:00')


            INSERT INTO [dbo].[BidPrices] ([DateTime], [Open], [High], [Low], [Close], [DateStamp]) VALUES (N'2019-07-06 00:00:00', CAST(1.44 AS Decimal(18, 2)), CAST(1.48 AS Decimal(18, 2)), CAST(1.43 AS Decimal(18, 2)), CAST(1.48 AS Decimal(18, 2)), N'2019-07-06 00:00:00')
            INSERT INTO [dbo].[BidPrices] ([DateTime], [Open], [High], [Low], [Close], [DateStamp]) VALUES (N'2019-07-06 00:00:01', CAST(1.48 AS Decimal(18, 2)), CAST(1.48 AS Decimal(18, 2)), CAST(1.40 AS Decimal(18, 2)), CAST(1.41 AS Decimal(18, 2)), N'2019-07-06 00:00:00')



            ");

        }

        public override void Down()
        {
        }
    }
}
