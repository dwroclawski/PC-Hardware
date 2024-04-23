using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration211 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 5400);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 7200);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 10000);

            migrationBuilder.InsertData(
                table: "Enum_CoolingType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 5, "Heatsink" });

            migrationBuilder.UpdateData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "CL2.5");

            migrationBuilder.UpdateData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "CL10");

            migrationBuilder.InsertData(
                table: "Enum_CycleLatency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 23, "CL23" },
                    { 24, "CL24" },
                    { 25, "CL25" }
                });

            migrationBuilder.UpdateData(
                table: "Enum_Encryption",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Unknown");

            migrationBuilder.UpdateData(
                table: "Enum_Heatsink",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Unknown");

            migrationBuilder.InsertData(
                table: "Enum_RPM",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "5400 RPM" },
                    { 3, "7200 RPM" },
                    { 4, "10000 RPM" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enum_CoolingType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Enum_RPM",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Cl2_5");

            migrationBuilder.UpdateData(
                table: "Enum_CycleLatency",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Cl10");

            migrationBuilder.InsertData(
                table: "Enum_CycleLatency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
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

            migrationBuilder.UpdateData(
                table: "Enum_Encryption",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "None");

            migrationBuilder.UpdateData(
                table: "Enum_Heatsink",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "None");

            migrationBuilder.InsertData(
                table: "Enum_RPM",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 5400, "RPM_5400" },
                    { 7200, "RPM_7200" },
                    { 10000, "RPM_10000" }
                });
        }
    }
}
