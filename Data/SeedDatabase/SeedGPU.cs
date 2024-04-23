using VueBase.Models;
/*
new GPU
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum. ,
    Length = ,
    Width = ,
    Height = ,
    RecommendedPSUWattage = ,
    Wattage = ,
    StreamProcessors = ,
    MaxMonitors = ,
    MemoryBandwith = ,
    MemoryFrequency = ,
    BaseClock = ,
    BoostClock = ,
    ChipsetProducerId = (int)ProducerEnum. ,
    InterfaceTypeId = (int)ConnectorEnum. ,
    MemoryId = (int)CapacityEnum. ,
    MemoryBusId = (int)MemoryBusEnum. ,
    MemoryTypeId = (int)MemoryTypeEnum. ,
    PowerConnectorID = (int)ConnectorEnum. ,
    ChipsetID = (int)GPUChipsetEnum. ,
    ResolutionID = (int)ResolutionEnum. ,
    Ports = new List<Connector>
    {
    }
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class GPUInitializer
    {
        public static WebApplication SeedGPU(this WebApplication app, PCContext context)
        {
            try
            {
                var GPUs = context.GPU.FirstOrDefault();
                if (GPUs == null)
                {
                    context.GPU.AddRange(
                        new GPU
                        {
                            Name = "Gigabyte GeForce RTX 4060 Eagle OC 8GB GDDR6",
                            Price = 1469,
                            ProducerId = (int)ProducerEnum.Gigabyte,
                            Length = 272,
                            Width = 115,
                            Height = 40,
                            RecommendedPSUWattage = 450,
                            Wattage = 115,
                            StreamProcessors = 3072,
                            MaxMonitorsId = (int)MaxMonitorsEnum.Four ,
                            MemoryBandwidth = 288,
                            MemoryFrequency = 17000,
                            BaseClock = 1830,
                            BoostClock = 2505,
                            ChipsetProducerId = (int)ProducerEnum.NVIDIA,
                            InterFaceId = (int)ConnectorEnum.PCIe40x8_x1,
                            MemoryId = (int)CapacityEnum.GB_8,
                            MemoryBusId = (int)MemoryBusEnum._128,
                            MemoryTypeId = (int)MemoryTypeEnum.GDDR6,
                            PowerConnectorID = (int)ConnectorEnum.ATX8_x1,
                            ChipsetID = (int)GPUChipsetEnum.GeForce_RTX_4060,
                            ResolutionID = (int)ResolutionEnum._7680x4320,
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort14a_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI21a_x2),
                            }
                        },
                        new GPU
                        {
                            Name = "Gigabyte Radeon RX 6600 EAGLE 8GB GDDR6",
                            Price = 985,
                            ProducerId = (int)ProducerEnum.Gigabyte,
                            Length = 282,
                            Width = 113,
                            Height = 41,
                            RecommendedPSUWattage = 500,
                            Wattage = 132,
                            StreamProcessors = 1792,
                            MaxMonitorsId = (int)MaxMonitorsEnum.Four,
                            MemoryBandwidth = 224,
                            MemoryFrequency = 14000,
                            BaseClock = 1750,
                            BoostClock = 2491,
                            ChipsetProducerId = (int)ProducerEnum.AMD,
                            InterFaceId = (int)ConnectorEnum.PCIe40x8_x1,
                            MemoryId = (int)CapacityEnum.GB_8,
                            MemoryBusId = (int)MemoryBusEnum._128,
                            MemoryTypeId = (int)MemoryTypeEnum.GDDR6,
                            PowerConnectorID = (int)ConnectorEnum.ATX8_x1,
                            ChipsetID = (int)GPUChipsetEnum.Radeon_RX_6600,
                            ResolutionID = (int)ResolutionEnum._7680x4320,
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort14a_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI21a_x2),
                            }
                        },
                        new GPU
                        {
                            Name = "PowerColor Radeon RX 6600 Fighter 8GB GDDR6",
                            Price = 944.26m,
                            ProducerId = (int)ProducerEnum.PowerColor,
                            Length = 200,
                            Width = 111,
                            Height = 39,
                            RecommendedPSUWattage = 500,
                            Wattage = 132,
                            StreamProcessors = 1792,
                            MaxMonitorsId = (int)MaxMonitorsEnum.Four,
                            MemoryBandwidth = 224,
                            MemoryFrequency = 14000,
                            BaseClock = 1750,
                            BoostClock = 2491, 
                            ChipsetProducerId = (int)ProducerEnum.AMD,
                            InterFaceId = (int)ConnectorEnum.PCIe40x8_x1,
                            MemoryId = (int)CapacityEnum.GB_8,
                            MemoryBusId = (int)MemoryBusEnum._128,
                            MemoryTypeId = (int)MemoryTypeEnum.GDDR6,
                            PowerConnectorID = (int)ConnectorEnum.ATX8_x1,
                            ChipsetID = (int)GPUChipsetEnum.Radeon_RX_6600,
                            ResolutionID = (int)ResolutionEnum._7680x4320,
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort14_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI21a_x1),
                            }
                        },
                        new GPU
                        {
                            Name = "Gainward GeForce RTX 4070 SUPER Ghost 12GB GDDR6X",
                            Price = 2799,
                            ProducerId = (int)ProducerEnum.Gainward,
                            Length = 269.1m,
                            Width = 131.8m,
                            Height = 40.1m,
                            RecommendedPSUWattage = 750,
                            Wattage = 220,
                            StreamProcessors = 7168,
                            MaxMonitorsId = (int)MaxMonitorsEnum.Four,
                            MemoryBandwidth = 508,
                            MemoryFrequency = 21000,
                            BaseClock = 1980,
                            BoostClock = 2475,
                            ChipsetProducerId = (int)ProducerEnum.NVIDIA,
                            InterFaceId = (int)ConnectorEnum.PCIe40x16_x1,
                            MemoryId = (int)CapacityEnum.GB_12,
                            MemoryBusId = (int)MemoryBusEnum._192,
                            MemoryTypeId = (int)MemoryTypeEnum.GDDR6X,
                            PowerConnectorID = (int)ConnectorEnum.ATX16_x1,
                            ChipsetID = (int)GPUChipsetEnum.GeForce_RTX_4070_SUPER,
                            ResolutionID = (int)ResolutionEnum._7680x4320,
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort14a_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI21a_x1),
                            }
                        },
                        new GPU
                        {
                            Name = "Gigabyte GeForce RTX 4080 SUPER Windforce V2 16GB GDDR6X",
                            Price = 5299,
                            ProducerId = (int)ProducerEnum.Gigabyte,
                            Length = 330,
                            Width = 136,
                            Height = 58,
                            RecommendedPSUWattage = 750,
                            Wattage = 320,
                            StreamProcessors = 10240,
                            MaxMonitorsId = (int)MaxMonitorsEnum.Four,
                            MemoryBandwidth = 768,
                            MemoryFrequency = 23000,
                            BaseClock = 2295,
                            BoostClock = 2550,
                            ChipsetProducerId = (int)ProducerEnum.NVIDIA,
                            InterFaceId = (int)ConnectorEnum.PCIe40x16_x1,
                            MemoryId = (int)CapacityEnum.GB_16,
                            MemoryBusId = (int)MemoryBusEnum._256,
                            MemoryTypeId = (int)MemoryTypeEnum.GDDR6X,
                            PowerConnectorID = (int)ConnectorEnum.ATX16_x1,
                            ChipsetID = (int)GPUChipsetEnum.GeForce_RTX_4080_SUPER,
                            ResolutionID = (int)ResolutionEnum._7680x4320,
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.DisplayPort14a_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.HDMI21a_x1),
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
