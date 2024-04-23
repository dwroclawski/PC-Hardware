using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ConnectorTypeId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CoolingTypeId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CycleLatencyId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemoryChannelId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemoryFrequencyId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemoryId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemoryTypeId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OverclockingId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RAMModulesId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VoltageId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Enum_CycleLatency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_CycleLatency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Overclocking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Overclocking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_RAMModules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_RAMModules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Voltage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Voltage", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Enum_CycleLatency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Cl2_5" },
                    { 3, "CL3" },
                    { 4, "CL4" },
                    { 5, "CL5" },
                    { 6, "CL6" },
                    { 7, "CL7" },
                    { 8, "CL8" },
                    { 9, "CL9" },
                    { 10, "Cl10" },
                    { 11, "CL11" },
                    { 12, "CL12" },
                    { 13, "CL13" },
                    { 14, "CL14" },
                    { 15, "CL15" },
                    { 16, "CL16" },
                    { 17, "CL17" },
                    { 18, "CL18" },
                    { 19, "CL19" },
                    { 20, "CL20" },
                    { 21, "CL21" },
                    { 22, "CL22" },
                    { 26, "CL36" },
                    { 28, "CL28" },
                    { 30, "CL30" },
                    { 32, "CL32" },
                    { 34, "CL34" },
                    { 38, "CL38" },
                    { 40, "CL40" },
                    { 42, "CL42" },
                    { 44, "CL44" },
                    { 46, "CL46" },
                    { 48, "CL48" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Overclocking",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "AMD EXPO" },
                    { 3, "Intel XMP" },
                    { 4, "Intel XMP 2.0" },
                    { 5, "Intel XMP 3.0" }
                });

            migrationBuilder.InsertData(
                table: "Enum_RAMModules",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" }
                });

            migrationBuilder.InsertData(
                table: "Enum_RAMModules",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Eight" });

            migrationBuilder.InsertData(
                table: "Enum_Voltage",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 110, "1.1 V" },
                    { 120, "1.2 V" },
                    { 125, "1.25 V" },
                    { 130, "1.3 V" },
                    { 135, "1.35 V" },
                    { 140, "1.4 V" },
                    { 145, "1.45 V" },
                    { 150, "1.5 V" },
                    { 155, "1.55 V" },
                    { 160, "1.6 V" },
                    { 165, "1.65 V" },
                    { 170, "1.7 V" },
                    { 175, "1.75 V" },
                    { 180, "1.8 V" },
                    { 190, "1.9 V" },
                    { 250, "2.5 V" },
                    { 260, "2.6 V" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RAM_ConnectorTypeId",
                table: "RAM",
                column: "ConnectorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_CoolingTypeId",
                table: "RAM",
                column: "CoolingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_CycleLatencyId",
                table: "RAM",
                column: "CycleLatencyId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_MemoryChannelId",
                table: "RAM",
                column: "MemoryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_MemoryFrequencyId",
                table: "RAM",
                column: "MemoryFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_MemoryId",
                table: "RAM",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_MemoryTypeId",
                table: "RAM",
                column: "MemoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_OverclockingId",
                table: "RAM",
                column: "OverclockingId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_RAMModulesId",
                table: "RAM",
                column: "RAMModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_VoltageId",
                table: "RAM",
                column: "VoltageId");

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_Capacity_MemoryId",
                table: "RAM",
                column: "MemoryId",
                principalTable: "Enum_Capacity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_CoolingType_CoolingTypeId",
                table: "RAM",
                column: "CoolingTypeId",
                principalTable: "Enum_CoolingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_CycleLatency_CycleLatencyId",
                table: "RAM",
                column: "CycleLatencyId",
                principalTable: "Enum_CycleLatency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_MemoryChannel_MemoryChannelId",
                table: "RAM",
                column: "MemoryChannelId",
                principalTable: "Enum_MemoryChannel",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_MemoryFrequency_MemoryFrequencyId",
                table: "RAM",
                column: "MemoryFrequencyId",
                principalTable: "Enum_MemoryFrequency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_MemorySlots_ConnectorTypeId",
                table: "RAM",
                column: "ConnectorTypeId",
                principalTable: "Enum_MemorySlots",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_MemoryType_MemoryTypeId",
                table: "RAM",
                column: "MemoryTypeId",
                principalTable: "Enum_MemoryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_Overclocking_OverclockingId",
                table: "RAM",
                column: "OverclockingId",
                principalTable: "Enum_Overclocking",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_RAMModules_RAMModulesId",
                table: "RAM",
                column: "RAMModulesId",
                principalTable: "Enum_RAMModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RAM_Enum_Voltage_VoltageId",
                table: "RAM",
                column: "VoltageId",
                principalTable: "Enum_Voltage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_Capacity_MemoryId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_CoolingType_CoolingTypeId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_CycleLatency_CycleLatencyId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemoryChannel_MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemoryFrequency_MemoryFrequencyId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemorySlots_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemoryType_MemoryTypeId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_Overclocking_OverclockingId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_RAMModules_RAMModulesId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_Voltage_VoltageId",
                table: "RAM");

            migrationBuilder.DropTable(
                name: "Enum_CycleLatency");

            migrationBuilder.DropTable(
                name: "Enum_Overclocking");

            migrationBuilder.DropTable(
                name: "Enum_RAMModules");

            migrationBuilder.DropTable(
                name: "Enum_Voltage");

            migrationBuilder.DropIndex(
                name: "IX_RAM_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_CoolingTypeId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_CycleLatencyId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_MemoryFrequencyId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_MemoryId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_MemoryTypeId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_OverclockingId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_RAMModulesId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_VoltageId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "CoolingTypeId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "CycleLatencyId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "MemoryFrequencyId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "MemoryId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "MemoryTypeId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "OverclockingId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "RAMModulesId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "VoltageId",
                table: "RAM");
        }
    }
}
