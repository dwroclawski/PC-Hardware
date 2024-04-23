using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migraton29 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_Architecture_ArchitectureId",
                table: "CPU");

            migrationBuilder.DropTable(
                name: "Enum_Architecture");

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 2000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 4000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 8000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 16000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 32000);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 64000);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.RenameColumn(
                name: "ArchitectureId",
                table: "CPU",
                newName: "LithographyId");

            migrationBuilder.RenameIndex(
                name: "IX_CPU_ArchitectureId",
                table: "CPU",
                newName: "IX_CPU_LithographyId");

            migrationBuilder.CreateTable(
                name: "Enum_Lithography",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Lithography", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Socket 1700");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Socket 1200");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Socket 1151");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Socket AM5");

            migrationBuilder.InsertData(
                table: "Enum_CPUSocket",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Socket AM4" },
                    { 7, "Socket sTRX4" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Cache",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "Unknown" },
                    { 3, "16 KB" },
                    { 4, "32 KB" },
                    { 5, "64 KB" },
                    { 6, "128 KB" },
                    { 7, "256 KB" },
                    { 8, "512 KB" },
                    { 9, "1 MB" },
                    { 10, "2 MB" },
                    { 11, "4 MB" },
                    { 12, "8 MB" },
                    { 13, "16 MB" },
                    { 14, "32 MB" },
                    { 15, "64 MB" },
                    { 16, "128 MB" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_DataWidth",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "32 bit");

            migrationBuilder.UpdateData(
                table: "Enum_DataWidth",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "64 bit");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "SATA III x 2");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "SATA III x 4");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "SATA III x 6");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "SATA III x 7");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "SATA III x 8");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "SATA III x 10");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "USB 2.0 x 1");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "USB 2.0 x 2");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "USB 2.0 x 3");

            migrationBuilder.InsertData(
                table: "Enum_InternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "USB 2.0 x 4" });

            migrationBuilder.InsertData(
                table: "Enum_Lithography",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 4, "4 nm" },
                    { 5, "5 nm" },
                    { 7, "7 nm" },
                    { 10, "10 nm" },
                    { 12, "12 nm" },
                    { 14, "14 nm" },
                    { 16, "16 nm" },
                    { 22, "22 nm" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Lithography",
                columns: new[] { "Id", "Name" },
                values: new object[] { 28, "28 nm" });

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Dual-Channel");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Quad-Channel");

            migrationBuilder.InsertData(
                table: "Enum_MemoryChannel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "Octal-Channel" });

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "2133 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2400 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "2666 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "2800 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "3000 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "3200 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "3600 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "4000 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "4266 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "4400 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "4600 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "4800 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "5000 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "5200 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "5333 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "5600 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "5800 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "6000 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "2 x DIMM");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "4 x DIMM");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "8 x DIMM");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "DDR4 2133 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "DDR4 2400 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "DDR4 2666 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "DDR4 2800 MHz");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "DDR4 3000 MHz");

            migrationBuilder.InsertData(
                table: "Enum_MemoryTypeFrequency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "DDR4 3200 MHz" },
                    { 8, "DDR5 3600 MHz" },
                    { 9, "DDR5 4000 MHz" },
                    { 10, "DDR5 4266 MHz" },
                    { 11, "DDR5 4400 MHz" },
                    { 12, "DDR5 4600 MHz" },
                    { 13, "DDR5 4800 MHz" },
                    { 14, "DDR5 5000 MHz" },
                    { 15, "DDR5 5200 MHz" },
                    { 16, "DDR5 5333 MHz" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryTypeFrequency",
                columns: new[] { "Id", "Name" },
                values: new object[] { 17, "DDR5 5600 MHz" });

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Intel B760");

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Intel Z790");

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Intel H610");

            migrationBuilder.InsertData(
                table: "Enum_MotherboardChipset",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5, "Intel Z690" },
                    { 6, "AMD B650" },
                    { 7, "AMD B550" },
                    { 8, "AMD B450" },
                    { 9, "AMD A520" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "RAID 0");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "RAID 1");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "RAID 5");

            migrationBuilder.InsertData(
                table: "Enum_RAID",
                columns: new[] { "Id", "Name" },
                values: new object[] { 6, "RAID 10" });

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Bluetooth");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Wi-Fi 4");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Wi-Fi 5");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Wi-Fi 6");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Wi-Fi 6E");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Wi-Fi 7");

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_Lithography_LithographyId",
                table: "CPU",
                column: "LithographyId",
                principalTable: "Enum_Lithography",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CPU_Enum_Lithography_LithographyId",
                table: "CPU");

            migrationBuilder.DropTable(
                name: "Enum_Lithography");

            migrationBuilder.DeleteData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enum_Cache",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "LithographyId",
                table: "CPU",
                newName: "ArchitectureId");

            migrationBuilder.RenameIndex(
                name: "IX_CPU_LithographyId",
                table: "CPU",
                newName: "IX_CPU_ArchitectureId");

            migrationBuilder.CreateTable(
                name: "Enum_Architecture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Architecture", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Enum_Architecture",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 4, "nm_4" },
                    { 5, "nm_5" },
                    { 7, "nm_7" },
                    { 10, "nm_10" },
                    { 12, "nm_12" },
                    { 14, "nm_14" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "LGA_1200");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "AM4");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "LGA_1151");

            migrationBuilder.UpdateData(
                table: "Enum_CPUSocket",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "LGA_2066");

            migrationBuilder.InsertData(
                table: "Enum_Cache",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 128, "KB_128" },
                    { 256, "KB_256" },
                    { 512, "KB_512" },
                    { 1000, "MB_1" },
                    { 2000, "MB_2" },
                    { 4000, "MB_4" },
                    { 8000, "MB_8" },
                    { 16000, "MB_16" },
                    { 32000, "MB_32" },
                    { 64000, "MB_64" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_DataWidth",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "Bit_32");

            migrationBuilder.UpdateData(
                table: "Enum_DataWidth",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "Bit_64");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "SATA_III");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "M_2");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "PCIe_3_0x16");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "PCIe_3_0x1");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "PCIe_4_0x16");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "PCIe_4_0x1");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "USB_2_0");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "USB_3_2_Gen_1");

            migrationBuilder.UpdateData(
                table: "Enum_InternalConnector",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "USB_3_2_Gen_2");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Single");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryChannel",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Quad");

            migrationBuilder.InsertData(
                table: "Enum_MemoryChannel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Dual" });

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "MHz_2133");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "MHz_2400");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "MHz_2666");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "MHz_2800");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "MHz_3000");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "MHz_3200");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "MHz_3600");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "MHz_4000");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "MHz_4266");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "MHz_4400");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "MHz_4600");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "MHz_4800");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "MHz_5000");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "MHz_5200");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "MHz_5333");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "MHz_5600");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 18,
                column: "Name",
                value: "MHz_5800");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryFrequency",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "MHz_6000");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "DIMM_2");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "DIMM_4");

            migrationBuilder.UpdateData(
                table: "Enum_MemorySlots",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "SODIMM_2");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "DDR4_2133");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "DDR4_2400");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "DDR4_2666");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "DDR4_2800");

            migrationBuilder.UpdateData(
                table: "Enum_MemoryTypeFrequency",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "DDR4_3000");

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "B450");

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "B550");

            migrationBuilder.UpdateData(
                table: "Enum_MotherboardChipset",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "B760");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "RAID_0");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "RAID_1");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "RAID_5");

            migrationBuilder.UpdateData(
                table: "Enum_RAID",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "RAID_10");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "WiFi_4");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "WiFi_5");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "WiFi_6");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "WiFi_6E");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Bluetooth_4_0");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Bluetooth_4_2");

            migrationBuilder.UpdateData(
                table: "Enum_WirelessTechnology",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Bluetooth_5_0");

            migrationBuilder.InsertData(
                table: "Enum_WirelessTechnology",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 9, "Bluetooth_5_1" },
                    { 10, "Bluetooth_5_2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CPU_Enum_Architecture_ArchitectureId",
                table: "CPU",
                column: "ArchitectureId",
                principalTable: "Enum_Architecture",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
