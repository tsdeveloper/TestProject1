using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Redemptions",
                columns: table => new
                {
                    RedemptionId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LotteryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LotteryId = table.Column<long>(type: "bigint", nullable: true),
                    UserCode = table.Column<long>(type: "bigint", nullable: true),
                    Draw = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Game = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContestNumber = table.Column<long>(type: "bigint", nullable: true),
                    ContestNumberRef = table.Column<long>(type: "bigint", nullable: true),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupCode = table.Column<long>(type: "bigint", nullable: true),
                    AwardWinningGames = table.Column<int>(type: "int", nullable: false),
                    QuotaQuantity = table.Column<long>(type: "bigint", nullable: true),
                    Jackpot = table.Column<decimal>(type: "money", nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteOrigin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentAccountDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HonorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgencyDigit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedemptionType = table.Column<string>(type: "varchar(100)", nullable: false),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    Fee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteCode = table.Column<long>(type: "bigint", nullable: true),
                    IsAdministrator = table.Column<bool>(type: "bit", nullable: true),
                    JackpotLimit = table.Column<decimal>(type: "money", nullable: false),
                    RequestTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Redemptions", x => x.RedemptionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Redemptions_RedemptionId",
                table: "Redemptions",
                column: "RedemptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Redemptions");
        }
    }
}
