using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    public partial class vierson2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "customerid",
                table: "Orderh",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orderh_customerid",
                table: "Orderh",
                column: "customerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Orderh_Customer_customerid",
                table: "Orderh",
                column: "customerid",
                principalTable: "Customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orderh_Customer_customerid",
                table: "Orderh");

            migrationBuilder.DropIndex(
                name: "IX_Orderh_customerid",
                table: "Orderh");

            migrationBuilder.DropColumn(
                name: "customerid",
                table: "Orderh");
        }
    }
}
