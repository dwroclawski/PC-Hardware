using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration210 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enum_Cooling",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Enum_Cooling",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 2120);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 2140);

            migrationBuilder.DeleteData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 2160);

            migrationBuilder.InsertData(
                table: "Enum_Capacity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "2 GB" },
                    { 4, "4 GB" },
                    { 6, "6 GB" },
                    { 8, "8 GB" },
                    { 10, "10 GB" },
                    { 12, "12 GB" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "GeForce RTX 4090");

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "GeForce RTX 4080");

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "GeForce RTX 4070");

            migrationBuilder.InsertData(
                table: "Enum_Chipset",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "GeForce RTX 4070 Ti" });

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

            migrationBuilder.InsertData(
                table: "Enum_Connectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "CPU 8 x 1" },
                    { 6, "CPU 8 x 2" },
                    { 7, "CPU 4 x 1" },
                    { 8, "EPS12V 20+4 x 1" },
                    { 9, "EPS12V 4+4 x 1" },
                    { 10, "EPS12V 4+4 x 2" },
                    { 11, "PCI-E 5.0 12+4 x 1" },
                    { 12, "PCI-E 5.0 12+4 x 2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Cooling",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "120mm Fan" },
                    { 3, "135mm Fan" },
                    { 4, "140mm Fan" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Drivebay",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "1 x 2.5''" },
                    { 3, "1 x 3.5''" },
                    { 4, "2 x 2.5''" },
                    { 5, "2 x 3.5''" },
                    { 6, "3 x 2.5''" },
                    { 7, "3 x 3.5''" },
                    { 8, "4 x 2.5''" },
                    { 9, "4 x 3.5''" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "USB 2.0 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "USB 2.0 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "USB 2.0 x 3");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "USB 2.0 x 4");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "USB 3.2 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "USB 3.2 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "USB 3.2 x 3");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "USB 3.2 x 4");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "USB 3.2 Type-C x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "USB 3.2 Type-C x 2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Microphone x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Headphone x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Microphone/Headphone x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "HDMI x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "DisplayPort x 1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "VGA x 1");

            migrationBuilder.InsertData(
                table: "Enum_ExternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 18, "DVI x 1" },
                    { 19, "RJ-45 x 1" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Fans",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "1 x 120 mm (back)" },
                    { 3, "1 x 120 mm (front)" },
                    { 4, "1 x 120 mm (top)" },
                    { 5, "1 x 120 mm (under)" },
                    { 6, "1 x 120 mm (left)" },
                    { 7, "1 x 120 mm (right)" },
                    { 8, "1 x 120 mm" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PCIe 3.0 x16");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "PCIe 4.0 x16");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "PCIe 3.0 x8");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "PCIe 4.0 x8");

            migrationBuilder.InsertData(
                table: "Enum_InternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 12, "PCIe 3.0 x16" },
                    { 13, "PCIe 4.0 x16" },
                    { 14, "PCIe 3.0 x8" },
                    { 15, "PCIe 4.0 x8" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Steel");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Plastic");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Glass");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Carbon");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Wood");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Titanium");

            migrationBuilder.InsertData(
                table: "Enum_Material",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Copper" },
                    { 10, "Mesh" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "64 bit");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "128 bit");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "192 bit");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "256 bit");

            migrationBuilder.InsertData(
                table: "Enum_MemoryBus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 96, "96 bit" },
                    { 320, "320 bit" },
                    { 384, "384 bit" },
                    { 2048, "2048 bit" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "HBM2");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "DDR3");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "DDR4");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "DDR5");

            migrationBuilder.InsertData(
                table: "Enum_MemoryType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "GDDR3" },
                    { 7, "GDDR5" },
                    { 8, "GDDR6" },
                    { 9, "GDDR6X" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Non-Modular");

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Semi-Modular");

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Fully-Modular");

            migrationBuilder.UpdateData(
                table: "Enum_PFC",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Active");

            migrationBuilder.UpdateData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "HDMI 2.1 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "HDMI 2.1 x 2");

            migrationBuilder.InsertData(
                table: "Enum_Ports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "6 pin x 1");

            migrationBuilder.InsertData(
                table: "Enum_PowerConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "16 pin x 1" },
                    { 3, "8 pin x 3" },
                    { 4, "8 pin x 2" },
                    { 5, "8 pin x 1" },
                    { 7, "8 pin x 1 + 6 pin x 1" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "80 PLUS");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "80 PLUS Bronze");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "80 PLUS Silver");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "80 PLUS Gold");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "80 PLUS Platinum");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "80 PLUS Titanium");

            migrationBuilder.InsertData(
                table: "Enum_Rating",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Unclassified" });

            migrationBuilder.InsertData(
                table: "Enum_Resolution",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2560, "2560 x 1600" },
                    { 3840, "3840 x 2160" },
                    { 4096, "4096 x 2160" },
                    { 5120, "5120 x 2880" },
                    { 7680, "7680 x 4320" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_Cooling",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_Cooling",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_Cooling",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Drivebay",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Fans",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 2048);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 2560);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 3840);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 4096);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 5120);

            migrationBuilder.DeleteData(
                table: "Enum_Resolution",
                keyColumn: "Id",
                keyValue: 7680);

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "GeForce_RTX_4070_Ti");

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "GeForce_RTX_4080");

            migrationBuilder.UpdateData(
                table: "Enum_Chipset",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Radeon_RX_7600");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "SATA");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "PCI_E");

            migrationBuilder.UpdateData(
                table: "Enum_Connectors",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "MOLEX");

            migrationBuilder.InsertData(
                table: "Enum_Cooling",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 120, "Fan_120mm" },
                    { 135, "Fan_135mm" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Drivebay",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 125, "1 x 2.5''" },
                    { 135, "1 x 3.5''" },
                    { 225, "2 x 2.5''" },
                    { 235, "2 x 3.5''" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "USB_2_0");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "USB_3_2_Gen_1");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "USB_3_2_Gen_2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "USB_3_2_Gen_2x2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "USB_4");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "USB_C");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "HDMI");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "DP");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "VGA");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "DVI");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "RJ_45");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Audio");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Optical");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "PS_2");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Thunderbolt_3");

            migrationBuilder.UpdateData(
                table: "Enum_ExternalConnector",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Thunderbolt_4");

            migrationBuilder.InsertData(
                table: "Enum_Fans",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 192, "1 x 92mm" },
                    { 1120, "1 x 120mm" },
                    { 1140, "1 x 140mm" },
                    { 2120, "2 x 120mm" },
                    { 2140, "2 x 140mm" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "PCIExpress4_0x16");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "PCI");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "SATA_III");

            migrationBuilder.UpdateData(
                table: "Enum_InterfaceTypes",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "M_2");

            migrationBuilder.InsertData(
                table: "Enum_InterfaceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "SATA_I" },
                    { 5, "SATA_II" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Copper");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Nickel");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "NickelPlatedCopper");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Plastic");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Glass");

            migrationBuilder.UpdateData(
                table: "Enum_Material",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Mesh");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Bit_64");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "Bit_128");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "Bit_192");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryBus",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "Bit_256");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "DDR4");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "GDDR5");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "GDDR6");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryType",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "HBM");

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Fully_Modular");

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Semi_Modular");

            migrationBuilder.UpdateData(
                table: "Enum_Modular",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Not_Modular");

            migrationBuilder.UpdateData(
                table: "Enum_PFC",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Actove");

            migrationBuilder.UpdateData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "HDMI");

            migrationBuilder.UpdateData(
                table: "Enum_Ports",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "DP");

            migrationBuilder.UpdateData(
                table: "Enum_PowerConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pin_6");

            migrationBuilder.InsertData(
                table: "Enum_PowerConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Pin_8" },
                    { 16, "Pin_16" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Plus");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Plus_Bronze");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Plus_Silver");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Plus_Gold");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Plus_Platinum");

            migrationBuilder.UpdateData(
                table: "Enum_Rating",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Plus_Titanium");

            migrationBuilder.InsertData(
                table: "Enum_Resolution",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 720, "HD" },
                    { 1080, "Full_HD" },
                    { 1440, "Quad_HD" },
                    { 2160, "Ultra_HD" }
                });
        }
    }
}
