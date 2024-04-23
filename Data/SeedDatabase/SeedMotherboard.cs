using VueBase.Models;

/*
new Motherboard
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    MemorySlots = ,
    FormFactorId = (int)FormFactorEnum.,
    CPUSocketId = (int)CPUSocketEnum.,
    ChipsetId = (int)MotherboardChipsetEnum.,
    CPUFamilyId = (int)CPUFamilyEnum.,
    MaxMemoryId = (int)CapacityEnum.,
    MemoryChannelId = (int)MemoryChannelEnum.,
    InternalGPUSupportId = (int)InternalGPUSupportEnum.,
    MemoryConnectorTypeId = (int)MemoryConnectorTypeEnum.,
    MemoryTypeId = (int)MemoryTypeEnum.,
    InternalConnectors = new List<Connector>
    {
    },
    ExternalConnectors = new List<Connector>
    {
    },
    MemoryFrequencies = new List<MemoryFrequency>
    {
    },
    WirelessTechnologies = new List<WirelessTechnology>
    {
    },
    RAID = new List<RAID>
    {
    }
}
*/


namespace VueBase.Data.SeedDatabase
{
    public static class MotherboardInitializer
    {
        public static WebApplication SeedMotherboard(this WebApplication app, PCContext context)
        {
            try
            {
                var motherboards = context.Motherboard.FirstOrDefault();
                if (motherboards == null)
                {
                    context.Motherboard.AddRange(
                        new Motherboard
                        {
                            Name = "MSI B550-A PRO",
                            Price = 465,
                            ProducerId = (int)ProducerEnum.MSI,
                            MemorySlotsId = (int)MemorySlotsEnum.Four,
                            FormFactorId = (int)FormFactorEnum.ATX,
                            CPUSocketId = (int)CPUSocketEnum.AM4,
                            ChipsetId = (int)MotherboardChipsetEnum.AMD_B550,
                            CPUFamilyId = (int)CPUFamilyEnum.AMD,
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            InternalGPUSupportId = (int)InternalGPUSupportEnum.Yes,
                            MemoryConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR4,
                            InternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2Gen4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2Gen3_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe40x16_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe30x16_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe30x1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.FrontPanelAudio),
                            },
                            ExternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RJ45_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PS2keyboardmouse_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.AudioJack_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.FlashBIOSButton_x1),
                            },
                            MemoryFrequencies = new List<MemoryFrequency>
                            {
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._1866),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2133),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2667),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2933),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3066),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3466),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3733),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3866),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4133),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4266),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4400),
                            },
                            WirelessTechnologies = new List<WirelessTechnology>
                            {
                                context.Enum_WirelessTechnology.Single(c => c.Id == (int)WirelessTechnologyEnum.None),
                            },
                            RAID = new List<RAID>
                            {
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_0),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_1),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_10),
                            }
                        },
                        new Motherboard
                        {
                            Name = "Gigabyte B760M DS3H DDR4",
                            Price = 458,
                            ProducerId = (int)ProducerEnum.Gigabyte,
                            MemorySlotsId = (int)MemorySlotsEnum.Four,
                            FormFactorId = (int)FormFactorEnum.MicroATX,
                            CPUSocketId = (int)CPUSocketEnum._1700,
                            ChipsetId = (int)MotherboardChipsetEnum.Intel_B760,
                            CPUFamilyId = (int)CPUFamilyEnum.Intel,
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            InternalGPUSupportId = (int)InternalGPUSupportEnum.Yes,
                            MemoryConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR4,
                            InternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2PCIeNVMe40x4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe40x16_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe30x1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ARGB3_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RGB4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.COM_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.LPT_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.FrontPanelAudio),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SPDIF_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPUFan4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SYSCHAFan_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX8_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.TPM_x1)

                            },
                            ExternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.VGA_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RJ45_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PS2keyboardmouse_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.AudioJack_x3),
                            },
                            MemoryFrequencies = new List<MemoryFrequency>
                            {
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2133),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2666),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._2933),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3300),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3333),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3466),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3666),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3733),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._3866),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4133),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4266),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4300),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4500),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4700),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4933),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5133),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5333),
                            },
                            WirelessTechnologies = new List<WirelessTechnology>
                            {
                                context.Enum_WirelessTechnology.Single(c => c.Id == (int)WirelessTechnologyEnum.None),
                            },
                            RAID = new List<RAID>
                            {
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_0),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_1),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_5),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_10),
                            }
                        },
                        new Motherboard
                        {
                            Name = "ASRock B650M-HDV/M.2",
                            Price = 529,
                            ProducerId = (int)ProducerEnum.ASRock,
                            MemorySlotsId = (int)MemorySlotsEnum.Two,
                            FormFactorId = (int)FormFactorEnum.MicroATX,
                            CPUSocketId = (int)CPUSocketEnum.AM5,
                            ChipsetId = (int)MotherboardChipsetEnum.AMD_B650,
                            CPUFamilyId = (int)CPUFamilyEnum.AMD,
                            MaxMemoryId = (int)CapacityEnum.GB_96,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            InternalGPUSupportId = (int)InternalGPUSupportEnum.Yes,
                            MemoryConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR5,
                            InternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2WiFi_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2PCIeNVMe40x4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2PCIeNVMe50x4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe40x16_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe40x1_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.FrontPanelAudio),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPUFan4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SYSCHAFan_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX8_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.TPM_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Thunderbolt4_x1)
                            },
                            ExternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RJ45_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.AudioJack_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.WiFi_x2),
                            },
                            MemoryFrequencies = new List<MemoryFrequency>
                            {
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7200),
                            },
                            WirelessTechnologies = new List<WirelessTechnology>
                            {
                                context.Enum_WirelessTechnology.Single(c => c.Id == (int)WirelessTechnologyEnum.WiFi_4),
                            },
                            RAID = new List<RAID>
                            {
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_0),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_1),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_10),
                            }
                        },
                        new Motherboard
                        {
                            Name = "Gigabyte Z790 AORUS ELITE AX",
                            Price = 1175.33m,
                            ProducerId = (int)ProducerEnum.Gigabyte,
                            MemorySlotsId = (int)MemorySlotsEnum.Four,
                            FormFactorId = (int)FormFactorEnum.ATX,
                            CPUSocketId = (int)CPUSocketEnum._1700,
                            ChipsetId = (int)MotherboardChipsetEnum.Intel_Z790,
                            CPUFamilyId = (int)CPUFamilyEnum.Intel,
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            InternalGPUSupportId = (int)InternalGPUSupportEnum.Yes,
                            MemoryConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR5,
                            InternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.M2PCIeNVMe40x4_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe50x16_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe30x16x4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ARGB3_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RGB4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.FrontPanelAudio),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPUFan4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SYSCHAFan_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.AIO_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX8_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.TPM_x1),
                            },
                            ExternalConnectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.RJ45_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen2_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.AudioJack_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SPDIF_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.WiFi_x2),
                            },
                            MemoryFrequencies = new List<MemoryFrequency>
                            {
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._4800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._5800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6600),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._6800),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7000),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7200),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7400),
                                context.Enum_MemoryFrequency.Single(c => c.Id == (int)MemoryFrequencyEnum._7600),
                            },
                            WirelessTechnologies = new List<WirelessTechnology>
                            {
                                context.Enum_WirelessTechnology.Single(c => c.Id == (int)WirelessTechnologyEnum.WiFi_6E),
                                context.Enum_WirelessTechnology.Single(c => c.Id == (int)WirelessTechnologyEnum.Bluetooth),
                            },
                            RAID = new List<RAID>
                            {
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_0),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_1),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_5),
                                context.Enum_RAID.Single(c => c.Id == (int)RAIDEnum.RAID_10),
                            }
                        }
                       );
                }

                context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

            return app;
        }

    }
}
