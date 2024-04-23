using VueBase.Models;
/*
new PSU
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    Length = ,
    Width = ,
    Height = ,
    Wattage = ,
    FormFactorId = (int)FormFactorEnum.,
    RatingId = (int)RatingEnum.,
    ModularId = (int)ModularEnum.,
    PFCId = (int)PFCEnum.,
    CoolingId = (int)CoolingEnum.,
    Connectors = new List<Connector>
    {
    }, 
    ProtectionFeatures = new List<ProtectionFeatures>
    {
    },
    Color = new List<Color>
    {
    }
}
*/
namespace VueBase.Data.SeedDatabase
{
    public static class PSUInitializer
    {
        public static WebApplication SeedPSU(this WebApplication app, PCContext context)
        {
            try
            {

                var PSUs = context.PSU.FirstOrDefault();
                if (PSUs == null)
                {
                    context.PSU.AddRange(
                        new PSU
                        {
                            Name = "ENDORFY Supremo FM5 Gold 750W",
                            Price = 459,
                            ProducerId = (int)ProducerEnum.ENDORFY,
                            Length = 150,
                            Width = 140,
                            Height = 87,
                            Wattage = 750,
                            FormFactorId = (int)FormFactorEnum.ATX,
                            RatingId = (int)RatingEnum._80PLUSGold,
                            ModularId = (int)ModularEnum.FullyModular,
                            PFCId = (int)PFCEnum.Active,
                            CoolingId = (int)CoolingEnum._120mmFan,
                            Connectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x8),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Molex4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU44_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe2062_x3),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                            }, 
                            ProtectionFeatures = new List<ProtectionFeatures>
                            {
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OPP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OTP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.UVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SIP),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new PSU
                        {
                            Name = "ENDORFY Vero L5 Bronze 600W",
                            Price = 249,
                            ProducerId = (int)ProducerEnum.ENDORFY,
                            Length = 140,
                            Width = 150,
                            Height = 87,
                            Wattage = 600,
                            FormFactorId = (int)FormFactorEnum.ATX,
                            RatingId = (int)RatingEnum._80PLUSBronze,
                            ModularId = (int)ModularEnum.NonModular,
                            PFCId = (int)PFCEnum.Active,
                            CoolingId = (int)CoolingEnum._120mmFan,
                            Connectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x5),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Molex4_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU44_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe2062_x2),
                            },
                            ProtectionFeatures = new List<ProtectionFeatures>
                            {
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OPP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OTP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.UVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SIP),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new PSU
                        {
                            Name = "be quiet! Pure Power 12 M 1000W",
                            Price = 725,
                            ProducerId = (int)ProducerEnum.bequiet,
                            Length = 160,
                            Width = 150,
                            Height = 86,
                            Wattage = 1000,
                            FormFactorId = (int)FormFactorEnum.ATX_3_0,
                            RatingId = (int)RatingEnum._80PLUSGold,
                            ModularId = (int)ModularEnum.FullyModular,
                            PFCId = (int)PFCEnum.Active,
                            CoolingId = (int)CoolingEnum._120mmFan,
                            Connectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Molex4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU44_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU8_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe2062_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe50124_x1),
                            },
                            ProtectionFeatures = new List<ProtectionFeatures>
                            {
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OPP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OTP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SIP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.UVP),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new PSU
                        {
                            Name = "be quiet! Pure Power 12 M 550W",
                            Price = 419,
                            ProducerId = (int)ProducerEnum.bequiet,
                            Length = 160,
                            Width = 150,
                            Height = 86,
                            Wattage = 550,
                            FormFactorId = (int)FormFactorEnum.ATX_3_0,
                            RatingId = (int)RatingEnum._80PLUSGold,
                            ModularId = (int)ModularEnum.FullyModular,
                            PFCId = (int)PFCEnum.Active,
                            CoolingId = (int)CoolingEnum._120mmFan,
                            Connectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x5),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Molex4_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU44_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU8_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe2062_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe50124_x1),
                            },
                            ProtectionFeatures = new List<ProtectionFeatures>
                            {
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OPP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OTP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SIP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.UVP),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
                        },
                        new PSU
                        {
                            Name = "MSI MPG A850G PCIE5 850W",
                            Price = 589,
                            ProducerId = (int)ProducerEnum.MSI,
                            Length = 150,
                            Width = 150,
                            Height = 86,
                            Wattage = 850,
                            FormFactorId = (int)FormFactorEnum.ATX_3_0,
                            RatingId = (int)RatingEnum._80PLUSGold,
                            ModularId = (int)ModularEnum.FullyModular,
                            PFCId = (int)PFCEnum.Active,
                            CoolingId = (int)CoolingEnum._135mmFan,
                            Connectors = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.SATAIII_x8),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Molex4_x4),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.CPU44_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.ATX24_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe2062_x6),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.PCIe50124_x1),
                            },
                            ProtectionFeatures = new List<ProtectionFeatures>
                            {
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OPP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OTP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.OVP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.SCP),
                                context.Enum_ProtectionFeatures.Single(pf => pf.Id == (int)ProtectionFeaturesEnum.UVP),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            }
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
