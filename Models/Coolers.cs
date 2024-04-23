using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Xml.Linq;

namespace VueBase.Models
{
    public abstract class Cooler: Dimensions
    {
        public decimal FanAirflow { get; set; } // CFM
        public decimal FanNoiseLevel { get; set; } // dB

        // ENUMS
        public virtual Fans Fans { get; set; }
        public int FansId { get; set; }
        public FansEnum FansEnum => (FansEnum)FansId;

        public virtual MTBF MTBF { get; set; }
        public int MTBFId { get; set; }
        public MTBFEnum MTBFEnum => (MTBFEnum)MTBFId;

        public virtual Connector Connector { get; set; }
        public int ConnectorId { get; set; }
        public ConnectorEnum ConnectorsEnum => (ConnectorEnum)ConnectorId;

        public virtual FanBearing FanBearing { get; set; }
        public int FanBearingId { get; set; }
        public FanBearingEnum FanBearingEnum => (FanBearingEnum)FanBearingId;

        public virtual FanSpeed FanSpeed { get; set; }
        public int FanSpeedId { get; set; }
        public FanSpeedEnum FanSpeedEnum => (FanSpeedEnum)FanSpeedId;

    }
    public class CaseCooler : Cooler 
    {
        // ENUM LIST
        public ICollection<Color> Color { get; set; }
    }
    public class CPUCooler : Cooler
    {

        public virtual CoolingType CoolingType { get; set; }
        public int CoolingTypeId { get; set; }
        public CoolingTypeEnum CoolingTypeEnum => (CoolingTypeEnum)CoolingTypeId;

        public virtual Mount Mount { get; set; }
        public int MountId { get; set; }
        public MountEnum MountEnum => (MountEnum)MountId;

        public virtual HeatPipes HeatPipes { get; set; }
        public int HeatPipesId { get; set; }
        public HeatPipesEnum HeatPipesEnum => (HeatPipesEnum)HeatPipesId;

        public virtual TDP TDP { get; set; }
        public int TDPId { get; set; }
        public TDPEnum TDPEnum => (TDPEnum)TDPId;

        // ENUM LISTS
        public ICollection<Material> Material { get; set; }
        public ICollection<Color> Color { get; set; }
        public ICollection<CPUSocket> CPUSocket { get; set; }


    }


}
