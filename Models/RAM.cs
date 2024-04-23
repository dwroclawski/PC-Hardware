    using System.ComponentModel.DataAnnotations;

namespace VueBase.Models { 
public class RAM :Base
    {

        public virtual MemorySlots Modules { get; set; }
        public int ModulesId { get; set; }
        public MemorySlotsEnum ModulesEnum => (MemorySlotsEnum)ModulesId;
        public virtual CoolingType CoolingType { get; set; }
        public int CoolingTypeId { get; set; }
        public CoolingTypeEnum CoolingTypeEnum => (CoolingTypeEnum)CoolingTypeId;

        public virtual MemoryFrequency MemoryFrequency { get; set; }
        public int MemoryFrequencyId { get; set; }
        public MemoryFrequencyEnum MemoryFrequencyEnum => (MemoryFrequencyEnum)MemoryFrequencyId;

        public virtual Voltage Voltage { get; set; }
        public int VoltageId { get; set; }
        public VoltageEnum VoltageEnum => (VoltageEnum)VoltageId;

        public virtual Capacity Memory { get; set; }
        public int MemoryId { get; set; }
        public CapacityEnum MemoryEnum => (CapacityEnum)MemoryId;

        public virtual MemoryType MemoryType { get; set; }
        public int MemoryTypeId { get; set; }
        public MemoryTypeEnum MemoryTypeEnum => (MemoryTypeEnum)MemoryTypeId;

        public virtual MemoryConnectorType ConnectorType { get; set; }
        public int ConnectorTypeId { get; set; }
        public MemoryConnectorTypeEnum MemorySlotsEnum => (MemoryConnectorTypeEnum)ConnectorTypeId;

        public virtual CycleLatency CycleLatency { get; set; }
        public int CycleLatencyId { get; set; }
        public CycleLatencyEnum CycleLatencyEnum => (CycleLatencyEnum)CycleLatencyId;

        // ENUM LIST
        public ICollection<Color> Color { get; set; }
        public ICollection<Overclocking> Overclocking { get; set; }


    }


}
