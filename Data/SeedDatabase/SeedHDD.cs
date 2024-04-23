using VueBase.Models;
/*
new HDD
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    Length = ,
    Width = ,
    Height = ,
    Wattage = ,
    CapacityId = (int)CapacityEnum.,
    InterfaceId = (int)ConnectorEnum.,
    FormFactorId = (int)FormFactorEnum.,
    RPMId = (int)RPMEnum.,
    CacheId = (int)CacheEnum.,
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class HDDInitializer
    {
        public static WebApplication SeedHDD(this WebApplication app, PCContext context)
        {
            try
            {
                var HDDs = context.HDD.FirstOrDefault();
                if (HDDs == null)
                {
                    context.HDD.AddRange(
                        new HDD
                        {
                            Name = "Seagate BarraCuda 2TB 3.5\"",
                            Price = 260,
                            ProducerId = (int)ProducerEnum.Seagate,
                            Length = 147,
                            Width = 101.6m,
                            Height = 20.5m,
                            CapacityId = (int)CapacityEnum.TB_2,
                            InterfaceId = (int)ConnectorEnum.SATAIII_x1,
                            FormFactorId = (int)FormFactorEnum.Inch_3_5,
                            RPMId = (int)RPMEnum.RPM7200,
                            CacheId = (int)CacheEnum.MB_256,
                        },
                        new HDD
                        {
                            Name = "Seagate BarraCuda 6TB 3.5\"",
                            Price = 699,
                            ProducerId = (int)ProducerEnum.Seagate,
                            Length = 147,
                            Width = 101.85m,
                            Height = 26.1m,
                            CapacityId = (int)CapacityEnum.TB_6,
                            InterfaceId = (int)ConnectorEnum.SATAIII_x1,
                            FormFactorId = (int)FormFactorEnum.Inch_3_5,
                            RPMId = (int)RPMEnum.RPM5400,
                            CacheId = (int)CacheEnum.MB_256,
                        },
                        new HDD
                        {
                            Name = "Seagate BarraCuda 1TB 3.5\"",
                            Price = 315,
                            ProducerId = (int)ProducerEnum.Seagate,
                            Length = 100.35m,
                            Width = 69.85m,
                            Height = 7,
                            CapacityId = (int)CapacityEnum.TB_1,
                            InterfaceId = (int)ConnectorEnum.SATAIII_x1,
                            FormFactorId = (int)FormFactorEnum.Inch_2_5,
                            RPMId = (int)RPMEnum.RPM7200,
                            CacheId = (int)CacheEnum.MB_128,
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
