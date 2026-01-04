using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MCA.Data.Migrations
{
    /// <inheritdoc />
    public partial class TableForContracts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MasterContracts",
                columns: table => new
                {
                    ContractID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchantName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MerchantBusinessName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Syndicate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ISO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FundsAdvance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterContracts", x => x.ContractID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MasterContracts");
        }
    }
}
