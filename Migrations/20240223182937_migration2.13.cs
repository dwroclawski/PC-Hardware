using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration213 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Enum_Fans_FanBaysId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Case_Enum_Fans_InstalledFansId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_Case_Enum_Fans_WaterCoolingSlotsId",
                table: "Case");

            migrationBuilder.DropForeignKey(
                name: "FK_CPU_CPUSocket_CPUSocketId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_CPUSocket_SocketId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Mount_MountId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_CPUSocket_CPUSocketId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_emoryConnectorType_MemoryConnectorTypeId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_emoryConnectorType_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_Case_FanBaysId",
                table: "Case");

            migrationBuilder.DropIndex(
                name: "IX_Case_InstalledFansId",
                table: "Case");

            migrationBuilder.DropIndex(
                name: "IX_Case_WaterCoolingSlotsId",
                table: "Case");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mount",
                table: "Mount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_emoryConnectorType",
                table: "Enum_emoryConnectorType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPUSocket",
                table: "CPUSocket");

            migrationBuilder.DropColumn(
                name: "FanBaysId",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "InstalledFansId",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "WaterCoolingSlotsId",
                table: "Case");

            migrationBuilder.RenameTable(
                name: "Mount",
                newName: "Enum_Mount");

            migrationBuilder.RenameTable(
                name: "Enum_emoryConnectorType",
                newName: "Enum_MemoryConnectorType");

            migrationBuilder.RenameTable(
                name: "CPUSocket",
                newName: "Enum_CPUSocket");

            migrationBuilder.RenameColumn(
                name: "SocketId",
                table: "CPUCooler",
                newName: "TDPId");

            migrationBuilder.RenameIndex(
                name: "IX_CPUCooler_SocketId",
                table: "CPUCooler",
                newName: "IX_CPUCooler_TDPId");

            migrationBuilder.AddColumn<int>(
                name: "MicroarchitectureId",
                table: "CPU",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_Mount",
                table: "Enum_Mount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_MemoryConnectorType",
                table: "Enum_MemoryConnectorType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_CPUSocket",
                table: "Enum_CPUSocket",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enum_Microarchitecture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Microarchitecture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_FanBays",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    FanBaysId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_FanBays", x => new { x.CaseId, x.FanBaysId });
                    table.ForeignKey(
                        name: "FK_Join_Case_FanBays_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_FanBays_Enum_Fans_FanBaysId",
                        column: x => x.FanBaysId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_InstalledFans",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    InstalledFansId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_InstalledFans", x => new { x.CaseId, x.InstalledFansId });
                    table.ForeignKey(
                        name: "FK_Join_Case_InstalledFans_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_InstalledFans_Enum_Fans_InstalledFansId",
                        column: x => x.InstalledFansId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPUCooler_CPUSocket",
                columns: table => new
                {
                    CPUCoolerId = table.Column<int>(type: "int", nullable: false),
                    CPUSocketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUCooler_CPUSocket", x => new { x.CPUCoolerId, x.CPUSocketId });
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_CPUSocket_CPUCooler_CPUCoolerId",
                        column: x => x.CPUCoolerId,
                        principalTable: "CPUCooler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_CPUSocket_Enum_CPUSocket_CPUSocketId",
                        column: x => x.CPUSocketId,
                        principalTable: "Enum_CPUSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterCoolingSlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WaterCoolingSlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Join_Case_WaterCoolingSlots",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    WaterCoolingSlotId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Case_WaterCoolingSlots", x => new { x.CaseId, x.WaterCoolingSlotId });
                    table.ForeignKey(
                        name: "FK_Join_Case_WaterCoolingSlots_Case_CaseId",
                        column: x => x.CaseId,
                        principalTable: "Case",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Case_WaterCoolingSlots_WaterCoolingSlots_WaterCoolingSlotId",
                        column: x => x.WaterCoolingSlotId,
                        principalTable: "WaterCoolingSlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enum_Microarchitecture",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "Comet Lake" },
                    { 3, "Aldet Lake" },
                    { 4, "Raprot Lake" },
                    { 5, "Zen 4" },
                    { 6, "Zen 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPU_MicroarchitectureId",
                table: "CPU",
                column: "MicroarchitectureId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_FanBays_FanBaysId",
                table: "Join_Case_FanBays",
                column: "FanBaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_InstalledFans_InstalledFansId",
                table: "Join_Case_InstalledFans",
                column: "InstalledFansId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Case_WaterCoolingSlots_WaterCoolingSlotId",
                table: "Join_Case_WaterCoolingSlots",
                column: "WaterCoolingSlotId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUCooler_CPUSocket_CPUSocketId",
                table: "Join_CPUCooler_CPUSocket",
                column: "CPUSocketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_CPUSocket_CPUSocketId",
                table: "CPU",
                column: "CPUSocketId",
                principalTable: "Enum_CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_Microarchitecture_MicroarchitectureId",
                table: "CPU",
                column: "MicroarchitectureId",
                principalTable: "Enum_Microarchitecture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Enum_Mount_MountId",
                table: "CPUCooler",
                column: "MountId",
                principalTable: "Enum_Mount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Enum_TDP_TDPId",
                table: "CPUCooler",
                column: "TDPId",
                principalTable: "Enum_TDP",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_Enum_CPUSocket_CPUSocketId",
                table: "Motherboard",
                column: "CPUSocketId",
                principalTable: "Enum_CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_Enum_MemoryConnectorType_MemoryConnectorTypeId",
                table: "Motherboard",
                column: "MemoryConnectorTypeId",
                principalTable: "Enum_MemoryConnectorType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_MemoryConnectorType_ConnectorTypeId",
                table: "RAM",
                column: "ConnectorTypeId",
                principalTable: "Enum_MemoryConnectorType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_CPUSocket_CPUSocketId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_Microarchitecture_MicroarchitectureId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_Mount_MountId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_TDP_TDPId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_CPUSocket_CPUSocketId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_MemoryConnectorType_MemoryConnectorTypeId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemoryConnectorType_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropTable(
                name: "Enum_Microarchitecture");

            migrationBuilder.DropTable(
                name: "Join_Case_FanBays");

            migrationBuilder.DropTable(
                name: "Join_Case_InstalledFans");

            migrationBuilder.DropTable(
                name: "Join_Case_WaterCoolingSlots");

            migrationBuilder.DropTable(
                name: "Join_CPUCooler_CPUSocket");

            migrationBuilder.DropTable(
                name: "WaterCoolingSlots");

            migrationBuilder.DropIndex(
                name: "IX_CPU_MicroarchitectureId",
                table: "CPU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_Mount",
                table: "Enum_Mount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_MemoryConnectorType",
                table: "Enum_MemoryConnectorType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_CPUSocket",
                table: "Enum_CPUSocket");

            migrationBuilder.DropColumn(
                name: "MicroarchitectureId",
                table: "CPU");

            migrationBuilder.RenameTable(
                name: "Enum_Mount",
                newName: "Mount");

            migrationBuilder.RenameTable(
                name: "Enum_MemoryConnectorType",
                newName: "Enum_emoryConnectorType");

            migrationBuilder.RenameTable(
                name: "Enum_CPUSocket",
                newName: "CPUSocket");

            migrationBuilder.RenameColumn(
                name: "TDPId",
                table: "CPUCooler",
                newName: "SocketId");

            migrationBuilder.RenameIndex(
                name: "IX_CPUCooler_TDPId",
                table: "CPUCooler",
                newName: "IX_CPUCooler_SocketId");

            migrationBuilder.AddColumn<int>(
                name: "FanBaysId",
                table: "Case",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstalledFansId",
                table: "Case",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WaterCoolingSlotsId",
                table: "Case",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mount",
                table: "Mount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_emoryConnectorType",
                table: "Enum_emoryConnectorType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPUSocket",
                table: "CPUSocket",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Case_FanBaysId",
                table: "Case",
                column: "FanBaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_InstalledFansId",
                table: "Case",
                column: "InstalledFansId");

            migrationBuilder.CreateIndex(
                name: "IX_Case_WaterCoolingSlotsId",
                table: "Case",
                column: "WaterCoolingSlotsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Enum_Fans_FanBaysId",
                table: "Case",
                column: "FanBaysId",
                principalTable: "Enum_Fans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Enum_Fans_InstalledFansId",
                table: "Case",
                column: "InstalledFansId",
                principalTable: "Enum_Fans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Enum_Fans_WaterCoolingSlotsId",
                table: "Case",
                column: "WaterCoolingSlotsId",
                principalTable: "Enum_Fans",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_CPUSocket_CPUSocketId",
                table: "CPU",
                column: "CPUSocketId",
                principalTable: "CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_CPUSocket_SocketId",
                table: "CPUCooler",
                column: "SocketId",
                principalTable: "CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Mount_MountId",
                table: "CPUCooler",
                column: "MountId",
                principalTable: "Mount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_CPUSocket_CPUSocketId",
                table: "Motherboard",
                column: "CPUSocketId",
                principalTable: "CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_Enum_emoryConnectorType_MemoryConnectorTypeId",
                table: "Motherboard",
                column: "MemoryConnectorTypeId",
                principalTable: "Enum_emoryConnectorType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_emoryConnectorType_ConnectorTypeId",
                table: "RAM",
                column: "ConnectorTypeId",
                principalTable: "Enum_emoryConnectorType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
