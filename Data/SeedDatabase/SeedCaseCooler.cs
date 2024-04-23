using VueBase.Models;
/*
new CaseCooler
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
    Color = new List<Color>
    {
        context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.),
    },
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class CaseCoolerInitializer
    {
        public static WebApplication SeedCaseCooler(this WebApplication app, PCContext context)
        {
            try
            {
                var CaseCoolers = context.CaseCooler.FirstOrDefault();
                if (CaseCoolers == null)
                {
                    context.CaseCooler.AddRange(
                        new CaseCooler
                        {
                            Name = "ENDORFY Stratus 120 PWM",
                            Price = 28,
                            ProducerId = (int)ProducerEnum.ENDORFY,
                            Length = 25,
                            Width = 120,
                            Height = 120,
                            FanAirflow = 0,
                            FanNoiseLevel = 0,
                            FansId = (int)FansEnum._1x120,
                            MTBFId = (int)MTBFEnum.MTBF80_000,
                            ConnectorId = (int)ConnectorEnum.PWM4_x1,
                            FanBearingId = (int)FanBearingEnum.FluidDynamic,
                            FanSpeedId = (int)FanSpeedEnum._1400,
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
                            },
                        },
                        new CaseCooler
                        {
                            Name = "Genesis Oxal 120 Triple Pack",
                            Price = 50,
                            ProducerId = (int)ProducerEnum.Genesis,
                            Length = 25,
                            Width = 120,
                            Height = 120,
                            FanAirflow = 46.1m,
                            FanNoiseLevel = 22.1m,
                            FansId = (int)FansEnum._3x120,
                            MTBFId = (int)MTBFEnum.MTBF50_000,
                            ConnectorId = (int)ConnectorEnum._3pin_x1,
                            FanBearingId = (int)FanBearingEnum.Sleeve,
                            FanSpeedId = (int)FanSpeedEnum._1300,
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
                            },
                        },
                        new CaseCooler
                        {
                            Name = "be quiet! Pure Wings 2 140mm PWM",
                            Price = 75,
                            ProducerId = (int)ProducerEnum.bequiet,
                            Length = 25,
                            Width = 140,
                            Height = 140,
                            FanAirflow = 61.2m,
                            FanNoiseLevel = 19.8m,
                            FansId = (int)FansEnum._1x140,
                            MTBFId = (int)MTBFEnum.MTBF80_000,
                            ConnectorId = (int)ConnectorEnum.PWM4_x1,
                            FanBearingId = (int)FanBearingEnum.Rifle,
                            FanSpeedId = (int)FanSpeedEnum._1000,
                            Color = new List<Color>
                            {
                                context.Enum_Color.FirstOrDefault(c => c.Id == (int)ColorEnum.Black),
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
