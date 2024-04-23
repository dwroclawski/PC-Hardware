using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration214 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Join_Case_WaterCoolingSlots_WaterCoolingSlots_WaterCoolingSlotId",
                table: "Join_Case_WaterCoolingSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WaterCoolingSlots",
                table: "WaterCoolingSlots");

            migrationBuilder.RenameTable(
                name: "WaterCoolingSlots",
                newName: "Eum_WaterCoolingSlots");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Eum_WaterCoolingSlots",
                table: "Eum_WaterCoolingSlots",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Eum_WaterCoolingSlots",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "1 x 120 mm (back)" },
                    { 3, "1 x 120 mm (front)" },
                    { 4, "1 x 120 mm (top)" },
                    { 5, "1 x 120 mm (under)" },
                    { 6, "1 x 120 mm (left)" },
                    { 7, "1 x 120 mm (right)" },
                    { 8, "1 x 120 mm" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Case_WaterCoolingSlots_Eum_WaterCoolingSlots_WaterCoolingSlotId",
                table: "Join_Case_WaterCoolingSlots",
                column: "WaterCoolingSlotId",
                principalTable: "Eum_WaterCoolingSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Join_Case_WaterCoolingSlots_Eum_WaterCoolingSlots_WaterCoolingSlotId",
                table: "Join_Case_WaterCoolingSlots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Eum_WaterCoolingSlots",
                table: "Eum_WaterCoolingSlots");

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Eum_WaterCoolingSlots",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.RenameTable(
                name: "Eum_WaterCoolingSlots",
                newName: "WaterCoolingSlots");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WaterCoolingSlots",
                table: "WaterCoolingSlots",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Case_WaterCoolingSlots_WaterCoolingSlots_WaterCoolingSlotId",
                table: "Join_Case_WaterCoolingSlots",
                column: "WaterCoolingSlotId",
                principalTable: "WaterCoolingSlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
