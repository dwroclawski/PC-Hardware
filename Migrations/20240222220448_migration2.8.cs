using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Join_Case_Color",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_Color", x => new { x.CaseId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_Join_Case_Color_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CaseCooler_Color",
                columns: table => new
                {
                    CaseCoolerId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CaseCooler_Color", x => new { x.CaseCoolerId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_Join_CaseCooler_Color_CaseCooler_CaseCoolerId",
                        column: x => x.CaseCoolerId,
                        principalTable: "CaseCooler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CaseCooler_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPUCooler_Color",
                columns: table => new
                {
                    CPUCoolerId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUCooler_Color", x => new { x.CPUCoolerId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_Color_CPUCooler_CPUCoolerId",
                        column: x => x.CPUCoolerId,
                        principalTable: "CPUCooler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_RAM_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_RAM_Color", x => new { x.ColorId, x.RAMId });
                    table.ForeignKey(
                        name: "FK_Join_RAM_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_RAM_Color_RAM_RAMId",
                        column: x => x.RAMId,
                        principalTable: "RAM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_SSD_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SSDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_SSD_Color", x => new { x.ColorId, x.SSDId });
                    table.ForeignKey(
                        name: "FK_Join_SSD_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_SSD_Color_SSD_SSDId",
                        column: x => x.SSDId,
                        principalTable: "SSD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_Color_ColorId",
                table: "Join_Case_Color",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CaseCooler_Color_ColorId",
                table: "Join_CaseCooler_Color",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUCooler_Color_ColorId",
                table: "Join_CPUCooler_Color",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_RAM_Color_RAMId",
                table: "Join_RAM_Color",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_SSD_Color_SSDId",
                table: "Join_SSD_Color",
                column: "SSDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Join_Case_Color");

            migrationBuilder.DropTable(
                name: "Join_CaseCooler_Color");

            migrationBuilder.DropTable(
                name: "Join_CPUCooler_Color");

            migrationBuilder.DropTable(
                name: "Join_RAM_Color");

            migrationBuilder.DropTable(
                name: "Join_SSD_Color");
        }
    }
}
