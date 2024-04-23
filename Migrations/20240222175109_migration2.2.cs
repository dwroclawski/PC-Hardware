using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class migration22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Join_CPUColor");

            migrationBuilder.DropTable(
                name: "Join_CPUMemoryTypeFrequency");

            migrationBuilder.DropTable(
                name: "Join_CPUMotherboardChipset");

            migrationBuilder.DropTable(
                name: "Join_GPUColor");

            migrationBuilder.DropTable(
                name: "Join_GPUPort");

            migrationBuilder.DropTable(
                name: "Join_HDDColor");

            migrationBuilder.DropTable(
                name: "Join_MotherboardColor");

            migrationBuilder.DropTable(
                name: "Join_MotherboardExternalConnector");

            migrationBuilder.DropTable(
                name: "Join_MotherboardInternalConnector");

            migrationBuilder.DropTable(
                name: "Join_MotherboardMemoryFrequency");

            migrationBuilder.DropTable(
                name: "Join_MotherboardMemorySlots");

            migrationBuilder.DropTable(
                name: "Join_MotherboardRAID");

            migrationBuilder.DropTable(
                name: "Join_MotherboardWirelessTechnology");

            migrationBuilder.DropTable(
                name: "Join_PSUColor");

            migrationBuilder.DropTable(
                name: "Join_PSUConnector");

            migrationBuilder.DropTable(
                name: "Join_PSUProtectionFeatures");

            migrationBuilder.CreateTable(
                name: "Enum_CoolingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_CoolingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_FanBearing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_FanBearing", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Fans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Fans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_FanSpeed",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_FanSpeed", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Material",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Material", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Mount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Mount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_TDP",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_TDP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPU_Color",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPU_Color", x => new { x.CPUId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_Join_CPU_Color_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPU_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPU_MemoryTypeFrequency",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    MemoryTypeFrequencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPU_MemoryTypeFrequency", x => new { x.CPUId, x.MemoryTypeFrequencyId });
                    table.ForeignKey(
                        name: "FK_Join_CPU_MemoryTypeFrequency_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPU_MemoryTypeFrequency_Enum_MemoryTypeFrequency_MemoryTypeFrequencyId",
                        column: x => x.MemoryTypeFrequencyId,
                        principalTable: "Enum_MemoryTypeFrequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPU_MotherboardChipset",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    MotherboardChipsetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPU_MotherboardChipset", x => new { x.CPUId, x.MotherboardChipsetId });
                    table.ForeignKey(
                        name: "FK_Join_CPU_MotherboardChipset_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPU_MotherboardChipset_Enum_otherboardChipset_MotherboardChipsetId",
                        column: x => x.MotherboardChipsetId,
                        principalTable: "Enum_otherboardChipset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_GPU_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    GPUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_GPU_Color", x => new { x.ColorId, x.GPUId });
                    table.ForeignKey(
                        name: "FK_Join_GPU_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_GPU_Color_GPU_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_GPU_Port",
                columns: table => new
                {
                    GPUId = table.Column<int>(type: "int", nullable: false),
                    PortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_GPU_Port", x => new { x.GPUId, x.PortId });
                    table.ForeignKey(
                        name: "FK_Join_GPU_Port_Enum_Ports_PortId",
                        column: x => x.PortId,
                        principalTable: "Enum_Ports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_GPU_Port_GPU_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_HDD_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    HDDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_HDD_Color", x => new { x.ColorId, x.HDDId });
                    table.ForeignKey(
                        name: "FK_Join_HDD_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_HDD_Color_HDD_HDDId",
                        column: x => x.HDDId,
                        principalTable: "HDD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_Color", x => new { x.ColorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_Color_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_ExternalConnector",
                columns: table => new
                {
                    ExternalConnectorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_ExternalConnector", x => new { x.ExternalConnectorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_ExternalConnector_Enum_ExternalConnector_ExternalConnectorId",
                        column: x => x.ExternalConnectorId,
                        principalTable: "Enum_ExternalConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_ExternalConnector_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_InternalConnector",
                columns: table => new
                {
                    InternalConnectorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_InternalConnector", x => new { x.InternalConnectorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_InternalConnector_Enum_InternalConnector_InternalConnectorId",
                        column: x => x.InternalConnectorId,
                        principalTable: "Enum_InternalConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_InternalConnector_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_MemoryFrequency",
                columns: table => new
                {
                    MemoryFrequencyId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_MemoryFrequency", x => new { x.MemoryFrequencyId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_MemoryFrequency_Enum_MemoryFrequency_MemoryFrequencyId",
                        column: x => x.MemoryFrequencyId,
                        principalTable: "Enum_MemoryFrequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_MemoryFrequency_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_RAID",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    RAIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_RAID", x => new { x.MotherboardId, x.RAIDId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_RAID_Enum_RAID_RAIDId",
                        column: x => x.RAIDId,
                        principalTable: "Enum_RAID",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_RAID_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_Motherboard_WirelessTechnology",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    WirelessTechnologyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_Motherboard_WirelessTechnology", x => new { x.MotherboardId, x.WirelessTechnologyId });
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_WirelessTechnology_Enum_WirelessTechnology_WirelessTechnologyId",
                        column: x => x.WirelessTechnologyId,
                        principalTable: "Enum_WirelessTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_Motherboard_WirelessTechnology_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSU_Color",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    PSUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSU_Color", x => new { x.ColorId, x.PSUId });
                    table.ForeignKey(
                        name: "FK_Join_PSU_Color_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSU_Color_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSU_Connector",
                columns: table => new
                {
                    ConnectorId = table.Column<int>(type: "int", nullable: false),
                    PSUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSU_Connector", x => new { x.ConnectorId, x.PSUId });
                    table.ForeignKey(
                        name: "FK_Join_PSU_Connector_Enum_Connectors_ConnectorId",
                        column: x => x.ConnectorId,
                        principalTable: "Enum_Connectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSU_Connector_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSU_ProtectionFeatures",
                columns: table => new
                {
                    PSUId = table.Column<int>(type: "int", nullable: false),
                    ProtectionFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSU_ProtectionFeatures", x => new { x.PSUId, x.ProtectionFeaturesId });
                    table.ForeignKey(
                        name: "FK_Join_PSU_ProtectionFeatures_Enum_ProtectionFeatures_ProtectionFeaturesId",
                        column: x => x.ProtectionFeaturesId,
                        principalTable: "Enum_ProtectionFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSU_ProtectionFeatures_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MTBF",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MTBF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RAM_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CaseCooler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FanAirflow = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FanNoiseLevel = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FansId = table.Column<int>(type: "int", nullable: false),
                    MTBFId = table.Column<int>(type: "int", nullable: false),
                    ConnectorsId = table.Column<int>(type: "int", nullable: true),
                    ConnectorId = table.Column<int>(type: "int", nullable: false),
                    FanBearingId = table.Column<int>(type: "int", nullable: false),
                    FanSpeedId = table.Column<int>(type: "int", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true),
                    CoolingTypeId = table.Column<int>(type: "int", nullable: true),
                    SocketId = table.Column<int>(type: "int", nullable: true),
                    MountId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseCooler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_Connectors_ConnectorsId",
                        column: x => x.ConnectorsId,
                        principalTable: "Enum_Connectors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_CoolingType_CoolingTypeId",
                        column: x => x.CoolingTypeId,
                        principalTable: "Enum_CoolingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_CPUSocket_SocketId",
                        column: x => x.SocketId,
                        principalTable: "Enum_CPUSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_FanBearing_FanBearingId",
                        column: x => x.FanBearingId,
                        principalTable: "Enum_FanBearing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_Fans_FansId",
                        column: x => x.FansId,
                        principalTable: "Enum_Fans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_FanSpeed_FanSpeedId",
                        column: x => x.FanSpeedId,
                        principalTable: "Enum_FanSpeed",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_Mount_MountId",
                        column: x => x.MountId,
                        principalTable: "Enum_Mount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaseCooler_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CaseCooler_MTBF_MTBFId",
                        column: x => x.MTBFId,
                        principalTable: "MTBF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPUCooler_Material",
                columns: table => new
                {
                    CPUCoolerId = table.Column<int>(type: "int", nullable: false),
                    MaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUCooler_Material", x => new { x.CPUCoolerId, x.MaterialId });
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_Material_CaseCooler_CPUCoolerId",
                        column: x => x.CPUCoolerId,
                        principalTable: "CaseCooler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUCooler_Material_Enum_Material_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Enum_Material",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Enum_CoolingType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Active" },
                    { 3, "Passive" },
                    { 4, "Water" }
                });

            migrationBuilder.InsertData(
                table: "Enum_FanBearing",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Fluid Dynamic" },
                    { 3, "Sleeve" },
                    { 4, "Ball" },
                    { 5, "Hydraulic" }
                });

            migrationBuilder.InsertData(
                table: "Enum_FanSpeed",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "up to 1500 RPM" },
                    { 3, "600 - 1500 RPM" },
                    { 4, "500 - 2000 RPM" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Fans",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 192, "1 x 92mm" },
                    { 1120, "1 x 120mm" },
                    { 1140, "1 x 140mm" },
                    { 2120, "2 x 120mm" },
                    { 2140, "2 x 140mm" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Material",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Aluminium" },
                    { 3, "Copper" },
                    { 4, "Nickel" },
                    { 5, "NickelPlatedCopper" },
                    { 6, "Plastic" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Mount",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Horizontal" },
                    { 3, "Vertical" }
                });

            migrationBuilder.InsertData(
                table: "Enum_TDP",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 65, "65 W" },
                    { 70, "70 W" },
                    { 85, "85 W" },
                    { 95, "95 W" },
                    { 100, "100 W" },
                    { 110, "110 W" },
                    { 120, "120 W" },
                    { 130, "130 W" },
                    { 140, "140 W" },
                    { 150, "150 W" },
                    { 160, "160 W" },
                    { 170, "170 W" },
                    { 180, "180 W" }
                });

            migrationBuilder.InsertData(
                table: "Enum_TDP",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 190, "190 W" },
                    { 200, "200 W" },
                    { 210, "210 W" },
                    { 220, "220 W" },
                    { 230, "230 W" },
                    { 240, "240 W" },
                    { 250, "250 W" },
                    { 260, "260 W" },
                    { 270, "270 W" },
                    { 280, "280 W" },
                    { 290, "290 W" },
                    { 300, "300 W" },
                    { 400, "400 W" }
                });

            migrationBuilder.InsertData(
                table: "MTBF",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 25000, "25 000 h" },
                    { 30000, "30 000 h" },
                    { 40000, "40 000 h" },
                    { 50000, "50 000 h" },
                    { 60000, "60 000 h" },
                    { 70000, "70 000 h" },
                    { 73500, "73 500 h" },
                    { 80000, "80 000 h" },
                    { 90000, "90 000 h" },
                    { 100000, "100 000 h" },
                    { 110000, "110 000 h" },
                    { 120000, "120 000 h" },
                    { 150000, "150 000 h" },
                    { 160000, "160 000 h" },
                    { 300000, "300 000 h" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_ConnectorsId",
                table: "CaseCooler",
                column: "ConnectorsId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_CoolingTypeId",
                table: "CaseCooler",
                column: "CoolingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_FanBearingId",
                table: "CaseCooler",
                column: "FanBearingId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_FansId",
                table: "CaseCooler",
                column: "FansId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_FanSpeedId",
                table: "CaseCooler",
                column: "FanSpeedId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_MountId",
                table: "CaseCooler",
                column: "MountId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_MTBFId",
                table: "CaseCooler",
                column: "MTBFId");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_ProducerID",
                table: "CaseCooler",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_CaseCooler_SocketId",
                table: "CaseCooler",
                column: "SocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPU_Color_ColorId",
                table: "Join_CPU_Color",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPU_MemoryTypeFrequency_MemoryTypeFrequencyId",
                table: "Join_CPU_MemoryTypeFrequency",
                column: "MemoryTypeFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPU_MotherboardChipset_MotherboardChipsetId",
                table: "Join_CPU_MotherboardChipset",
                column: "MotherboardChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUCooler_Material_MaterialId",
                table: "Join_CPUCooler_Material",
                column: "MaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_GPU_Color_GPUId",
                table: "Join_GPU_Color",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_GPU_Port_PortId",
                table: "Join_GPU_Port",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_HDD_Color_HDDId",
                table: "Join_HDD_Color",
                column: "HDDId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_Color_MotherboardId",
                table: "Join_Motherboard_Color",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_ExternalConnector_MotherboardId",
                table: "Join_Motherboard_ExternalConnector",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_InternalConnector_MotherboardId",
                table: "Join_Motherboard_InternalConnector",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_MemoryFrequency_MotherboardId",
                table: "Join_Motherboard_MemoryFrequency",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_MemorySlots_MotherboardId",
                table: "Join_Motherboard_MemorySlots",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_RAID_RAIDId",
                table: "Join_Motherboard_RAID",
                column: "RAIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_Motherboard_WirelessTechnology_WirelessTechnologyId",
                table: "Join_Motherboard_WirelessTechnology",
                column: "WirelessTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSU_Color_PSUId",
                table: "Join_PSU_Color",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSU_Connector_PSUId",
                table: "Join_PSU_Connector",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSU_ProtectionFeatures_ProtectionFeaturesId",
                table: "Join_PSU_ProtectionFeatures",
                column: "ProtectionFeaturesId");

            migrationBuilder.CreateIndex(
                name: "IX_RAM_ProducerID",
                table: "RAM",
                column: "ProducerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enum_TDP");

            migrationBuilder.DropTable(
                name: "Join_CPU_Color");

            migrationBuilder.DropTable(
                name: "Join_CPU_MemoryTypeFrequency");

            migrationBuilder.DropTable(
                name: "Join_CPU_MotherboardChipset");

            migrationBuilder.DropTable(
                name: "Join_CPUCooler_Material");

            migrationBuilder.DropTable(
                name: "Join_GPU_Color");

            migrationBuilder.DropTable(
                name: "Join_GPU_Port");

            migrationBuilder.DropTable(
                name: "Join_HDD_Color");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_Color");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_ExternalConnector");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_InternalConnector");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_MemoryFrequency");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_MemorySlots");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_RAID");

            migrationBuilder.DropTable(
                name: "Join_Motherboard_WirelessTechnology");

            migrationBuilder.DropTable(
                name: "Join_PSU_Color");

            migrationBuilder.DropTable(
                name: "Join_PSU_Connector");

            migrationBuilder.DropTable(
                name: "Join_PSU_ProtectionFeatures");

            migrationBuilder.DropTable(
                name: "RAM");

            migrationBuilder.DropTable(
                name: "CaseCooler");

            migrationBuilder.DropTable(
                name: "Enum_Material");

            migrationBuilder.DropTable(
                name: "Enum_CoolingType");

            migrationBuilder.DropTable(
                name: "Enum_FanBearing");

            migrationBuilder.DropTable(
                name: "Enum_Fans");

            migrationBuilder.DropTable(
                name: "Enum_FanSpeed");

            migrationBuilder.DropTable(
                name: "Enum_Mount");

            migrationBuilder.DropTable(
                name: "MTBF");

            migrationBuilder.CreateTable(
                name: "Join_CPUColor",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUColor", x => new { x.CPUId, x.ColorId });
                    table.ForeignKey(
                        name: "FK_Join_CPUColor_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUColor_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPUMemoryTypeFrequency",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    MemoryTypeFrequencyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUMemoryTypeFrequency", x => new { x.CPUId, x.MemoryTypeFrequencyId });
                    table.ForeignKey(
                        name: "FK_Join_CPUMemoryTypeFrequency_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUMemoryTypeFrequency_Enum_MemoryTypeFrequency_MemoryTypeFrequencyId",
                        column: x => x.MemoryTypeFrequencyId,
                        principalTable: "Enum_MemoryTypeFrequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_CPUMotherboardChipset",
                columns: table => new
                {
                    CPUId = table.Column<int>(type: "int", nullable: false),
                    MotherboardChipsetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_CPUMotherboardChipset", x => new { x.CPUId, x.MotherboardChipsetId });
                    table.ForeignKey(
                        name: "FK_Join_CPUMotherboardChipset_CPU_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_CPUMotherboardChipset_Enum_otherboardChipset_MotherboardChipsetId",
                        column: x => x.MotherboardChipsetId,
                        principalTable: "Enum_otherboardChipset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_GPUColor",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    GPUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_GPUColor", x => new { x.ColorId, x.GPUId });
                    table.ForeignKey(
                        name: "FK_Join_GPUColor_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_GPUColor_GPU_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_GPUPort",
                columns: table => new
                {
                    GPUId = table.Column<int>(type: "int", nullable: false),
                    PortId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_GPUPort", x => new { x.GPUId, x.PortId });
                    table.ForeignKey(
                        name: "FK_Join_GPUPort_Enum_Ports_PortId",
                        column: x => x.PortId,
                        principalTable: "Enum_Ports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_GPUPort_GPU_GPUId",
                        column: x => x.GPUId,
                        principalTable: "GPU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_HDDColor",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    HDDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_HDDColor", x => new { x.ColorId, x.HDDId });
                    table.ForeignKey(
                        name: "FK_Join_HDDColor_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_HDDColor_HDD_HDDId",
                        column: x => x.HDDId,
                        principalTable: "HDD",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardColor",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardColor", x => new { x.ColorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardColor_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardColor_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardExternalConnector",
                columns: table => new
                {
                    ExternalConnectorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardExternalConnector", x => new { x.ExternalConnectorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardExternalConnector_Enum_ExternalConnector_ExternalConnectorId",
                        column: x => x.ExternalConnectorId,
                        principalTable: "Enum_ExternalConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardExternalConnector_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardInternalConnector",
                columns: table => new
                {
                    InternalConnectorId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardInternalConnector", x => new { x.InternalConnectorId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardInternalConnector_Enum_InternalConnector_InternalConnectorId",
                        column: x => x.InternalConnectorId,
                        principalTable: "Enum_InternalConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardInternalConnector_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardMemoryFrequency",
                columns: table => new
                {
                    MemoryFrequencyId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardMemoryFrequency", x => new { x.MemoryFrequencyId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardMemoryFrequency_Enum_MemoryFrequency_MemoryFrequencyId",
                        column: x => x.MemoryFrequencyId,
                        principalTable: "Enum_MemoryFrequency",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardMemoryFrequency_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardMemorySlots",
                columns: table => new
                {
                    MemorySlotsId = table.Column<int>(type: "int", nullable: false),
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardMemorySlots", x => new { x.MemorySlotsId, x.MotherboardId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardMemorySlots_Enum_MemorySlots_MemorySlotsId",
                        column: x => x.MemorySlotsId,
                        principalTable: "Enum_MemorySlots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardMemorySlots_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardRAID",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    RAIDId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardRAID", x => new { x.MotherboardId, x.RAIDId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardRAID_Enum_RAID_RAIDId",
                        column: x => x.RAIDId,
                        principalTable: "Enum_RAID",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardRAID_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_MotherboardWirelessTechnology",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false),
                    WirelessTechnologyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_MotherboardWirelessTechnology", x => new { x.MotherboardId, x.WirelessTechnologyId });
                    table.ForeignKey(
                        name: "FK_Join_MotherboardWirelessTechnology_Enum_WirelessTechnology_WirelessTechnologyId",
                        column: x => x.WirelessTechnologyId,
                        principalTable: "Enum_WirelessTechnology",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_MotherboardWirelessTechnology_Motherboard_MotherboardId",
                        column: x => x.MotherboardId,
                        principalTable: "Motherboard",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSUColor",
                columns: table => new
                {
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    PSUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSUColor", x => new { x.ColorId, x.PSUId });
                    table.ForeignKey(
                        name: "FK_Join_PSUColor_Enum_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Enum_Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSUColor_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSUConnector",
                columns: table => new
                {
                    ConnectorId = table.Column<int>(type: "int", nullable: false),
                    PSUId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSUConnector", x => new { x.ConnectorId, x.PSUId });
                    table.ForeignKey(
                        name: "FK_Join_PSUConnector_Enum_Connectors_ConnectorId",
                        column: x => x.ConnectorId,
                        principalTable: "Enum_Connectors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSUConnector_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Join_PSUProtectionFeatures",
                columns: table => new
                {
                    PSUId = table.Column<int>(type: "int", nullable: false),
                    ProtectionFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Join_PSUProtectionFeatures", x => new { x.PSUId, x.ProtectionFeaturesId });
                    table.ForeignKey(
                        name: "FK_Join_PSUProtectionFeatures_Enum_ProtectionFeatures_ProtectionFeaturesId",
                        column: x => x.ProtectionFeaturesId,
                        principalTable: "Enum_ProtectionFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Join_PSUProtectionFeatures_PSU_PSUId",
                        column: x => x.PSUId,
                        principalTable: "PSU",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUColor_ColorId",
                table: "Join_CPUColor",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUMemoryTypeFrequency_MemoryTypeFrequencyId",
                table: "Join_CPUMemoryTypeFrequency",
                column: "MemoryTypeFrequencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_CPUMotherboardChipset_MotherboardChipsetId",
                table: "Join_CPUMotherboardChipset",
                column: "MotherboardChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_GPUColor_GPUId",
                table: "Join_GPUColor",
                column: "GPUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_GPUPort_PortId",
                table: "Join_GPUPort",
                column: "PortId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_HDDColor_HDDId",
                table: "Join_HDDColor",
                column: "HDDId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardColor_MotherboardId",
                table: "Join_MotherboardColor",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardExternalConnector_MotherboardId",
                table: "Join_MotherboardExternalConnector",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardInternalConnector_MotherboardId",
                table: "Join_MotherboardInternalConnector",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardMemoryFrequency_MotherboardId",
                table: "Join_MotherboardMemoryFrequency",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardMemorySlots_MotherboardId",
                table: "Join_MotherboardMemorySlots",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardRAID_RAIDId",
                table: "Join_MotherboardRAID",
                column: "RAIDId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_MotherboardWirelessTechnology_WirelessTechnologyId",
                table: "Join_MotherboardWirelessTechnology",
                column: "WirelessTechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSUColor_PSUId",
                table: "Join_PSUColor",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSUConnector_PSUId",
                table: "Join_PSUConnector",
                column: "PSUId");

            migrationBuilder.CreateIndex(
                name: "IX_Join_PSUProtectionFeatures_ProtectionFeaturesId",
                table: "Join_PSUProtectionFeatures",
                column: "ProtectionFeaturesId");
        }
    }
}
