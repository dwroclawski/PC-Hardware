using Microsoft.OpenApi.Writers;
using VueBase.Data;
using VueBase.Models; 



namespace VueBase
{
    public static class SSDInitializer
    {
        public static WebApplication SeedSSD(this WebApplication app, PCContext context) {

            try
            {
                var ssd = context.SSD.FirstOrDefault();
                if (ssd ==  null)
                {

                    context.SSD.AddRange(
                        new SSD
                        {
                            Name = "Lexar NM620 2TB M.2 PCIe Gen3 NVMe",
                            Price = 509.0m,
                            ProducerId = (int)Models.ProducerEnum.Lexar,
                            Length = 80,
                            Width = 22,
                            Height = 2.25m,
                            ReadSpeed = 3300,
                            WriteSpeed = 3000,
                            RandomRead = 300000,
                            RandomWrite = 256000,
                            TBW = 1000,
                            MTBF = 1500000,
                            FormFactorId = (int)Models.FormFactorEnum.M2_2280,
                            InterfaceId = (int)Models.ConnectorEnum.PCIe30x4NVMe_x1,
                            CapacityId = (int)Models.CapacityEnum.TB_2,
                            CacheId = (int)Models.CacheEnum.Unknown,
                            CellTypeId = (int)Models.CellTypeEnum.TLC,
                            HeatsinkId = (int)Models.HeatsinkEnum.No,
                            EncryptionId = (int)Models.EncryptionEnum.No,
                            KeyId = (int)Models.SSDKeyEnum.M,
                            Color = new List<Models.Color> { context.Enum_Color.Single(c => c.Id == (int)Models.ColorEnum.Black) }
                        },
                        new SSD
                        {
                            Name = "Lexar NM620 1TB M.2 PCIe Gen3 NVMe",
                            Price = 294.62m,
                            ProducerId = (int)Models.ProducerEnum.Lexar,
                            Length = 80,
                            Width = 22,
                            Height = 2.25m,
                            ReadSpeed = 3300,
                            WriteSpeed = 3000,
                            RandomRead = 300000,
                            RandomWrite = 256000,
                            TBW = 500,
                            MTBF = 1500000,
                            FormFactorId = (int)Models.FormFactorEnum.M2_2280,
                            InterfaceId = (int)Models.ConnectorEnum.PCIe30x4NVMe_x1,
                            CapacityId = (int)Models.CapacityEnum.TB_1,
                            CacheId = (int)Models.CacheEnum.Unknown,
                            CellTypeId = (int)Models.CellTypeEnum.TLC,
                            HeatsinkId = (int)Models.HeatsinkEnum.No,
                            EncryptionId = (int)Models.EncryptionEnum.No,
                            KeyId = (int)Models.SSDKeyEnum.M,
                            Color = new List<Models.Color> { context.Enum_Color.Single(c => c.Id == (int)Models.ColorEnum.Black)}
                        },
                        new Models.SSD
                        {
                            Name = "Lexar NM620 512GB M.2 PCIe Gen3 NVMe",
                            Price = 179.0m,
                            ProducerId = (int)Models.ProducerEnum.Lexar,
                            Length = 80,
                            Width = 22,
                            Height = 2.25m,
                            ReadSpeed = 3300,
                            WriteSpeed = 2400,
                            RandomRead = 200000,
                            RandomWrite = 256000,
                            TBW = 250,
                            MTBF = 1500000,
                            FormFactorId = (int)Models.FormFactorEnum.M2_2280,
                            InterfaceId = (int)Models.ConnectorEnum.PCIe30x4NVMe_x1,
                            CapacityId = (int)Models.CapacityEnum.GB_512,
                            CacheId = (int)Models.CacheEnum.Unknown,
                            CellTypeId = (int)Models.CellTypeEnum.TLC,
                            HeatsinkId = (int)Models.HeatsinkEnum.No,
                            EncryptionId = (int)Models.EncryptionEnum.No,
                            KeyId = (int)Models.SSDKeyEnum.M,
                            Color = new List<Models.Color> { context.Enum_Color.Single(c => c.Id == (int)Models.ColorEnum.Black) }
                        },
                        new Models.SSD
                        {
                            Name = "Lexar NM620 256GB M.2 PCIe Gen3 NVMe",
                            Price = 109.9m,
                            ProducerId = (int)Models.ProducerEnum.Lexar,
                            Length = 80,
                            Width = 22,
                            Height = 2.25m,
                            ReadSpeed = 3000,
                            WriteSpeed = 1300,
                            RandomRead = 92000,
                            RandomWrite = 240000,
                            TBW = 125,
                            MTBF = 1500000,
                            FormFactorId = (int)Models.FormFactorEnum.M2_2280,
                            InterfaceId = (int)Models.ConnectorEnum.PCIe30x4NVMe_x1,
                            CapacityId = (int)Models.CapacityEnum.GB_256,
                            CacheId = (int)Models.CacheEnum.Unknown,
                            CellTypeId = (int)Models.CellTypeEnum.TLC,
                            HeatsinkId = (int)Models.HeatsinkEnum.No,
                            EncryptionId = (int)Models.EncryptionEnum.No,
                            KeyId = (int)Models.SSDKeyEnum.M,
                            Color = new List<Models.Color> { context.Enum_Color.Single(c => c.Id == (int)Models.ColorEnum.Black) }
                        },
                        new Models.SSD
                        {
                            Name = "Samsung 990 PRO 4TB M.2 PCIe Gen4 NVMe",
                            Price = 1617.58m,
                            ProducerId = (int)Models.ProducerEnum.Samsung,
                            Length = 80,
                            Width = 22,
                            Height = 2.3m,
                            ReadSpeed = 7450,
                            WriteSpeed = 6900,
                            RandomRead = 1400000,
                            RandomWrite = 1550000,
                            TBW = 2400,
                            MTBF = 1500000,
                            FormFactorId = (int)Models.FormFactorEnum.M2_2280,
                            InterfaceId = (int)Models.ConnectorEnum.PCIe40x4NVMe_x1,
                            CapacityId = (int)Models.CapacityEnum.TB_4,
                            CacheId = (int)Models.CacheEnum.GB_4,
                            CellTypeId = (int)Models.CellTypeEnum.TLC,
                            HeatsinkId = (int)Models.HeatsinkEnum.No,
                            EncryptionId = (int)Models.EncryptionEnum.Yes,
                            KeyId = (int)Models.SSDKeyEnum.M,
                            Color = new List<Models.Color> { context.Enum_Color.Single(c => c.Id == (int)Models.ColorEnum.Black) }
                        },
                        new SSD
                        {
                            Name= "Lexar NM790 1TB M.2 PCIe Gen4 NVMe",
                            Price = 349,
                            ProducerId = (int)ProducerEnum.Lexar,
                            Length = 80,
                            Width = 22,
                            Height = 2.45m,
                            ReadSpeed = 7400,
                            WriteSpeed = 6500,
                            RandomRead = 1000000,
                            RandomWrite = 900000,
                            TBW = 1000,
                            MTBF = 1500000,
                            FormFactorId = (int)FormFactorEnum.M2_2280,
                            InterfaceId = (int)ConnectorEnum.PCIe40x4NVMe_x1,
                            CapacityId = (int)CapacityEnum.TB_1,
                            CacheId = (int)CacheEnum.Unknown,
                            CellTypeId = (int)CellTypeEnum.TLC,
                            HeatsinkId = (int)HeatsinkEnum.No,
                            EncryptionId = (int)EncryptionEnum.No,
                            KeyId = (int)SSDKeyEnum.M,
                            Color = new List<Color> { context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black) }
                        },
                        new SSD
                        {
                            Name = "Kingston KC3000 2TB M.2 PCIe Gen4 NVMe",
                            Price = 679,
                            ProducerId = (int)ProducerEnum.Kingston,
                            Length = 80,
                            Width = 22,
                            Height = 3.5m,
                            ReadSpeed = 7000,
                            WriteSpeed = 7000,
                            RandomRead = 1000000,
                            RandomWrite = 1000000,
                            TBW = 1600,
                            MTBF = 1800000,
                            FormFactorId = (int)FormFactorEnum.M2_2280,
                            InterfaceId = (int)ConnectorEnum.PCIe40x4NVMe_x1,
                            CapacityId = (int)CapacityEnum.TB_2,
                            CacheId = (int)CacheEnum.Unknown,
                            CellTypeId = (int)CellTypeEnum.TLC,
                            HeatsinkId = (int)HeatsinkEnum.Yes,
                            EncryptionId = (int)EncryptionEnum.No,
                            KeyId = (int)SSDKeyEnum.M,
                            Color = new List<Color> { context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black) }
                        }
                        );

                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
            return app;

        }
    }
}
