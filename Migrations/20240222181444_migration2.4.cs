using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_HeatPipes_HeatPipesId",
                table: "CaseCooler");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_HeatPipesId",
                table: "CaseCooler");

            migrationBuilder.DropColumn(
                name: "HeatPipesId",
                table: "CaseCooler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeatPipesId",
                table: "CaseCooler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_HeatPipesId",
                table: "CaseCooler",
                column: "HeatPipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_HeatPipes_HeatPipesId",
                table: "CaseCooler",
                column: "HeatPipesId",
                principalTable: "Enum_HeatPipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
