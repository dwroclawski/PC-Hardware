using System.ComponentModel.DataAnnotations;


namespace VueBase.Models
{
    public class Case: Dimensions
    {
        public int MaxFanCount { get; set; }
        public int InstalledFanCount { get; set; }
        public int ExpansionSlots { get; set; }
        public decimal MaxGPULength { get; set; }
        public decimal MaxCPUCoolerHeight { get; set; }

        public virtual Material SidePanelMaterial { get; set; }
        public int? SidePanelMaterialId { get; set; }
        public MaterialEnum MaterialEnum => (MaterialEnum)SidePanelMaterialId;

        public CaseType Type { get; set; }
        public int TypeId { get; set; }
        public CaseTypeEnum CaseTypeEnum => (CaseTypeEnum)TypeId;

        // ENUM LISTS
        public ICollection<Material> Material { get; set; }
        public ICollection<Connector> Ports { get; set; }
        public ICollection<FormFactor> FormFactor { get; set; }
        public ICollection<FormFactor> PSUMount { get; set; }
        public ICollection<Buttons> Buttons { get; set; }
        public ICollection<DriveBay> DriveBay { get; set; }
        public ICollection<Color> Color { get; set; }
        public ICollection<Fans> InstalledFans { get; set; }
        public ICollection<Fans> FanBays { get; set; }
        public ICollection<WaterCoolingSlots> WaterCoolingSlots { get; set; }


    }
   
}
