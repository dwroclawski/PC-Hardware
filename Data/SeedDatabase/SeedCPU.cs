using Microsoft.CodeAnalysis.CSharp.Syntax;
using VueBase.Models;

/*
new CPU
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum. ,
    Cores = ,
    Threads = ,
    BaseClock = ,
    BoostClock = ,
    UnlockedMultiplier = ,
    Wattage = ,
    MaxWattage = ,
    MaxMemoryId = (int)CapacityEnum. ,
    CPUSocketId = (int)CPUSocketEnum. ,
    DataWidthId = (int)DataWidthEnum. ,
    CacheL1Id = (int)CacheEnum. ,
    CacheL2Id = (int)CacheEnum. ,
    CacheL3Id = (int)CacheEnum. ,
    LithographyId = (int)LithographyEnum. ,
    MemoryChannelId = (int)MemoryChannelEnum. ,
    MicroarchitectureId = (int)MicroarchitectureEnum. ,
    InternalGPUId = (int)InternalGPUEnum. ,
    MemoryTypes = new List<MemoryTypeFrequency>
    {
    },
    MotherboardChipsetCompability = new List<MotherboardChipset>
    {
    }
}
 */
namespace VueBase.Data.SeedDatabase
{
    public static class CPUInitializer
    {
        public static WebApplication SeedCPU(this WebApplication app, PCContext context)
        {
            try
            {
                var CPUs = context.CPU.FirstOrDefault();
                if (CPUs == null)
                {
                    context.CPU.AddRange(
                        new CPU
                        {
                            Name = "Intel Core i5-12600KF",
                            Price = 1000,
                            ProducerId = (int)ProducerEnum.Intel,
                            CoresId = (int)CPUCoresEnum.Ten,
                            ThreadsId = (int)CPUThreadsEnum.Sixteen,
                            BaseClock = 3.7m,
                            BoostClock = 4.9m,
                            UnlockedMultiplierId = (int)UnlockedMultiplierEnum.Yes,
                            Wattage = 125,
                            MaxWattage = 150,
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            CPUSocketId = (int)CPUSocketEnum._1700,
                            DataWidthId = (int)DataWidthEnum._64,
                            CacheL1Id = (int)CacheEnum.KB_640,
                            CacheL2Id = (int)CacheEnum.MB_9_5,
                            CacheL3Id = (int)CacheEnum.MB_20,
                            LithographyId = (int)LithographyEnum._10,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            MicroarchitectureId = (int)MicroarchitectureEnum.AlderLake,
                            InternalGPUId = (int)InternalGPUEnum.None,
                            MemoryTypes = new List<MemoryTypeFrequency>
                            {
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR5_4800),
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR4_3200)
                            },
                            MotherboardChipsetCompatibility = new List<MotherboardChipset>
                            {
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B760),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H770),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z790),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Q670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H610),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B660),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z690),
                            }
                        },
                        new CPU
                        {
                            Name = "Intel Core i5-12400F",
                            Price = 599,
                            ProducerId = (int)ProducerEnum.Intel,
                            CoresId = (int)CPUCoresEnum.Six,
                            ThreadsId = (int)CPUThreadsEnum.Twelve,
                            BaseClock = 2.5m,
                            BoostClock = 4.4m,
                            UnlockedMultiplierId = (int)UnlockedMultiplierEnum.No,
                            Wattage = 65,
                            MaxWattage = 117,
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            CPUSocketId = (int)CPUSocketEnum._1700,
                            DataWidthId = (int)DataWidthEnum._64,
                            CacheL1Id = (int)CacheEnum.KB_384,
                            CacheL2Id = (int)CacheEnum.MB_7_5,
                            CacheL3Id = (int)CacheEnum.MB_18,
                            LithographyId = (int)LithographyEnum._10,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            MicroarchitectureId = (int)MicroarchitectureEnum.AlderLake,
                            InternalGPUId = (int)InternalGPUEnum.None,
                            MemoryTypes = new List<MemoryTypeFrequency>
                            {
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR5_4800),
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR4_3200)
                            },
                            MotherboardChipsetCompatibility = new List<MotherboardChipset>
                            {
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B760),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H770),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z790),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Q670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H610),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B660),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z690),
                            }
                        },
                        new CPU
                        {
                            Name = "AMD Ryzen 5 5600X",
                            Price = 620,
                            ProducerId = (int)ProducerEnum.AMD,
                            CoresId = (int)CPUCoresEnum.Six,
                            ThreadsId = (int)CPUThreadsEnum.Twelve,
                            BaseClock = 3.7m,
                            BoostClock = 4.6m,
                            UnlockedMultiplierId = (int)UnlockedMultiplierEnum.Yes,
                            Wattage = 65,
                            MaxWattage = 95, // cant find this info
                            MaxMemoryId = (int)CapacityEnum.GB_128 ,
                            CPUSocketId = (int)CPUSocketEnum.AM4,
                            DataWidthId = (int)DataWidthEnum._64 ,
                            CacheL1Id = (int)CacheEnum.KB_384,
                            CacheL2Id = (int)CacheEnum.MB_3,
                            CacheL3Id = (int)CacheEnum.MB_32,
                            LithographyId = (int)LithographyEnum._7,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            MicroarchitectureId = (int)MicroarchitectureEnum.Zen3,
                            InternalGPUId = (int)InternalGPUEnum.None,
                            MemoryTypes = new List<MemoryTypeFrequency>
                            {
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR4_3200)
                            },
                            MotherboardChipsetCompatibility = new List<MotherboardChipset>
                            {
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_A520),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_B450),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_B550),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_X570),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_X470),
                            }
                        },
                        new CPU
                        {
                            Name = "AMD Ryzen 5 7600",
                            Price = 919,
                            ProducerId = (int)ProducerEnum.AMD,
                            CoresId = (int)CPUCoresEnum.Six,
                            ThreadsId = (int)CPUThreadsEnum.Twelve,
                            BaseClock = 3.8m,
                            BoostClock = 5.1m,
                            UnlockedMultiplierId = (int)UnlockedMultiplierEnum.Yes,
                            Wattage = 65,
                            MaxWattage = 95, // cant find this info
                            MaxMemoryId = (int)CapacityEnum.GB_128,
                            CPUSocketId = (int)CPUSocketEnum.AM5,
                            DataWidthId = (int)DataWidthEnum._64,
                            CacheL1Id = (int)CacheEnum.KB_384,
                            CacheL2Id = (int)CacheEnum.MB_6,
                            CacheL3Id = (int)CacheEnum.MB_32,
                            LithographyId = (int)LithographyEnum._5,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            MicroarchitectureId = (int)MicroarchitectureEnum.Zen4,
                            InternalGPUId = (int)InternalGPUEnum.AMD_Radeon_Graphics,
                            MemoryTypes = new List<MemoryTypeFrequency>
                            {
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR5_5200)
                            },
                            MotherboardChipsetCompatibility = new List<MotherboardChipset>
                            {
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_A620),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_B650),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_B650E),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_X670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.AMD_X670E),
                            }
                        },
                        new CPU
                        {
                            Name = "Intel Core i5-14600KF",
                            Price = 1388.99m,
                            ProducerId = (int)ProducerEnum.Intel,
                            CoresId = (int)CPUCoresEnum.Fourteen,
                            ThreadsId = (int)CPUThreadsEnum.Twenty,
                            BaseClock = 3.5m,
                            BoostClock = 5.3m,
                            UnlockedMultiplierId = (int)UnlockedMultiplierEnum.Yes,
                            Wattage = 125,
                            MaxWattage = 181,
                            MaxMemoryId = (int)CapacityEnum.GB_192,
                            CPUSocketId = (int)CPUSocketEnum._1700,
                            DataWidthId = (int)DataWidthEnum._64,
                            CacheL1Id = (int)CacheEnum.MB_1_25,
                            CacheL2Id = (int)CacheEnum.MB_20,
                            CacheL3Id = (int)CacheEnum.MB_24,
                            LithographyId = (int)LithographyEnum._10,
                            MemoryChannelId = (int)MemoryChannelEnum.Dual,
                            MicroarchitectureId = (int)MicroarchitectureEnum.RaptorLake,
                            InternalGPUId = (int)InternalGPUEnum.None,
                            MemoryTypes = new List<MemoryTypeFrequency>
                            {
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR5_5600),
                                context.Enum_MemoryTypeFrequency.Single(c => c.Id == (int)MemoryTypeFreqencyEnum.DDR4_3200)
                            },
                            MotherboardChipsetCompatibility = new List<MotherboardChipset>
                            {
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B760),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H770),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z790),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_W680),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Q670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H610),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_H670),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_B660),
                                context.Enum_MotherboardChipset.Single(c => c.Id == (int)MotherboardChipsetEnum.Intel_Z690),
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
