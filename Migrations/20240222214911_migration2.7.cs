using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration27 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Enum_Material_SidePanelId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_MTBF_MTBFId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_MTBF_MTBFId",
                table: "CPUCooler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MTBF",
                table: "MTBF");

            migrationBuilder.RenameTable(
                name: "MTBF",
                newName: "Enum_MTBF");

            migrationBuilder.RenameColumn(
                name: "SidePanelId",
                table: "Case",
                newName: "SidePanelMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_Case_SidePanelId",
                table: "Case",
                newName: "IX_Case_SidePanelMaterialId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_MTBF",
                table: "Enum_MTBF",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enum_CellType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_CellType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Encryption",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Encryption", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Heatsink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Heatsink", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Key",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Key", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ReadSpeed = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    WriteSpeed = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    RandomRead = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    RandomWrite = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    TBW = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FormFactorId = table.Column<int>(type: "int", nullable: false),
                    InterfaceId = table.Column<int>(type: "int", nullable: false),
                    CapacityId = table.Column<int>(type: "int", nullable: false),
                    CacheId = table.Column<int>(type: "int", nullable: false),
                    MTBFId = table.Column<int>(type: "int", nullable: false),
                    CellTypeId = table.Column<int>(type: "int", nullable: false),
                    HeatsinkId = table.Column<int>(type: "int", nullable: false),
                    EncryptionId = table.Column<int>(type: "int", nullable: false),
                    KeyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Cache_CacheId",
                        column: x => x.CacheId,
                        principalTable: "Enum_Cache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Capacity_CapacityId",
                        column: x => x.CapacityId,
                        principalTable: "Enum_Capacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_CellType_CellTypeId",
                        column: x => x.CellTypeId,
                        principalTable: "Enum_CellType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Encryption_EncryptionId",
                        column: x => x.EncryptionId,
                        principalTable: "Enum_Encryption",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_FormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Heatsink_HeatsinkId",
                        column: x => x.HeatsinkId,
                        principalTable: "Enum_Heatsink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_InterfaceTypes_InterfaceId",
                        column: x => x.InterfaceId,
                        principalTable: "Enum_InterfaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Key_KeyId",
                        column: x => x.KeyId,
                        principalTable: "Enum_Key",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_MTBF_MTBFId",
                        column: x => x.MTBFId,
                        principalTable: "Enum_MTBF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SSD_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Enum_CellType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "MLC" },
                    { 3, "QLC" },
                    { 4, "SLC" },
                    { 5, "TLC" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Encryption",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Yes" },
                    { 3, "No" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Heatsink",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Yes" },
                    { 3, "No" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Key",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "A" },
                    { 3, "B" },
                    { 4, "C" },
                    { 5, "D" },
                    { 6, "E" },
                    { 7, "F" },
                    { 8, "G" },
                    { 9, "H" },
                    { 10, "I" },
                    { 11, "J" },
                    { 12, "K" },
                    { 13, "L" },
                    { 14, "M" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SSD_CacheId",
                table: "SSD",
                column: "CacheId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_CapacityId",
                table: "SSD",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_CellTypeId",
                table: "SSD",
                column: "CellTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_EncryptionId",
                table: "SSD",
                column: "EncryptionId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_FormFactorId",
                table: "SSD",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_HeatsinkId",
                table: "SSD",
                column: "HeatsinkId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_InterfaceId",
                table: "SSD",
                column: "InterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_KeyId",
                table: "SSD",
                column: "KeyId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_MTBFId",
                table: "SSD",
                column: "MTBFId");

            migrationBuilder.CreateIndex(
                name: "IX_SSD_ProducerID",
                table: "SSD",
                column: "ProducerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Enum_Material_SidePanelMaterialId",
                table: "Case",
                column: "SidePanelMaterialId",
                principalTable: "Enum_Material",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_MTBF_MTBFId",
                table: "CaseCooler",
                column: "MTBFId",
                principalTable: "Enum_MTBF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Enum_MTBF_MTBFId",
                table: "CPUCooler",
                column: "MTBFId",
                principalTable: "Enum_MTBF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Enum_Material_SidePanelMaterialId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_MTBF_MTBFId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_MTBF_MTBFId",
                table: "CPUCooler");

            migrationBuilder.DropTable(
                name: "SSD");

            migrationBuilder.DropTable(
                name: "Enum_CellType");

            migrationBuilder.DropTable(
                name: "Enum_Encryption");

            migrationBuilder.DropTable(
                name: "Enum_Heatsink");

            migrationBuilder.DropTable(
                name: "Enum_Key");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_MTBF",
                table: "Enum_MTBF");

            migrationBuilder.RenameTable(
                name: "Enum_MTBF",
                newName: "MTBF");

            migrationBuilder.RenameColumn(
                name: "SidePanelMaterialId",
                table: "Case",
                newName: "SidePanelId");

            migrationBuilder.RenameIndex(
                name: "IX_Case_SidePanelMaterialId",
                table: "Case",
                newName: "IX_Case_SidePanelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MTBF",
                table: "MTBF",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Enum_Material_SidePanelId",
                table: "Case",
                column: "SidePanelId",
                principalTable: "Enum_Material",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_MTBF_MTBFId",
                table: "CaseCooler",
                column: "MTBFId",
                principalTable: "MTBF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_MTBF_MTBFId",
                table: "CPUCooler",
                column: "MTBFId",
                principalTable: "MTBF",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
