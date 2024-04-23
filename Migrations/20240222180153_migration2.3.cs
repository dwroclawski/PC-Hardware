using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_CoolingType_CoolingTypeId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_CPUSocket_SocketId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_Mount_MountId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_CPU_MotherboardChipset_Enum_otherboardChipset_MotherboardChipsetId",
                table: "Join_CPU_MotherboardChipset");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_CPUCooler_Material_CaseCooler_CPUCoolerId",
                table: "Join_CPUCooler_Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_otherboardChipset_ChipsetId",
                table: "Motherboard");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_CoolingTypeId",
                table: "CaseCooler");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_MountId",
                table: "CaseCooler");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_SocketId",
                table: "CaseCooler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_otherboardChipset",
                table: "Enum_otherboardChipset");

            migrationBuilder.DropColumn(
                name: "CoolingTypeId",
                table: "CaseCooler");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "CaseCooler");

            migrationBuilder.DropColumn(
                name: "MountId",
                table: "CaseCooler");

            migrationBuilder.DropColumn(
                name: "SocketId",
                table: "CaseCooler");

            migrationBuilder.DropColumn(
                name: "Wattage",
                table: "CaseCooler");

            migrationBuilder.RenameTable(
                name: "Enum_otherboardChipset",
                newName: "Enum_MotherboardChipset");

            migrationBuilder.AddColumn<int>(
                name: "HeatPipesId",
                table: "CaseCooler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_MotherboardChipset",
                table: "Enum_MotherboardChipset",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Enum_HeatPipes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_HeatPipes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CPUCooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CoolingTypeId = table.Column<int>(type: "int", nullable: false),
                    SocketId = table.Column<int>(type: "int", nullable: false),
                    MountId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FanAirflow = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FanNoiseLevel = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FansId = table.Column<int>(type: "int", nullable: false),
                    MTBFId = table.Column<int>(type: "int", nullable: false),
                    ConnectorsId = table.Column<int>(type: "int", nullable: true),
                    ConnectorId = table.Column<int>(type: "int", nullable: false),
                    FanBearingId = table.Column<int>(type: "int", nullable: false),
                    FanSpeedId = table.Column<int>(type: "int", nullable: false),
                    HeatPipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUCooler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_Connectors_ConnectorsId",
                        column: x => x.ConnectorsId,
                        principalTable: "Enum_Connectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_CoolingType_CoolingTypeId",
                        column: x => x.CoolingTypeId,
                        principalTable: "Enum_CoolingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_CPUSocket_SocketId",
                        column: x => x.SocketId,
                        principalTable: "Enum_CPUSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_FanBearing_FanBearingId",
                        column: x => x.FanBearingId,
                        principalTable: "Enum_FanBearing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_Fans_FansId",
                        column: x => x.FansId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_FanSpeed_FanSpeedId",
                        column: x => x.FanSpeedId,
                        principalTable: "Enum_FanSpeed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_HeatPipes_HeatPipesId",
                        column: x => x.HeatPipesId,
                        principalTable: "Enum_HeatPipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_Mount_MountId",
                        column: x => x.MountId,
                        principalTable: "Enum_Mount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPUCooler_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPUCooler_MTBF_MTBFId",
                        column: x => x.MTBFId,
                        principalTable: "MTBF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enum_HeatPipes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 16, "1 x 6mm" },
                    { 18, "1 x 8mm" },
                    { 26, "2 x 6mm" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_HeatPipesId",
                table: "CaseCooler",
                column: "HeatPipesId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_ConnectorsId",
                table: "CPUCooler",
                column: "ConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_CoolingTypeId",
                table: "CPUCooler",
                column: "CoolingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_FanBearingId",
                table: "CPUCooler",
                column: "FanBearingId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_FansId",
                table: "CPUCooler",
                column: "FansId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_FanSpeedId",
                table: "CPUCooler",
                column: "FanSpeedId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_HeatPipesId",
                table: "CPUCooler",
                column: "HeatPipesId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_MountId",
                table: "CPUCooler",
                column: "MountId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_MTBFId",
                table: "CPUCooler",
                column: "MTBFId");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_ProducerID",
                table: "CPUCooler",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_CPUCooler_SocketId",
                table: "CPUCooler",
                column: "SocketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_HeatPipes_HeatPipesId",
                table: "CaseCooler",
                column: "HeatPipesId",
                principalTable: "Enum_HeatPipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_CPU_MotherboardChipset_Enum_MotherboardChipset_MotherboardChipsetId",
                table: "Join_CPU_MotherboardChipset",
                column: "MotherboardChipsetId",
                principalTable: "Enum_MotherboardChipset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_CPUCooler_Material_CPUCooler_CPUCoolerId",
                table: "Join_CPUCooler_Material",
                column: "CPUCoolerId",
                principalTable: "CPUCooler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_Enum_MotherboardChipset_ChipsetId",
                table: "Motherboard",
                column: "ChipsetId",
                principalTable: "Enum_MotherboardChipset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CaseCooler_Enum_HeatPipes_HeatPipesId",
                table: "CaseCooler");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_CPU_MotherboardChipset_Enum_MotherboardChipset_MotherboardChipsetId",
                table: "Join_CPU_MotherboardChipset");

            migrationBuilder.DropForeignKey(
                name: "FK_Join_CPUCooler_Material_CPUCooler_CPUCoolerId",
                table: "Join_CPUCooler_Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Motherboard_Enum_MotherboardChipset_ChipsetId",
                table: "Motherboard");

            migrationBuilder.DropTable(
                name: "CPUCooler");

            migrationBuilder.DropTable(
                name: "Enum_HeatPipes");

            migrationBuilder.DropIndex(
                name: "IX_CaseCooler_HeatPipesId",
                table: "CaseCooler");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enum_MotherboardChipset",
                table: "Enum_MotherboardChipset");

            migrationBuilder.DropColumn(
                name: "HeatPipesId",
                table: "CaseCooler");

            migrationBuilder.RenameTable(
                name: "Enum_MotherboardChipset",
                newName: "Enum_otherboardChipset");

            migrationBuilder.AddColumn<int>(
                name: "CoolingTypeId",
                table: "CaseCooler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "CaseCooler",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MountId",
                table: "CaseCooler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SocketId",
                table: "CaseCooler",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Wattage",
                table: "CaseCooler",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enum_otherboardChipset",
                table: "Enum_otherboardChipset",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_CoolingTypeId",
                table: "CaseCooler",
                column: "CoolingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_MountId",
                table: "CaseCooler",
                column: "MountId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_SocketId",
                table: "CaseCooler",
                column: "SocketId");

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_CoolingType_CoolingTypeId",
                table: "CaseCooler",
                column: "CoolingTypeId",
                principalTable: "Enum_CoolingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_CPUSocket_SocketId",
                table: "CaseCooler",
                column: "SocketId",
                principalTable: "Enum_CPUSocket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CaseCooler_Enum_Mount_MountId",
                table: "CaseCooler",
                column: "MountId",
                principalTable: "Enum_Mount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_CPU_MotherboardChipset_Enum_otherboardChipset_MotherboardChipsetId",
                table: "Join_CPU_MotherboardChipset",
                column: "MotherboardChipsetId",
                principalTable: "Enum_otherboardChipset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Join_CPUCooler_Material_CaseCooler_CPUCoolerId",
                table: "Join_CPUCooler_Material",
                column: "CPUCoolerId",
                principalTable: "CaseCooler",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Motherboard_Enum_otherboardChipset_ChipsetId",
                table: "Motherboard",
                column: "ChipsetId",
                principalTable: "Enum_otherboardChipset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
