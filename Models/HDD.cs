using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;

namespace VueBase.Models
{
    public class HDD : Dimensions
    {

        //ENUMS
        public virtual Capacity Capacity { get; set; }
        public int CapacityId { get; set; }
        public CapacityEnum CapacityEnum => (CapacityEnum)CapacityId;

        public virtual Connector InterFace { get; set; }
        public int InterfaceId { get; set; }
        public ConnectorEnum InterfaceEnum => (ConnectorEnum)InterfaceId;

        public virtual FormFactor FormFactor { get; set; }
        public int FormFactorId { get; set; }
        public FormFactorEnum FormFactorEnum => (FormFactorEnum)FormFactorId;

        public virtual RPM RPM { get; set; }
        public int RPMId { get; set; }
        public RPMEnum RPMEnum => (RPMEnum)RPMId;

        public virtual Cache Cache { get; set; }
        public int CacheId { get; set; }
        public CacheEnum CacheEnum => (CacheEnum)CacheId;
    }

   
}
