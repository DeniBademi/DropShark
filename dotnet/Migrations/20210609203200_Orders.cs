using Microsoft.EntityFrameworkCore.Migrations;

namespace dotnet.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.CreateTable(
            //     name: "Orders",
            //     columns: table => new
            //     {
            //         Id = table.Column<int>(nullable: false)
            //             .Annotation("Sqlite:Autoincrement", true),
            //         UserName = table.Column<string>(nullable: true),
            //         sellerId = table.Column<int>(nullable: false),
            //         buyerId = table.Column<int>(nullable: false),
            //         addressLine = table.Column<string>(nullable: true),
            //         zipCode = table.Column<int>(nullable: false),
            //         isCompleted = table.Column<bool>(nullable: false)
            //     },
            //     constraints: table =>
            //     {
            //         table.PrimaryKey("PK_Orders", x => x.Id);
            //         table.ForeignKey(
            //             name: "FK_Orders_Users_buyerId",
            //             column: x => x.buyerId,
            //             principalTable: "Users",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //         table.ForeignKey(
            //             name: "FK_Orders_Users_sellerId",
            //             column: x => x.sellerId,
            //             principalTable: "Users",
            //             principalColumn: "Id",
            //             onDelete: ReferentialAction.Cascade);
            //     });

            // migrationBuilder.CreateIndex(
            //     name: "IX_Orders_buyerId",
            //     table: "Orders",
            //     column: "buyerId");

            // migrationBuilder.CreateIndex(
            //     name: "IX_Orders_sellerId",
            //     table: "Orders",
            //     column: "sellerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
