using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VueBase.Models
{
    public class GPU : Dimensions
    {
        public decimal RecommendedPSUWattage { get; set; }
        public decimal Wattage { get; set; }
        public int StreamProcessors { get; set; }
        public decimal MemoryBandwidth { get; set; }
        public decimal MemoryFrequency { get; set; }
        public decimal BaseClock { get; set; }
        public decimal BoostClock { get; set; }

        //ENUMS

        public virtual MaxMonitors MaxMonitors { get; set; }
        public int MaxMonitorsId { get; set; }
        public MaxMonitorsEnum MaxMonitorsrEnum => (MaxMonitorsEnum)MaxMonitorsId;

        public virtual Producers ChipsetProducer { get; set; }
        public int ChipsetProducerId { get; set; }
        public ProducerEnum ChipetProducerEnum => (ProducerEnum)ChipsetProducerId;

        public virtual Connector InterFace { get; set; }
        public int? InterFaceId { get; set; }
        public ConnectorEnum InterfaceEnum => (ConnectorEnum)InterFaceId;


        public virtual Capacity Memory { get; set; }
        public int? MemoryId { get; set; }
        public CapacityEnum MemoryEnum => (CapacityEnum)MemoryId;

        public virtual MemoryBus MemoryBus { get; set; }
        public int MemoryBusId { get; set; }
        public MemoryBusEnum MemoryBusEnum => (MemoryBusEnum)MemoryBusId;

        public virtual MemoryType MemoryType{ get; set; }
        public int MemoryTypeId { get; set; }
        public MemoryTypeEnum MemoryTypeEnum => (MemoryTypeEnum)MemoryTypeId;

        public virtual Connector PowerConnector { get; set; }
        public int? PowerConnectorID { get; set; }
        public ConnectorEnum PowerConnectorEnum => (ConnectorEnum)PowerConnectorID;

        public virtual GPUChipset Chipset { get; set; }
        public int ChipsetID { get; set; }
        public GPUChipsetEnum ChipsetEnum => (GPUChipsetEnum)ChipsetID;

        public virtual Resolution Resolution { get; set; }
        public int ResolutionID { get; set; }
        public ResolutionEnum ResolutionEnum => (ResolutionEnum)ResolutionID;


        // ENUM LISTS
        public List<Connector> Ports { get; set; }

    }

 



}
