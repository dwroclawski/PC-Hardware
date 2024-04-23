using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VueBase.Migrations
{
    public partial class NewInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Enum_Cache",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Cache", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Capacity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Capacity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Chipset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Chipset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Color", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Connectors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Connectors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Cooling",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Cooling", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_CPUSocket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_CPUSocket", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_DataWidth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_DataWidth", x => x.Id);
                });

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
                name: "Enum_FormFactor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_FormFactor", x => x.Id);
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
                name: "Enum_InternalGPUSupport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_InternalGPUSupport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_MemoryBus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemoryBus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_MemoryChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemoryChannel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_MemoryFrequency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemoryFrequency", x => x.Id);
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
                name: "Enum_MemoryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_MemoryTypeFrequency",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_MemoryTypeFrequency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Modular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Modular", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_otherboardChipset",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_otherboardChipset", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_PFC",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_PFC", x => x.Id);
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
                name: "Enum_PowerConnector",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_PowerConnector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_ProtectionFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_ProtectionFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_PUFamily",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_PUFamily", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_RAID",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_RAID", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Rating", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_Resolution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_Resolution", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_RPM",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_RPM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Enum_WirelessTechnology",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enum_WirelessTechnology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FormFactorId = table.Column<int>(type: "int", nullable: false),
                    CPUSocketId = table.Column<int>(type: "int", nullable: false),
                    ChipsetId = table.Column<int>(type: "int", nullable: false),
                    CPUFamilyId = table.Column<int>(type: "int", nullable: false),
                    MaxMemoryId = table.Column<int>(type: "int", nullable: false),
                    MemoryChannelId = table.Column<int>(type: "int", nullable: false),
                    InternalGPUSupportId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_Capacity_MaxMemoryId",
                        column: x => x.MaxMemoryId,
                        principalTable: "Enum_Capacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_CPUSocket_CPUSocketId",
                        column: x => x.CPUSocketId,
                        principalTable: "Enum_CPUSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_FormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_InternalGPUSupport_InternalGPUSupportId",
                        column: x => x.InternalGPUSupportId,
                        principalTable: "Enum_InternalGPUSupport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_MemoryChannel_MemoryChannelId",
                        column: x => x.MemoryChannelId,
                        principalTable: "Enum_MemoryChannel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_otherboardChipset_ChipsetId",
                        column: x => x.ChipsetId,
                        principalTable: "Enum_otherboardChipset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Motherboard_Enum_PUFamily_CPUFamilyId",
                        column: x => x.CPUFamilyId,
                        principalTable: "Enum_PUFamily",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PSU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    FormFactorId = table.Column<int>(type: "int", nullable: false),
                    RatingId = table.Column<int>(type: "int", nullable: false),
                    ModularId = table.Column<int>(type: "int", nullable: false),
                    PFCId = table.Column<int>(type: "int", nullable: false),
                    CoolingId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PSU_Enum_Cooling_CoolingId",
                        column: x => x.CoolingId,
                        principalTable: "Enum_Cooling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSU_Enum_FormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSU_Enum_Modular_ModularId",
                        column: x => x.ModularId,
                        principalTable: "Enum_Modular",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSU_Enum_PFC_PFCId",
                        column: x => x.PFCId,
                        principalTable: "Enum_PFC",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PSU_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PSU_Enum_Rating_RatingId",
                        column: x => x.RatingId,
                        principalTable: "Enum_Rating",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecommendedPSUWattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CUDAProcessors = table.Column<int>(type: "int", nullable: false),
                    MaxMonitors = table.Column<int>(type: "int", nullable: false),
                    MemoryBandwith = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MemoryFrequency = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BaseClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BoostClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ChipsetProducerId = table.Column<int>(type: "int", nullable: false),
                    InterfaceTypeId = table.Column<int>(type: "int", nullable: false),
                    MemoryId = table.Column<int>(type: "int", nullable: true),
                    MemoryBusId = table.Column<int>(type: "int", nullable: false),
                    MemoryTypeId = table.Column<int>(type: "int", nullable: false),
                    PowerConnectorID = table.Column<int>(type: "int", nullable: false),
                    ChipsetID = table.Column<int>(type: "int", nullable: false),
                    ResolutionID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_Capacity_MemoryId",
                        column: x => x.MemoryId,
                        principalTable: "Enum_Capacity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_Enum_Chipset_ChipsetID",
                        column: x => x.ChipsetID,
                        principalTable: "Enum_Chipset",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_InterfaceTypes_InterfaceTypeId",
                        column: x => x.InterfaceTypeId,
                        principalTable: "Enum_InterfaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_MemoryBus_MemoryBusId",
                        column: x => x.MemoryBusId,
                        principalTable: "Enum_MemoryBus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_MemoryType_MemoryTypeId",
                        column: x => x.MemoryTypeId,
                        principalTable: "Enum_MemoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_PowerConnector_PowerConnectorID",
                        column: x => x.PowerConnectorID,
                        principalTable: "Enum_PowerConnector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_Producers_ChipsetProducerId",
                        column: x => x.ChipsetProducerId,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GPU_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_GPU_Enum_Resolution_ResolutionID",
                        column: x => x.ResolutionID,
                        principalTable: "Enum_Resolution",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HDD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    CapacityId = table.Column<int>(type: "int", nullable: false),
                    InterfaceId = table.Column<int>(type: "int", nullable: false),
                    FormFactorId = table.Column<int>(type: "int", nullable: false),
                    RPMId = table.Column<int>(type: "int", nullable: false),
                    CacheId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HDD_Enum_Cache_CacheId",
                        column: x => x.CacheId,
                        principalTable: "Enum_Cache",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDD_Enum_Capacity_CapacityId",
                        column: x => x.CapacityId,
                        principalTable: "Enum_Capacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDD_Enum_FormFactor_FormFactorId",
                        column: x => x.FormFactorId,
                        principalTable: "Enum_FormFactor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDD_Enum_InterfaceTypes_InterfaceId",
                        column: x => x.InterfaceId,
                        principalTable: "Enum_InterfaceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HDD_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_HDD_Enum_RPM_RPMId",
                        column: x => x.RPMId,
                        principalTable: "Enum_RPM",
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

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cores = table.Column<int>(type: "int", nullable: false),
                    Threads = table.Column<int>(type: "int", nullable: false),
                    BaseClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    BoostClock = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    UnlockedMultiplier = table.Column<bool>(type: "bit", nullable: false),
                    Wattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaxWattage = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    InternalGPUId = table.Column<int>(type: "int", nullable: false),
                    MaxMemoryId = table.Column<int>(type: "int", nullable: false),
                    CPUSocketId = table.Column<int>(type: "int", nullable: false),
                    DataWidthId = table.Column<int>(type: "int", nullable: false),
                    CacheL1Id = table.Column<int>(type: "int", nullable: true),
                    CacheL2Id = table.Column<int>(type: "int", nullable: true),
                    CacheL3Id = table.Column<int>(type: "int", nullable: true),
                    ArchitectureId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ProducerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Architecture_ArchitectureId",
                        column: x => x.ArchitectureId,
                        principalTable: "Enum_Architecture",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Cache_CacheL1Id",
                        column: x => x.CacheL1Id,
                        principalTable: "Enum_Cache",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Cache_CacheL2Id",
                        column: x => x.CacheL2Id,
                        principalTable: "Enum_Cache",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Cache_CacheL3Id",
                        column: x => x.CacheL3Id,
                        principalTable: "Enum_Cache",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Capacity_MaxMemoryId",
                        column: x => x.MaxMemoryId,
                        principalTable: "Enum_Capacity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPU_Enum_CPUSocket_CPUSocketId",
                        column: x => x.CPUSocketId,
                        principalTable: "Enum_CPUSocket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPU_Enum_DataWidth_DataWidthId",
                        column: x => x.DataWidthId,
                        principalTable: "Enum_DataWidth",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CPU_Enum_Producers_ProducerID",
                        column: x => x.ProducerID,
                        principalTable: "Enum_Producers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CPU_GPU_InternalGPUId",
                        column: x => x.InternalGPUId,
                        principalTable: "GPU",
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

            migrationBuilder.InsertData(
                table: "Enum_CPUSocket",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "LGA_1200" },
                    { 3, "AM4" },
                    { 4, "LGA_1151" },
                    { 5, "LGA_2066" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Cache",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
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

            migrationBuilder.InsertData(
                table: "Enum_Capacity",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 16, "GB_16" },
                    { 32, "GB_32" },
                    { 64, "GB_64" },
                    { 128, "GB_128" },
                    { 256, "GB_256" },
                    { 512, "GB_526" },
                    { 1000, "TB" },
                    { 2000, "TB_2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Chipset",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "GeForce_RTX_4070_Ti" },
                    { 3, "GeForce_RTX_4080" },
                    { 4, "Radeon_RX_7600" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Yellow" },
                    { 3, "Orange" },
                    { 4, "Red" },
                    { 5, "Green" },
                    { 6, "Blue" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Color",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 7, "Purple" },
                    { 8, "White" },
                    { 9, "Black" },
                    { 10, "Silver" },
                    { 11, "Gold" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Connectors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "SATA" },
                    { 3, "PCI_E" },
                    { 4, "MOLEX" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Cooling",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 120, "Fan_120mm" },
                    { 135, "Fan_135mm" }
                });

            migrationBuilder.InsertData(
                table: "Enum_DataWidth",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 32, "Bit_32" },
                    { 64, "Bit_64" }
                });

            migrationBuilder.InsertData(
                table: "Enum_ExternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "USB_2_0" },
                    { 3, "USB_3_2_Gen_1" },
                    { 4, "USB_3_2_Gen_2" },
                    { 5, "USB_3_2_Gen_2x2" },
                    { 6, "USB_4" },
                    { 7, "USB_C" },
                    { 8, "HDMI" },
                    { 9, "DP" },
                    { 10, "VGA" },
                    { 11, "DVI" },
                    { 12, "RJ_45" },
                    { 13, "Audio" },
                    { 14, "Optical" },
                    { 15, "PS_2" },
                    { 16, "Thunderbolt_3" },
                    { 17, "Thunderbolt_4" }
                });

            migrationBuilder.InsertData(
                table: "Enum_FormFactor",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "ATX" },
                    { 3, "SFX" },
                    { 4, "Inch_2_5" },
                    { 5, "Inch_3_5" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InterfaceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "PCIExpress4_0x16" },
                    { 3, "PCI" },
                    { 4, "SATA_I" },
                    { 5, "SATA_II" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InterfaceTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "SATA_III" },
                    { 7, "M_2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InternalConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "SATA_III" },
                    { 3, "M_2" },
                    { 4, "PCIe_3_0x16" },
                    { 5, "PCIe_3_0x1" },
                    { 6, "PCIe_4_0x16" },
                    { 7, "PCIe_4_0x1" },
                    { 8, "USB_2_0" },
                    { 9, "USB_3_2_Gen_1" },
                    { 10, "USB_3_2_Gen_2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_InternalGPUSupport",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Unknown" },
                    { 2, "Yes" },
                    { 3, "No" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryBus",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 64, "Bit_64" },
                    { 128, "Bit_128" },
                    { 192, "Bit_192" },
                    { 256, "Bit_256" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryChannel",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Single" },
                    { 3, "Dual" },
                    { 4, "Quad" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryFrequency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "MHz_2133" },
                    { 3, "MHz_2400" },
                    { 4, "MHz_2666" },
                    { 5, "MHz_2800" },
                    { 6, "MHz_3000" },
                    { 7, "MHz_3200" },
                    { 8, "MHz_3600" },
                    { 9, "MHz_4000" },
                    { 10, "MHz_4266" },
                    { 11, "MHz_4400" },
                    { 12, "MHz_4600" },
                    { 13, "MHz_4800" },
                    { 14, "MHz_5000" },
                    { 15, "MHz_5200" },
                    { 16, "MHz_5333" },
                    { 17, "MHz_5600" },
                    { 18, "MHz_5800" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryFrequency",
                columns: new[] { "Id", "Name" },
                values: new object[] { 19, "MHz_6000" });

            migrationBuilder.InsertData(
                table: "Enum_MemorySlots",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "DIMM_2" },
                    { 3, "DIMM_4" },
                    { 4, "SODIMM_2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "DDR4" },
                    { 3, "GDDR5" },
                    { 4, "GDDR6" },
                    { 5, "HBM" }
                });

            migrationBuilder.InsertData(
                table: "Enum_MemoryTypeFrequency",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "DDR4_2133" },
                    { 3, "DDR4_2400" },
                    { 4, "DDR4_2666" },
                    { 5, "DDR4_2800" },
                    { 6, "DDR4_3000" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Modular",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Fully_Modular" },
                    { 3, "Semi_Modular" },
                    { 4, "Not_Modular" }
                });

            migrationBuilder.InsertData(
                table: "Enum_PFC",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Passive" },
                    { 3, "Actove" }
                });

            migrationBuilder.InsertData(
                table: "Enum_PUFamily",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "AMD" },
                    { 3, "Intel" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Ports",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "HDMI" },
                    { 3, "DP" }
                });

            migrationBuilder.InsertData(
                table: "Enum_PowerConnector",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 6, "Pin_6" },
                    { 8, "Pin_8" },
                    { 16, "Pin_16" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Producers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Intel" },
                    { 3, "AMD" }
                });

            migrationBuilder.InsertData(
                table: "Enum_ProtectionFeatures",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "OVP" },
                    { 3, "UVP" },
                    { 4, "SCP" },
                    { 5, "OLP" }
                });

            migrationBuilder.InsertData(
                table: "Enum_RAID",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "None" });

            migrationBuilder.InsertData(
                table: "Enum_RAID",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "RAID_0" },
                    { 3, "RAID_1" },
                    { 4, "RAID_5" },
                    { 5, "RAID_10" }
                });

            migrationBuilder.InsertData(
                table: "Enum_RPM",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 5400, "RPM_5400" },
                    { 7200, "RPM_7200" },
                    { 10000, "RPM_10000" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Rating",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "Plus" },
                    { 3, "Plus_Bronze" },
                    { 4, "Plus_Silver" },
                    { 5, "Plus_Gold" },
                    { 6, "Plus_Platinum" },
                    { 7, "Plus_Titanium" }
                });

            migrationBuilder.InsertData(
                table: "Enum_Resolution",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 720, "HD" },
                    { 1080, "Full_HD" },
                    { 1440, "Quad_HD" },
                    { 2160, "Ultra_HD" }
                });

            migrationBuilder.InsertData(
                table: "Enum_WirelessTechnology",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "WiFi_4" },
                    { 3, "WiFi_5" },
                    { 4, "WiFi_6" },
                    { 5, "WiFi_6E" },
                    { 6, "Bluetooth_4_0" },
                    { 7, "Bluetooth_4_2" },
                    { 8, "Bluetooth_5_0" },
                    { 9, "Bluetooth_5_1" },
                    { 10, "Bluetooth_5_2" }
                });

            migrationBuilder.InsertData(
                table: "Enum_otherboardChipset",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "None" },
                    { 2, "B450" },
                    { 3, "B550" },
                    { 4, "B760" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CPU_ArchitectureId",
                table: "CPU",
                column: "ArchitectureId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_CacheL1Id",
                table: "CPU",
                column: "CacheL1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_CacheL2Id",
                table: "CPU",
                column: "CacheL2Id");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_CacheL3Id",
                table: "CPU",
                column: "CacheL3Id");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_CPUSocketId",
                table: "CPU",
                column: "CPUSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_DataWidthId",
                table: "CPU",
                column: "DataWidthId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_InternalGPUId",
                table: "CPU",
                column: "InternalGPUId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_MaxMemoryId",
                table: "CPU",
                column: "MaxMemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CPU_ProducerID",
                table: "CPU",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_ChipsetID",
                table: "GPU",
                column: "ChipsetID");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_ChipsetProducerId",
                table: "GPU",
                column: "ChipsetProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_InterfaceTypeId",
                table: "GPU",
                column: "InterfaceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_MemoryBusId",
                table: "GPU",
                column: "MemoryBusId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_MemoryId",
                table: "GPU",
                column: "MemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_MemoryTypeId",
                table: "GPU",
                column: "MemoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_PowerConnectorID",
                table: "GPU",
                column: "PowerConnectorID");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_ProducerID",
                table: "GPU",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_GPU_ResolutionID",
                table: "GPU",
                column: "ResolutionID");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_CacheId",
                table: "HDD",
                column: "CacheId");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_CapacityId",
                table: "HDD",
                column: "CapacityId");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_FormFactorId",
                table: "HDD",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_InterfaceId",
                table: "HDD",
                column: "InterfaceId");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_ProducerID",
                table: "HDD",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_HDD_RPMId",
                table: "HDD",
                column: "RPMId");

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

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_ChipsetId",
                table: "Motherboard",
                column: "ChipsetId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_CPUFamilyId",
                table: "Motherboard",
                column: "CPUFamilyId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_CPUSocketId",
                table: "Motherboard",
                column: "CPUSocketId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_FormFactorId",
                table: "Motherboard",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_InternalGPUSupportId",
                table: "Motherboard",
                column: "InternalGPUSupportId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_MaxMemoryId",
                table: "Motherboard",
                column: "MaxMemoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_MemoryChannelId",
                table: "Motherboard",
                column: "MemoryChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_Motherboard_ProducerID",
                table: "Motherboard",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_CoolingId",
                table: "PSU",
                column: "CoolingId");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_FormFactorId",
                table: "PSU",
                column: "FormFactorId");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_ModularId",
                table: "PSU",
                column: "ModularId");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_PFCId",
                table: "PSU",
                column: "PFCId");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_ProducerID",
                table: "PSU",
                column: "ProducerID");

            migrationBuilder.CreateIndex(
                name: "IX_PSU_RatingId",
                table: "PSU",
                column: "RatingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Enum_MemoryTypeFrequency");

            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropTable(
                name: "Enum_Ports");

            migrationBuilder.DropTable(
                name: "HDD");

            migrationBuilder.DropTable(
                name: "Enum_ExternalConnector");

            migrationBuilder.DropTable(
                name: "Enum_InternalConnector");

            migrationBuilder.DropTable(
                name: "Enum_MemoryFrequency");

            migrationBuilder.DropTable(
                name: "Enum_MemorySlots");

            migrationBuilder.DropTable(
                name: "Enum_RAID");

            migrationBuilder.DropTable(
                name: "Enum_WirelessTechnology");

            migrationBuilder.DropTable(
                name: "Motherboard");

            migrationBuilder.DropTable(
                name: "Enum_Color");

            migrationBuilder.DropTable(
                name: "Enum_Connectors");

            migrationBuilder.DropTable(
                name: "Enum_ProtectionFeatures");

            migrationBuilder.DropTable(
                name: "PSU");

            migrationBuilder.DropTable(
                name: "Enum_Architecture");

            migrationBuilder.DropTable(
                name: "Enum_DataWidth");

            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.DropTable(
                name: "Enum_Cache");

            migrationBuilder.DropTable(
                name: "Enum_RPM");

            migrationBuilder.DropTable(
                name: "Enum_CPUSocket");

            migrationBuilder.DropTable(
                name: "Enum_InternalGPUSupport");

            migrationBuilder.DropTable(
                name: "Enum_MemoryChannel");

            migrationBuilder.DropTable(
                name: "Enum_otherboardChipset");

            migrationBuilder.DropTable(
                name: "Enum_PUFamily");

            migrationBuilder.DropTable(
                name: "Enum_Cooling");

            migrationBuilder.DropTable(
                name: "Enum_FormFactor");

            migrationBuilder.DropTable(
                name: "Enum_Modular");

            migrationBuilder.DropTable(
                name: "Enum_PFC");

            migrationBuilder.DropTable(
                name: "Enum_Rating");

            migrationBuilder.DropTable(
                name: "Enum_Capacity");

            migrationBuilder.DropTable(
                name: "Enum_Chipset");

            migrationBuilder.DropTable(
                name: "Enum_InterfaceTypes");

            migrationBuilder.DropTable(
                name: "Enum_MemoryBus");

            migrationBuilder.DropTable(
                name: "Enum_MemoryType");

            migrationBuilder.DropTable(
                name: "Enum_PowerConnector");

            migrationBuilder.DropTable(
                name: "Enum_Producers");

            migrationBuilder.DropTable(
                name: "Enum_Resolution");
        }
    }
}
