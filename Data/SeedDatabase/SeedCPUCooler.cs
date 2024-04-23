using VueBase.Models;
/*
new CPUCooler
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    Length = ,
    Width = ,
    Height = ,
    FanAirflow = ,
    FanNoiseLevel = ,
    FansId = (int)FansEnum.,
    MTBFId = (int)MTBFEnum.,
    ConnectorId = (int)ConnectorEnum.,
    FanBearingId = (int)FanBearingEnum.,
    FanSpeedId = (int)FanSpeedEnum.,
    CoolingTypeId = (int)CoolingTypeEnum.,
    MountId = (int)MountEnum.,
    HeatPipesId = (int)HeatPipesEnum.,
    TDPId = (int)TDPEnum.,
    Material = new List<Material>
    {
        context.Enum_Material.FirstOrDefault(c => c.Id == (int)MaterialEnum.),
    },
    Color = new List<Color>
    {
        context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.),
    },
    CPUSocket = new List<CPUSocket>
    {
        context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.),
    },
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class CPUCoolerInitializer
    {
        public static WebApplication SeedCPUCooler(this WebApplication app, PCContext context)
        {
            try
            {
                var CPUCoolers = context.CPUCooler.FirstOrDefault();
                if (CPUCoolers == null)
                {
                    context.CPUCooler.AddRange(
                        new CPUCooler
                        {
                            Name = "ENDORFY Fera 5 120mm",
                            Price = 136,
                            ProducerId = (int)ProducerEnum.ENDORFY,
                            Length = 77,
                            Width = 127,
                            Height = 155,
                            FanAirflow = 0,
                            FanNoiseLevel = 0,
                            FansId = (int)FansEnum._1x120,
                            MTBFId = (int)MTBFEnum.MTBF100_000,
                            ConnectorId = (int)ConnectorEnum.PWM4_x1,
                            FanBearingId = (int)FanBearingEnum.FluidDynamic,
                            FanSpeedId = (int)FanSpeedEnum._250_1800,
                            CoolingTypeId = (int)CoolingTypeEnum.Active,
                            MountId = (int)MountEnum.Vertical,
                            HeatPipesId = (int)HeatPipesEnum._4x6,
                            TDPId = (int)TDPEnum.W220,
                            Material = new List<Material>
                            {
                                context.Enum_Material.FirstOrDefault(c => c.Id == (int)MaterialEnum.Copper),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
                            },
                            CPUSocket = new List<CPUSocket>
                            {
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2066),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011_3),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1700),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1366),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1200),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1156),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1155),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1151),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1150),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._775),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM5),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM4),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM3Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM2Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.FM2Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.FM1)
                            },
                        },
                        new CPUCooler
                        {
                            Name = "Silver Monkey X SNOWY BLACKOUT 240 2x120 mm",
                            Price = 339,
                            ProducerId = (int)ProducerEnum.SilverMonkeyX,
                            Length = 120,
                            Width = 274,
                            Height = 52,
                            FanAirflow = 70,
                            FanNoiseLevel = 28.9m,
                            FansId = (int)FansEnum._2x120,
                            MTBFId = (int)MTBFEnum.MTBF50_000,
                            ConnectorId = (int)ConnectorEnum.PWM4_x1,
                            FanBearingId = (int)FanBearingEnum.Hydraulic,
                            FanSpeedId = (int)FanSpeedEnum._600_1500,
                            CoolingTypeId = (int)CoolingTypeEnum.Water,
                            MountId = (int)MountEnum.None,
                            HeatPipesId = (int)HeatPipesEnum.None,
                            TDPId = (int)TDPEnum.W250,
                            Material = new List<Material>
                            {
                                context.Enum_Material.FirstOrDefault(c => c.Id == (int)MaterialEnum.Aluminium),
                                context.Enum_Material.FirstOrDefault(c => c.Id == (int)MaterialEnum.Copper),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
                            },
                            CPUSocket = new List<CPUSocket>
                            {
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2066),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011_3),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1700),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1200),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1156),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1155),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1151),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1150),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM5),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM4),
                            },
                        },
                        new CPUCooler
                        {
                            Name = "ENDORFY Navis F280",
                            Price = 459,
                            ProducerId = (int)ProducerEnum.ENDORFY,
                            Length = 140,
                            Width = 310,
                            Height = 54,
                            FanAirflow = 0,
                            FanNoiseLevel = 0,
                            FansId = (int)FansEnum._2x140,
                            MTBFId = (int)MTBFEnum.MTBF100_000,
                            ConnectorId = (int)ConnectorEnum.PWM4_x1,
                            FanBearingId = (int)FanBearingEnum.FluidDynamic,
                            FanSpeedId = (int)FanSpeedEnum._250_1800,
                            CoolingTypeId = (int)CoolingTypeEnum.Water,
                            MountId = (int)MountEnum.None,
                            HeatPipesId = (int)HeatPipesEnum.None,
                            TDPId = (int)TDPEnum.None,
                            Material = new List<Material>
                            {
                                context.Enum_Material.FirstOrDefault(c => c.Id == (int)MaterialEnum.Aluminium),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
                            },
                            CPUSocket = new List<CPUSocket>
                            {
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2066),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011_3),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._2011),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1700),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1366),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1200),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1156),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1155),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1151),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._1150),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum._775),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM5),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM4),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM3Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.AM2Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.FM2Plus),
                                context.Enum_CPUSocket.FirstOrDefault(c => c.Id == (int)CPUSocketEnum.FM1)
                            },
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
