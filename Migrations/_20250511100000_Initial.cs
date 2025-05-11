using FluentMigrator;
using Smartstore.Core.Data.Migrations;
using Smartstore.Data.Migrations;

namespace Smartstore.ProductViewTracker.Migrations
{
    [MigrationVersion("2025-05-11 10:00:00", "ProductViewTracker: Initial")]
    public class _20250511100000_Initial : Migration
    {
        public override void Up()
        {
            const string tableName = "ProductView";

            if (!Schema.Table(tableName).Exists())
            {
                Create.Table(tableName)
                    .WithIdColumn()
                    .WithColumn("ProductId").AsInt32().NotNullable().Indexed("IX_ProductView_ProductId")
                    .WithColumn("ViewCount").AsInt32().NotNullable()
                    .WithColumn("LastViewedOn").AsDateTime2().NotNullable();
            }
        }

        public override void Down()
        {
            // opsiyonel: Create.Table(...) işlemini geri al
        }
    }
}