using VueBase.Models;
/*
new RAM
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    Modules = ,
    CoolingTypeId = (int)CoolingTypeEnum.,
    MemoryFrequencyId = (int)MemoryFrequencyEnum.,
    VoltageId = (int)VoltageEnum.,
    MemoryId = (int)CapacityEnum.,
    MemoryTypeId = (int)MemoryTypeEnum.,
    ConnectorTypeId = (int)MemoryConnectorTypeEnum.,
    CycleLatencyId = (int)CycleLatencyEnum.,
    OverclockingId = (int)OverclockingEnum.,
    Color = new List<Color>
    {
    }
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class RAMInitializer
    {
        public static WebApplication SeedRAM(this WebApplication app, PCContext context)
        {
            try
            {
                var RAMs = context.RAM.FirstOrDefault();
                if (RAMs == null)
                {
                    context.RAM.AddRange(
                        new RAM
                        {
                            Name = "Kingston FURY Beast DDR4 16GB (2x8GB) 3200MHz CL16",
                            Price = 195,
                            ProducerId = (int)ProducerEnum.Kingston,
                            ModulesId = (int)MemorySlotsEnum.Two,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._3200,
                            VoltageId = (int)VoltageEnum.V1_35,
                            MemoryId = (int)CapacityEnum.GB_16,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR4,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL16,
                            Overclocking = new List<Overclocking> 
                            { 
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_2)
                            }, 
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new RAM
                        {
                            Name = "Kingston FURY Beast DDR4 32GB (1x32GB) 3200MHz CL16",
                            Price = 329,
                            ProducerId = (int)ProducerEnum.Kingston,
                            ModulesId = (int)MemorySlotsEnum.One,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._3200,
                            VoltageId = (int)VoltageEnum.V1_35,
                            MemoryId = (int)CapacityEnum.GB_32,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR4,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL16,
                            Overclocking = new List<Overclocking>
                            {
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_2)
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new RAM
                        {
                            Name = "Kingston FURY Beast DDR4 16GB (2x8GB) 3600MHz CL17",
                            Price = 204.52m,
                            ProducerId = (int)ProducerEnum.Kingston,
                            ModulesId = (int)MemorySlotsEnum.Two,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._3600,
                            VoltageId = (int)VoltageEnum.V1_35,
                            MemoryId = (int)CapacityEnum.GB_16,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR4,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL17,
                            Overclocking = new List<Overclocking>
                            {
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_2)
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new RAM
                        {
                            Name = "Patriot Viper Venom DDR5 32GB (2x16GB) 6000Mhz CL36",
                            Price = 489,
                            ProducerId = (int)ProducerEnum.Patriot,
                            ModulesId = (int)MemorySlotsEnum.Two,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._6000,
                            VoltageId = (int)VoltageEnum.V1_35,
                            MemoryId = (int)CapacityEnum.GB_32,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR5,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL36,
                            Overclocking = new List<Overclocking>
                            {
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_3)
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new RAM
                        {
                            Name = "Kingston FURY Beast DDR5 32GB (2x16GB) 5200MHz CL40",
                            Price = 459,
                            ProducerId = (int)ProducerEnum.Kingston,
                            ModulesId = (int)MemorySlotsEnum.Two,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._5200,
                            VoltageId = (int)VoltageEnum.V1_25,
                            MemoryId = (int)CapacityEnum.GB_32,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR5,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL40,
                            Overclocking = new List<Overclocking>
                            {
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_3)
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new RAM
                        {
                            Name = "Lexar Ares DDR5 32GB (2x16GB) 6400MHz CL32",
                            Price = 529,
                            ProducerId = (int)ProducerEnum.Lexar,
                            ModulesId = (int)MemorySlotsEnum.Two,
                            CoolingTypeId = (int)CoolingTypeEnum.Heatsink,
                            MemoryFrequencyId = (int)MemoryFrequencyEnum._6400,
                            VoltageId = (int)VoltageEnum.V1_4,
                            MemoryId = (int)CapacityEnum.GB_32,
                            MemoryTypeId = (int)MemoryTypeEnum.DDR5,
                            ConnectorTypeId = (int)MemoryConnectorTypeEnum.DIMM,
                            CycleLatencyId = (int)CycleLatencyEnum.CL32,
                            Overclocking = new List<Overclocking>
                            {
                                context.Enum_Overclocking.Single(o => o.Id == (int)OverclockingEnum.Intel_XMP_3)
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
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
