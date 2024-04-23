using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enum_Buttons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Buttons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_CaseType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_CaseType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Drivebay",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Drivebay", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SidePanelId = table.Column<int>(type: "int", nullable: true),
                    InstalledFansId = table.Column<int>(type: "int", nullable: true),
                    FanBaysId = table.Column<int>(type: "int", nullable: true),
                    WaterCoolingSlotsId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    PSUId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Case_Enum_CaseType_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Enum_CaseType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Case_Enum_Fans_FanBaysId",
                        column: x => x.FanBaysId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Case_Enum_Fans_InstalledFansId",
                        column: x => x.InstalledFansId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Case_Enum_Fans_WaterCoolingSlotsId",
                        column: x => x.WaterCoolingSlotsId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Case_Enum_Material_SidePanelId",
                        column: x => x.SidePanelId,
                        principalTable: "Enum_Material",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Case_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Case_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_Buttons",
                columns: table => new
                {
                    ButtonsId = table.Column<int>(type: "int", nullable: false),
                    CaseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_Buttons", x => new { x.ButtonsId, x.CaseId });
                    table.ForeignKey(
                        name: "FK_Join_Case_Buttons_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_Buttons_Enum_Buttons_ButtonsId",
                        column: x => x.ButtonsId,
                        principalTable: "Enum_Buttons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_DriveBay",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    DriveBayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_DriveBay", x => new { x.CaseId, x.DriveBayId });
                    table.ForeignKey(
                        name: "FK_Join_Case_DriveBay_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_DriveBay_Enum_Drivebay_DriveBayId",
                        column: x => x.DriveBayId,
                        principalTable: "Enum_Drivebay",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_FormFactor",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    FormFactorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_FormFactor", x => new { x.CaseId, x.FormFactorId });
                    table.ForeignKey(
                        name: "FK_Join_Case_FormFactor_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_FormFactor_Enum_FormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_Material",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_Material", x => new { x.CaseId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_Join_Case_Material_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_Material_Enum_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Enum_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_Port",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    PortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_Port", x => new { x.CaseId, x.PortId });
                    table.ForeignKey(
                        name: "FK_Join_Case_Port_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_Port_Enum_ExternalConnector_PortId",
                        column: x => x.PortId,
                        principalTable: "Enum_ExternalConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_PSUMount",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    PSUMountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_PSUMount", x => new { x.CaseId, x.PSUMountId });
                    table.ForeignKey(
                        name: "FK_Join_Case_PSUMount_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_PSUMount_Enum_FormFactor_PSUMountId",
                        column: x => x.PSUMountId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enum_Buttons",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Power" },
                    { 3, "Reset" }
                });

            migrationBuilder.InsertData(
                table: "Enum_CaseType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Full Tower" },
                    { 3, "Mid Tower" },
                    { 4, "Mini Tower" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Drivebay",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 125, "1 x 2.5''" },
                    { 135, "1 x 3.5''" },
                    { 225, "2 x 2.5''" },
                    { 235, "2 x 3.5''" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Material",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Glass" },
                    { 8, "Mesh" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Case_FanBaysId",
                table: "Case",
                column: "FanBaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_InstalledFansId",
                table: "Case",
                column: "InstalledFansId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_ProducerID",
                table: "Case",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_Case_PSUId",
                table: "Case",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_SidePanelId",
                table: "Case",
                column: "SidePanelId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_TypeId",
                table: "Case",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_WaterCoolingSlotsId",
                table: "Case",
                column: "WaterCoolingSlotsId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_Buttons_CaseId",
                table: "Join_Case_Buttons",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_DriveBay_DriveBayId",
                table: "Join_Case_DriveBay",
                column: "DriveBayId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_FormFactor_FormFactorId",
                table: "Join_Case_FormFactor",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_Material_MaterialId",
                table: "Join_Case_Material",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_Port_PortId",
                table: "Join_Case_Port",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_PSUMount_PSUMountId",
                table: "Join_Case_PSUMount",
                column: "PSUMountId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Join_Case_Buttons");

            migrationBuilder.DropTable(
                name: "Join_Case_DriveBay");

            migrationBuilder.DropTable(
                name: "Join_Case_FormFactor");

            migrationBuilder.DropTable(
                name: "Join_Case_Material");

            migrationBuilder.DropTable(
                name: "Join_Case_Port");

            migrationBuilder.DropTable(
                name: "Join_Case_PSUMount");

            migrationBuilder.DropTable(
                name: "Enum_Buttons");

            migrationBuilder.DropTable(
                name: "Enum_Drivebay");

            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "Enum_CaseType");

            migrationBuilder.DeleteData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
