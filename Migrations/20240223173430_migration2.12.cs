using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration212 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_Connectors_ConnectorsId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_CPUSocket_CPUSocketId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_Connectors_ConnectorsId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_CPUSocket_SocketId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_Mount_MountId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_Enum_InterfaceTypes_InterfaceTypeId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_HDD_Enum_InterfaceTypes_InterfaceId",
                table: "HDD");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Case_Port_Enum_ExternalConnector_PortId",
                table: "Join_Case_Port");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_GPU_Port_Enum_Ports_PortId",
                table: "Join_GPU_Port");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Motherboard_ExternalConnector_Enum_ExternalConnector_ExternalConnectorId",
                table: "Join_Motherboard_ExternalConnector");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Motherboard_InternalConnector_Enum_InternalConnector_InternalConnectorId",
                table: "Join_Motherboard_InternalConnector");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_CPUSocket_CPUSocketId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemoryChannel_MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_MemorySlots_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_RAMModules_RAMModulesId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_Enum_InterfaceTypes_InterfaceId",
                table: "SSD");

            migrationBuilder.DropTable(
                name: "Enum_ExternalConnector");

            migrationBuilder.DropTable(
                name: "Enum_InterfaceTypes");

            migrationBuilder.DropTable(
                name: "Enum_InternalConnector");

            migrationBuilder.DropTable(
                name: "Enum_Ports");

            migrationBuilder.DropTable(
                name: "Enum_RAMModules");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_MemorySlots");

            migrationBuilder.DropTable(
                name: "Enum_MemorySlots");

            migrationBuilder.DropIndex(
                name: "IX_RAM_MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_RAM_RAMModulesId",
                table: "RAM");

            migrationBuilder.DropIndex(
                name: "IX_CPUCooler_ConnectorsId",
                table: "CPUCooler");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_ConnectorsId",
                table: "CaseCooler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_Mount",
                table: "Enum_Mount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_CPUSocket",
                table: "Enum_CPUSocket");

            migrationBuilder.DropColumn(
                name: "MemoryChannelId",
                table: "RAM");

            migrationBuilder.DropColumn(
                name: "ConnectorsId",
                table: "CPUCooler");

            migrationBuilder.DropColumn(
                name: "ConnectorsId",
                table: "CaseCooler");

            migrationBuilder.RenameTable(
                name: "Enum_Mount",
                newName: "Mount");

            migrationBuilder.RenameTable(
                name: "Enum_CPUSocket",
                newName: "CPUSocket");

            migrationBuilder.RenameColumn(
                name: "RAMModulesId",
                table: "RAM",
                newName: "Modules");

            migrationBuilder.AddColumn<int>(
                name: "MemoryConnectorTypeId",
                table: "Motherboard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MemorySlots",
                table: "Motherboard",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InterfaceTypeId",
                table: "GPU",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "MemoryChannelId",
                table: "CPU",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mount",
                table: "Mount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CPUSocket",
                table: "CPUSocket",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enum_emoryConnectorType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_emoryConnectorType", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PCIe 3.0 x16");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "PCIe 4.0 x16");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "PCIe 3.0 x8");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "PCIe 4.0 x8");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "PCI-E 5.0 12+4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "PCI-E 5.0 12+4 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "USB 2.0 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "USB 2.0 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "USB 2.0 x 3");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "USB 2.0 x 4");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "USB 3.2 x 1");

            migrationBuilder.InsertData(
                table: "Enum_Connectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 13, "USB 3.2 x 2" },
                    { 14, "USB 3.2 x 3" },
                    { 15, "USB 3.2 x 4" },
                    { 16, "USB 3.2 Type-C x 1" },
                    { 17, "USB 3.2 Type-C x 2" },
                    { 18, "Microphone x 1" },
                    { 19, "Headphone x 1" },
                    { 20, "Microphone/Headphone x 1" },
                    { 21, "VGA x 1" },
                    { 22, "DVI x 1" },
                    { 23, "RJ-45 x 1" },
                    { 24, "SATA III x 2" },
                    { 25, "SATA III x 4" },
                    { 26, "SATA III x 6" },
                    { 27, "SATA III x 7" },
                    { 28, "SATA III x 8" },
                    { 29, "SATA III x 10" },
                    { 30, "HDMI x 1" },
                    { 31, "HDMI 2.1 x 1" },
                    { 32, "HDMI 2.1 x 2" },
                    { 33, "HDMI 2.1a x 1" },
                    { 34, "HDMI 2.1a x 2" },
                    { 35, "DisplayPort x 1" },
                    { 36, "DisplayPort 1.4 x 1" },
                    { 37, "DisplayPort 1.4 x 2" },
                    { 38, "DisplayPort 1.4 x 3" },
                    { 39, "DisplayPort 1.4 x 4" },
                    { 40, "DisplayPort 1.4a x 1" },
                    { 41, "DisplayPort 1.4a x 2" },
                    { 42, "DisplayPort 1.4a x 3" },
                    { 43, "DisplayPort 1.4a x 4" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Connectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 44, "DisplayPort 2.0 x 1" },
                    { 45, "DisplayPort 2.0 x 2" },
                    { 46, "DisplayPort 2.0 x 3" },
                    { 47, "DisplayPort 2.0 x 4" },
                    { 48, "DisplayPort 2.1 x 1" },
                    { 49, "DisplayPort 2.1 x 2" },
                    { 50, "DisplayPort 2.1 x 3" },
                    { 51, "DisplayPort 2.1 x 4" },
                    { 52, "CPU 4+4 x 1" },
                    { 53, "CPU 4+4 x 2" },
                    { 54, "CPU 4+4 x 3" },
                    { 55, "CPU 8 x 1" },
                    { 56, "CPU 8 x 2" },
                    { 57, "CPU 4 x 1" },
                    { 58, "EPS12V 20+4 x 1" },
                    { 59, "EPS12V 4+4 x 1" },
                    { 60, "EPS12V 4+4 x 2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_emoryConnectorType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "DIMM" },
                    { 3, "U-DIMM" },
                    { 4, "SO-DIMM" },
                    { 5, "RDIMM" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_MemoryConnectorTypeId",
                table: "Motherboard",
                column: "MemoryConnectorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_ConnectorId",
                table: "CPUCooler",
                column: "ConnectorId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_MemoryChannelId",
                table: "CPU",
                column: "MemoryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_ConnectorId",
                table: "CaseCooler",
                column: "ConnectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_Connectors_ConnectorId",
                table: "CaseCooler",
                column: "ConnectorId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_CPUSocket_CPUSocketId",
                table: "CPU",
                column: "CPUSocketId",
                principalTable: "CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_MemoryChannel_MemoryChannelId",
                table: "CPU",
                column: "MemoryChannelId",
                principalTable: "Enum_MemoryChannel",
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
                name: "FK_CPUCooler_Enum_Connectors_ConnectorId",
                table: "CPUCooler",
                column: "ConnectorId",
                principalTable: "Enum_Connectors",
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
                name: "FK_GPU_Enum_Connectors_InterfaceTypeId",
                table: "GPU",
                column: "InterfaceTypeId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_HDD_Enum_Connectors_InterfaceId",
                table: "HDD",
                column: "InterfaceId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Case_Port_Enum_Connectors_PortId",
                table: "Join_Case_Port",
                column: "PortId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_GPU_Port_Enum_Connectors_PortId",
                table: "Join_GPU_Port",
                column: "PortId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Motherboard_ExternalConnector_Enum_Connectors_ExternalConnectorId",
                table: "Join_Motherboard_ExternalConnector",
                column: "ExternalConnectorId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Motherboard_InternalConnector_Enum_Connectors_InternalConnectorId",
                table: "Join_Motherboard_InternalConnector",
                column: "InternalConnectorId",
                principalTable: "Enum_Connectors",
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

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_Enum_Connectors_InterfaceId",
                table: "SSD",
                column: "InterfaceId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_Connectors_ConnectorId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPU_CPUSocket_CPUSocketId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_MemoryChannel_MemoryChannelId",
                table: "CPU");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_CPUSocket_SocketId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Enum_Connectors_ConnectorId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CPUCooler_Mount_MountId",
                table: "CPUCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_GPU_Enum_Connectors_InterfaceTypeId",
                table: "GPU");

            migrationBuilder.DropForeignKey(
                name: "FK_HDD_Enum_Connectors_InterfaceId",
                table: "HDD");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Case_Port_Enum_Connectors_PortId",
                table: "Join_Case_Port");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_GPU_Port_Enum_Connectors_PortId",
                table: "Join_GPU_Port");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Motherboard_ExternalConnector_Enum_Connectors_ExternalConnectorId",
                table: "Join_Motherboard_ExternalConnector");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_Motherboard_InternalConnector_Enum_Connectors_InternalConnectorId",
                table: "Join_Motherboard_InternalConnector");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_CPUSocket_CPUSocketId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_emoryConnectorType_MemoryConnectorTypeId",
                table: "Motherboard");

            migrationBuilder.DropForeignKey(
                name: "FK_RAM_Enum_emoryConnectorType_ConnectorTypeId",
                table: "RAM");

            migrationBuilder.DropForeignKey(
                name: "FK_SSD_Enum_Connectors_InterfaceId",
                table: "SSD");

            migrationBuilder.DropTable(
                name: "Enum_emoryConnectorType");

            migrationBuilder.DropIndex(
                name: "IX_Motherboard_MemoryConnectorTypeId",
                table: "Motherboard");

            migrationBuilder.DropIndex(
                name: "IX_CPUCooler_ConnectorId",
                table: "CPUCooler");

            migrationBuilder.DropIndex(
                name: "IX_CPU_MemoryChannelId",
                table: "CPU");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_ConnectorId",
                table: "CaseCooler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mount",
                table: "Mount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CPUSocket",
                table: "CPUSocket");

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DropColumn(
                name: "MemoryConnectorTypeId",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "MemorySlots",
                table: "Motherboard");

            migrationBuilder.DropColumn(
                name: "MemoryChannelId",
                table: "CPU");

            migrationBuilder.RenameTable(
                name: "Mount",
                newName: "Enum_Mount");

            migrationBuilder.RenameTable(
                name: "CPUSocket",
                newName: "Enum_CPUSocket");

            migrationBuilder.RenameColumn(
                name: "Modules",
                table: "RAM",
                newName: "RAMModulesId");

            migrationBuilder.AddColumn<int>(
                name: "MemoryChannelId",
                table: "RAM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "InterfaceTypeId",
                table: "GPU",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConnectorsId",
                table: "CPUCooler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ConnectorsId",
                table: "CaseCooler",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_Mount",
                table: "Enum_Mount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_CPUSocket",
                table: "Enum_CPUSocket",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enum_ExternalConnector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_ExternalConnector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_InterfaceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_InterfaceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_InternalConnector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_InternalConnector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_MemorySlots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemorySlots", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Ports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Ports", x => x.Id);
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
                name: "Join_Motherboard_MemorySlots",
                columns: table => new
                {
                    MemorySlotsId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_MemorySlots", x => new { x.MemorySlotsId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_MemorySlots_Enum_MemorySlots_MemorySlotsId",
                        column: x => x.MemorySlotsId,
                        principalTable: "Enum_MemorySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_MemorySlots_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "CPU 4+4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "CPU 4+4 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "CPU 4+4 x 3");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "CPU 8 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "CPU 8 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "CPU 4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "EPS12V 20+4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "EPS12V 4+4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "EPS12V 4+4 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "PCI-E 5.0 12+4 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "PCI-E 5.0 12+4 x 2");

            migrationBuilder.InsertData(
                table: "Enum_ExternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "USB 2.0 x 1" },
                    { 3, "USB 2.0 x 2" },
                    { 4, "USB 2.0 x 3" },
                    { 5, "USB 2.0 x 4" },
                    { 6, "USB 3.2 x 1" },
                    { 7, "USB 3.2 x 2" },
                    { 8, "USB 3.2 x 3" },
                    { 9, "USB 3.2 x 4" },
                    { 10, "USB 3.2 Type-C x 1" },
                    { 11, "USB 3.2 Type-C x 2" },
                    { 12, "Microphone x 1" },
                    { 13, "Headphone x 1" },
                    { 14, "Microphone/Headphone x 1" },
                    { 15, "HDMI x 1" },
                    { 16, "DisplayPort x 1" },
                    { 17, "VGA x 1" },
                    { 18, "DVI x 1" },
                    { 19, "RJ-45 x 1" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InterfaceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "PCIe 3.0 x16" },
                    { 3, "PCIe 4.0 x16" },
                    { 6, "PCIe 3.0 x8" },
                    { 7, "PCIe 4.0 x8" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "SATA III x 2" },
                    { 3, "SATA III x 4" },
                    { 4, "SATA III x 6" },
                    { 5, "SATA III x 7" },
                    { 6, "SATA III x 8" },
                    { 7, "SATA III x 10" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "USB 2.0 x 1" },
                    { 9, "USB 2.0 x 2" },
                    { 10, "USB 2.0 x 3" },
                    { 11, "USB 2.0 x 4" },
                    { 12, "PCIe 3.0 x16" },
                    { 13, "PCIe 4.0 x16" },
                    { 14, "PCIe 3.0 x8" },
                    { 15, "PCIe 4.0 x8" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemorySlots",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "2 x DIMM" },
                    { 3, "4 x DIMM" },
                    { 4, "8 x DIMM" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Ports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "HDMI 2.1 x 1" },
                    { 3, "HDMI 2.1 x 2" },
                    { 4, "HDMI 2.1a x 1" },
                    { 5, "HDMI 2.1a x 2" },
                    { 6, "DisplayPort 1.4 x 1" },
                    { 7, "DisplayPort 1.4 x 2" },
                    { 8, "DisplayPort 1.4 x 3" },
                    { 9, "DisplayPort 1.4 x 4" },
                    { 10, "DisplayPort 1.4a x 1" },
                    { 11, "DisplayPort 1.4a x 2" },
                    { 12, "DisplayPort 1.4a x 3" },
                    { 13, "DisplayPort 1.4a x 4" },
                    { 14, "DisplayPort 2.0 x 1" },
                    { 15, "DisplayPort 2.0 x 2" },
                    { 16, "DisplayPort 2.0 x 3" },
                    { 17, "DisplayPort 2.0 x 4" },
                    { 18, "DisplayPort 2.1 x 1" },
                    { 19, "DisplayPort 2.1 x 2" },
                    { 20, "DisplayPort 2.1 x 3" },
                    { 21, "DisplayPort 2.1 x 4" }
                });

            migrationBuilder.InsertData(
                table: "Enum_RAMModules",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "One" },
                    { 2, "Two" },
                    { 3, "Three" },
                    { 4, "Four" },
                    { 8, "Eight" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RAM_MemoryChannelId",
                table: "RAM",
                column: "MemoryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_RAMModulesId",
                table: "RAM",
                column: "RAMModulesId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_ConnectorsId",
                table: "CPUCooler",
                column: "ConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_ConnectorsId",
                table: "CaseCooler",
                column: "ConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_MemorySlots_MotherboardId",
                table: "Join_Motherboard_MemorySlots",
                column: "MotherboardId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_Connectors_ConnectorsId",
                table: "CaseCooler",
                column: "ConnectorsId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_CPUSocket_CPUSocketId",
                table: "CPU",
                column: "CPUSocketId",
                principalTable: "Enum_CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Enum_Connectors_ConnectorsId",
                table: "CPUCooler",
                column: "ConnectorsId",
                principalTable: "Enum_Connectors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CPUCooler_Enum_CPUSocket_SocketId",
                table: "CPUCooler",
                column: "SocketId",
                principalTable: "Enum_CPUSocket",
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
                name: "FK_GPU_Enum_InterfaceTypes_InterfaceTypeId",
                table: "GPU",
                column: "InterfaceTypeId",
                principalTable: "Enum_InterfaceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HDD_Enum_InterfaceTypes_InterfaceId",
                table: "HDD",
                column: "InterfaceId",
                principalTable: "Enum_InterfaceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Case_Port_Enum_ExternalConnector_PortId",
                table: "Join_Case_Port",
                column: "PortId",
                principalTable: "Enum_ExternalConnector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_GPU_Port_Enum_Ports_PortId",
                table: "Join_GPU_Port",
                column: "PortId",
                principalTable: "Enum_Ports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Motherboard_ExternalConnector_Enum_ExternalConnector_ExternalConnectorId",
                table: "Join_Motherboard_ExternalConnector",
                column: "ExternalConnectorId",
                principalTable: "Enum_ExternalConnector",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_Motherboard_InternalConnector_Enum_InternalConnector_InternalConnectorId",
                table: "Join_Motherboard_InternalConnector",
                column: "InternalConnectorId",
                principalTable: "Enum_InternalConnector",
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
                name: "FK_RAM_Enum_MemoryChannel_MemoryChannelId",
                table: "RAM",
                column: "MemoryChannelId",
                principalTable: "Enum_MemoryChannel",
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
                name: "FK_RAM_Enum_RAMModules_RAMModulesId",
                table: "RAM",
                column: "RAMModulesId",
                principalTable: "Enum_RAMModules",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SSD_Enum_InterfaceTypes_InterfaceId",
                table: "SSD",
                column: "InterfaceId",
                principalTable: "Enum_InterfaceTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
