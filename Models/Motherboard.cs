using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VueBase.Models
{
    public class Motherboard : Base
    {

        public virtual MemorySlots MemorySlots { get; set; }
        public int MemorySlotsId { get; set; }
        public MemorySlotsEnum MemorySlotsEnum => (MemorySlotsEnum)MemorySlotsId;

        public virtual FormFactor FormFactor { get; set; }
        public int FormFactorId { get; set; }
        public FormFactorEnum FormFactorEnum => (FormFactorEnum)FormFactorId;

        public virtual CPUSocket CPUSocket { get; set; }
        public int CPUSocketId { get; set; }
        public CPUSocketEnum CPUSocketEnum => (CPUSocketEnum)CPUSocketId;

        public virtual MotherboardChipset Chipset { get; set; }
        public int ChipsetId { get; set; }
        public MotherboardChipsetEnum ChipsetEnum => (MotherboardChipsetEnum)ChipsetId;

        public virtual CPUFamily CPUFamily { get; set; }
        public int CPUFamilyId { get; set; }
        public CPUFamilyEnum CPUFamilyEnum => (CPUFamilyEnum)CPUFamilyId;

        public virtual Capacity MaxMemory { get; set; }
        public int MaxMemoryId { get; set; }
        public CapacityEnum MaxMemoryEnum => (CapacityEnum)MaxMemoryId;

        public virtual MemoryChannel MemoryChannel { get; set; }
        public int MemoryChannelId { get; set; }
        public MemoryChannelEnum MemoryChannelEnum => (MemoryChannelEnum)MemoryChannelId;

        public virtual InternalGPUSupport InternalGPUSupport { get; set; }
        public int InternalGPUSupportId { get; set; }
        public InternalGPUSupportEnum InternalGPUSupportEnum => (InternalGPUSupportEnum)InternalGPUSupportId;

        public virtual MemoryConnectorType MemoryConnectorType { get; set; }
        public int MemoryConnectorTypeId { get; set; }
        public MemoryConnectorTypeEnum MemoryConnectorTypeEnum => (MemoryConnectorTypeEnum)MemoryConnectorTypeId;

        public virtual MemoryType MemoryType { get; set; }
        public int MemoryTypeId { get; set; }
        public MemoryTypeEnum MemoryTypeEnum => (MemoryTypeEnum)MemoryTypeId;


        //EnNUM LIST
        public ICollection<Connector> InternalConnectors { get; set; }
        public ICollection<Connector> ExternalConnectors { get; set; }
        public ICollection<MemoryFrequency> MemoryFrequencies { get; set; }
        public ICollection<WirelessTechnology> WirelessTechnologies { get; set; }
        public ICollection<RAID> RAID { get; set; }

    }



}