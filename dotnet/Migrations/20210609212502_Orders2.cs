using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet.Migrations
{
    public partial class Orders2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropColumn(
            //     name: "UserName",
            //     table: "Orders");

            // migrationBuilder.AddColumn<int>(
            //     name: "productId",
            //     table: "Orders",
            //     nullable: false,
            //     defaultValue: 0);

            // migrationBuilder.CreateIndex(
            //     name: "IX_Orders_productId",
            //     table: "Orders",
            //     column: "productId");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Orders_Products_productId",
            //     table: "Orders",
            //     column: "productId",
            //     principalTable: "Products",
            //     principalColumn: "Id",
            //     onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_productId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_productId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "productId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Orders",
                type: "TEXT",
                nullable: true);
        }
    }
}
