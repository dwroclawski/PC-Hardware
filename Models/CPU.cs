using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace VueBase.Models
{
    public class CPU : Base
    {

        public decimal BaseClock { get; set; }
        public decimal BoostClock { get; set; }
        public decimal Wattage { get; set; }
        public decimal MaxWattage { get; set; }



        // ENUM 

        public virtual UnlockedMultiplier UnlockedMultiplier { get; set; }
        public int UnlockedMultiplierId { get; set; }
        public UnlockedMultiplierEnum UnlockedMultiplierEnum => (UnlockedMultiplierEnum)UnlockedMultiplierId;


        public virtual CPUThreads Threads { get; set; }
        public int ThreadsId { get; set; }
        public CPUThreadsEnum ThreadsEnum => (CPUThreadsEnum)ThreadsId;

        public virtual CPUCores Cores { get; set; }
        public int CoresId { get; set; }
        public CPUCoresEnum CoresEnum => (CPUCoresEnum)CoresId;

        public virtual Capacity MaxMemory { get; set; }
        public int MaxMemoryId { get; set; }
        public CapacityEnum MaxMemoryEnum => (CapacityEnum)MaxMemoryId;

        public virtual CPUSocket CPUSocket { get; set; }
        public int CPUSocketId { get; set; }
        public CPUSocketEnum CPUSocketEnum => (CPUSocketEnum)CPUSocketId;

        public virtual DataWidth DataWidth { get; set; }
        public int DataWidthId { get; set; }
        public DataWidthEnum DataWidthEnum => (DataWidthEnum)DataWidthId;

        public virtual Cache CacheL1 { get; set; }
        public int? CacheL1Id { get; set; }
        public CacheEnum CacheL1Enum => (CacheEnum)CacheL1Id;

        public virtual Cache CacheL2 { get; set; }
        public int? CacheL2Id { get; set; }
        public CacheEnum CacheL2Enum => (CacheEnum)CacheL2Id;

        public virtual Cache CacheL3 { get; set; }
        public int? CacheL3Id { get; set; }
        public CacheEnum CacheL3Enum => (CacheEnum)CacheL3Id;

        public virtual Lithography Lithography { get; set; } 
        public int LithographyId { get; set; }
        public LithographyEnum LithographyEnum => (LithographyEnum)LithographyId;

        public virtual MemoryChannel MemoryChannel { get; set; }
        public int MemoryChannelId { get; set; }
        public MemoryChannelEnum MemoryChannelEnum => (MemoryChannelEnum)MemoryChannelId;

        public virtual Microarchitecture Microarchitecture { get; set; }
        public int MicroarchitectureId { get; set; }
        public MicroarchitectureEnum MicroarchitectureEnum => (MicroarchitectureEnum) MicroarchitectureId;

        public virtual InternalGPU InternalGPU { get; set; }
        public int InternalGPUId { get; set; }
        public InternalGPUEnum InternalGPUEnum => (InternalGPUEnum)InternalGPUId;

        // ENUM LIST 
        public ICollection<MemoryTypeFrequency> MemoryTypes { get; set; }
        public ICollection<MotherboardChipset> MotherboardChipsetCompatibility { get; set; }
    }

   
}