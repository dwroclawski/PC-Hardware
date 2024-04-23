using System.ComponentModel.DataAnnotations;

namespace VueBase.Models
{
    public class SSD: Dimensions
    {
        public decimal ReadSpeed { get; set; }
        public decimal WriteSpeed { get; set; }
        public decimal RandomRead {  get; set; }
        public decimal RandomWrite { get; set; }
        public decimal TBW { get; set; }
        public decimal MTBF { get; set; }


        public virtual FormFactor FormFactor { get; set; }
        public int FormFactorId { get; set; }
        public FormFactorEnum FormFactorEnum => (FormFactorEnum)FormFactorId;

        public virtual Connector Interface { get; set; }
        public int InterfaceId { get; set; }
        public ConnectorEnum InterfaceEnum => (ConnectorEnum)InterfaceId;

        public virtual Capacity Capacity { get; set; }
        public int CapacityId { get; set; }
        public CapacityEnum CapacityEnum => (CapacityEnum)CapacityId;

        public virtual Cache Cache { get; set; }
        public int CacheId { get; set; }
        public CacheEnum CacheEnum => (CacheEnum)CacheId;

        public virtual CellType CellType { get; set; }
        public int CellTypeId { get; set; }
        public CellTypeEnum CellTypeEnum => (CellTypeEnum)CellTypeId;

        public virtual Heatsink Heatsink { get; set; } 
        public int HeatsinkId { get; set; }
        public HeatsinkEnum HeatsinkEnum => (HeatsinkEnum)HeatsinkId;

        public virtual Encryption Encryption { get; set; }
        public int EncryptionId { get; set; }
        public EncryptionEnum EncryptionEnum => (EncryptionEnum)EncryptionId;

        public virtual SSDKey Key { get; set; }
        public int KeyId { get; set; }
        public SSDKeyEnum KeyEnum => (SSDKeyEnum)KeyId;
        // ENUM LIST
        public ICollection<Color> Color { get; set; }
    }

    
}
