using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeMethods_Recipes_RecipeId",
                table: "RecipeMethods");

            migrationBuilder.DropIndex(
                name: "IX_RecipeMethods_RecipeId",
                table: "RecipeMethods");

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "2e12f26b-d06e-47f2-8d00-d5b316fc8abc", "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain flowering plants in the Coffea genus. From the coffee fruit, the seeds are separated to produce a stable, raw product: unroasted green coffee.", false, "Coffee" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "36b0775b-e598-4e69-afd4-2e3a8e127eb7", "Hong Kong speciality is lemon tea - served in cafes and restaurants as regular black tea with several slices of fresh lemon, either hot or cold, with a pot of sugar to add to taste.", false, "Lemon Tea" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "f9a89c0d-2760-4e31-a42a-841a0da68be5", "Hot chocolate, also known as hot cocoa or drinking chocolate, is heated chocolate milk. Hot chocolate made with melted chocolate is sometimes called drinking chocolate, characterized by less sweetness and a thicker consistency.", false, "Hot chocolate" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "2e12f26b-d06e-47f2-8d00-d5b316fc8abc");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "36b0775b-e598-4e69-afd4-2e3a8e127eb7");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "f9a89c0d-2760-4e31-a42a-841a0da68be5");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeMethods_RecipeId",
                table: "RecipeMethods",
                column: "RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeMethods_Recipes_RecipeId",
                table: "RecipeMethods",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
