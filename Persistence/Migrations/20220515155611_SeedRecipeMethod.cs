using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedRecipeMethod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "RecipeMethods",
                columns: new[] { "Id", "Description", "IsDeleted", "Optional", "Order", "RecipeId" },
                values: new object[] { "20c61f1a-19e1-4faf-a284-5db76fa03343", "Add lemon", false, false, 4, "2e12f26b-d06e-47f2-8d00-d5b316fc8abc" });

            migrationBuilder.InsertData(
                table: "RecipeMethods",
                columns: new[] { "Id", "Description", "IsDeleted", "Optional", "Order", "RecipeId" },
                values: new object[] { "d7e1be09-6ab2-4c44-b9c3-8864bf8a84d1", "Boil some water", false, false, 1, "2e12f26b-d06e-47f2-8d00-d5b316fc8abc" });

            migrationBuilder.InsertData(
                table: "RecipeMethods",
                columns: new[] { "Id", "Description", "IsDeleted", "Optional", "Order", "RecipeId" },
                values: new object[] { "f6435fa2-86eb-4db1-ac96-7579829b2ad9", "Steep the water in the tea", false, false, 2, "2e12f26b-d06e-47f2-8d00-d5b316fc8abc" });

            migrationBuilder.InsertData(
                table: "RecipeMethods",
                columns: new[] { "Id", "Description", "IsDeleted", "Optional", "Order", "RecipeId" },
                values: new object[] { "f852d95c-b682-4db0-958d-2a4c8796d770", "Pour tea in the cup", false, false, 3, "2e12f26b-d06e-47f2-8d00-d5b316fc8abc" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "10c2da38-cf19-44ef-a926-645a6efb4a90", "Coffee is a brewed drink prepared from roasted coffee beans, the seeds of berries from certain flowering plants in the Coffea genus. From the coffee fruit, the seeds are separated to produce a stable, raw product: unroasted green coffee.", false, "Coffee" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "5da4aad5-666f-46e5-adb3-7b787cd3ea0e", "Hot chocolate, also known as hot cocoa or drinking chocolate, is heated chocolate milk. Hot chocolate made with melted chocolate is sometimes called drinking chocolate, characterized by less sweetness and a thicker consistency.", false, "Hot chocolate" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "Description", "IsDeleted", "Title" },
                values: new object[] { "e9c7412a-5932-45f7-bac9-0338e753115f", "Hong Kong speciality is lemon tea - served in cafes and restaurants as regular black tea with several slices of fresh lemon, either hot or cold, with a pot of sugar to add to taste.", false, "Lemon Tea" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RecipeMethods_Recipes_RecipeId",
                table: "RecipeMethods");

            migrationBuilder.DropIndex(
                name: "IX_RecipeMethods_RecipeId",
                table: "RecipeMethods");

            migrationBuilder.DeleteData(
                table: "RecipeMethods",
                keyColumn: "Id",
                keyValue: "20c61f1a-19e1-4faf-a284-5db76fa03343");

            migrationBuilder.DeleteData(
                table: "RecipeMethods",
                keyColumn: "Id",
                keyValue: "d7e1be09-6ab2-4c44-b9c3-8864bf8a84d1");

            migrationBuilder.DeleteData(
                table: "RecipeMethods",
                keyColumn: "Id",
                keyValue: "f6435fa2-86eb-4db1-ac96-7579829b2ad9");

            migrationBuilder.DeleteData(
                table: "RecipeMethods",
                keyColumn: "Id",
                keyValue: "f852d95c-b682-4db0-958d-2a4c8796d770");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "10c2da38-cf19-44ef-a926-645a6efb4a90");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "5da4aad5-666f-46e5-adb3-7b787cd3ea0e");

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: "e9c7412a-5932-45f7-bac9-0338e753115f");

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
    }
}
