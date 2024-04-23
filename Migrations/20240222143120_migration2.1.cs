using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "16 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "32 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "64 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "128 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "256 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "512 GB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Name",
                value: "1 TB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 2000,
                column: "Name",
                value: "2 TB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "GB_16");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 32,
                column: "Name",
                value: "GB_32");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 64,
                column: "Name",
                value: "GB_64");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 128,
                column: "Name",
                value: "GB_128");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "GB_256");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "GB_526");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 1000,
                column: "Name",
                value: "TB");

            migrationBuilder.UpdateData(
                table: "Enum_Capacity",
                keyColumn: "Id",
                keyValue: 2000,
                column: "Name",
                value: "TB_2");
        }
    }
}
