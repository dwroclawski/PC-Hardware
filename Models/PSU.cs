using System.ComponentModel.DataAnnotations;

namespace VueBase.Models
{
    public class PSU : Dimensions
    {
        public decimal Wattage { get; set; }

        //ENUMS
        public virtual FormFactor FormFactor { get; set; }
        public int FormFactorId { get; set; }
        public FormFactorEnum FormFactorEnum => (FormFactorEnum)FormFactorId;

        public virtual Rating Rating { get; set; }
        public int RatingId { get; set; }
        public RatingEnum RatingEnum => (RatingEnum)RatingId;

        public virtual Modular Modular { get; set; }
        public int ModularId { get; set; }
        public ModularEnum ModularEnum => (ModularEnum)ModularId;

        public virtual PFC PFC { get; set; }
        public int PFCId { get; set; }
        public PFCEnum PFCEnum => (PFCEnum)PFCId;

        public virtual Cooling Cooling { get; set; }
        public int CoolingId { get; set; }
        public CoolingEnum CoolingEnum => (CoolingEnum)CoolingId;

        // ENUM LIST
        public ICollection<Connector> Connectors { get; set; }
        public ICollection<ProtectionFeatures> ProtectionFeatures { get; set; }
        public ICollection<Color> Color { get; set; }
    }




}
