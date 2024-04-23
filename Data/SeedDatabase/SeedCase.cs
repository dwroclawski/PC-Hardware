using VueBase.Models;


/*
new Models.Case
{
    Name = "",
    Price = ,
    ProducerId = (int)ProducerEnum.,
    Length = ,
    Width = ,
    Height = ,
    MaxFanCount = ,
    InstalledFanCount = ,
    ExpansionSlots = ,
    MaxGPULength = ,
    MaxCPUCoolerHeight = ,
    SidePanelMaterialId = (int)MaterialEnum.,
    TypeId = (int)CaseTypeEnum.,
    Material = new List<Material> { },
    Ports = new List<Connector> { },
    FormFactor = new List<FormFactor> { },
    PSUMount = new List<FormFactor> { },
    Buttons = new List<Buttons> { },
    DriveBay = new List<DriveBay> { },
    Color = new List<Color> { },
    InstalledFans = new List<Fans> { },
    FanBays = new List<Fans> { },
    WaterCoolingSlots = new List<WaterCoolingSlots> { }
                        }*/
namespace VueBase.Data.SeedDatabase
{
    public static class CaseInitializer
    {
        public static WebApplication SeedCase(this WebApplication app, PCContext context)
        {
            try
            {
               
                var cases = context.Case.FirstOrDefault();
                if (cases == null)
                {
                    context.Case.AddRange(
                        new Case
                        {
                            Name = "XPG Defender Pro Black",
                            Price = 259,
                            ProducerId = (int)ProducerEnum.XPG,
                            Length = 441,
                            Width = 220,
                            Height = 492,
                            MaxFanCount = 6,
                            InstalledFanCount = 3,
                            ExpansionSlots = 9,
                            MaxGPULength = 380,
                            MaxCPUCoolerHeight = 170,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Mid_Tower,
                            Material = new List<Material> { 
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Steel),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Glass )
                            },
                            Ports = new List<Connector> { 
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.MicrophoneHeadphone_x1)
                            },
                            FormFactor = new List<FormFactor> {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniITX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.EATX),
                            },
                            PSUMount = new List<FormFactor> { context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX) },
                            Buttons = new List<Buttons> { 
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.LEDControl)
                            },
                            DriveBay = new List<DriveBay> { 
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x35_25)
                            },
                            Color = new List<Color> { context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black) },
                            InstalledFans = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120b)
                            },
                           FanBays = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_2x140f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120_140t)
                           },
                           WaterCoolingSlots = new List<WaterCoolingSlots> {
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120f_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x140f_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240f_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x280f_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x360f_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120b_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x140t_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240t_rad),
                               context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x280t_rad_without_ODD),
                           }
                        },
                        new Case
                        {
                            Name = "KRUX Naos TG",
                            Price = 339,
                            ProducerId = (int)ProducerEnum.KRUX,
                            Length = 391,
                            Width = 185,
                            Height = 303,
                            MaxFanCount = 7,
                            InstalledFanCount = 1,
                            ExpansionSlots = 6,
                            MaxGPULength = 335,
                            MaxCPUCoolerHeight = 155,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Small_Form_Factor,
                            Material = new List<Material>
                            {
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Steel),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Glass )
                            },
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.MicrophoneHeadphone_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Microphone_x1),
                            },
                            FormFactor = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ITX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniDTX),

                            },
                            PSUMount = new List<FormFactor> {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.SFX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.SFXL),
                            },
                            Buttons = new List<Buttons>
                            {
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Reset),
                            },
                            DriveBay = new List<DriveBay> {
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._9x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._5x35),
                            },
                            Color = new List<Color> {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            },
                            InstalledFans = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x80b),
                            },
                            FanBays = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x80b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120t),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120u),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120r),
                            },
                            WaterCoolingSlots = new List<WaterCoolingSlots> {
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120u_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240u_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120r_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240r_rad),
                            }
                        },
                        new Case
                        {
                            Name = "Lian Li LANCOOL III RGB White",
                            Price = 889,
                            ProducerId = (int)ProducerEnum.LianLi,
                            Length = 523,
                            Width = 238,
                            Height = 526,
                            MaxFanCount = 10,
                            InstalledFanCount = 4,
                            ExpansionSlots = 8,
                            MaxGPULength = 435,
                            MaxCPUCoolerHeight = 187,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Big_Tower,
                            Material = new List<Material> {
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.SteelSECC08),
                            },
                            Ports = new List<Connector> {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.MicrophoneHeadphone_x1),
                            },
                            FormFactor = new List<FormFactor> {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniITX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.EATX_280W),
                            },
                            PSUMount = new List<FormFactor> {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                            },
                            Buttons = new List<Buttons> {
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Reset),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.LEDControl),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.RGBControl),
                            },
                            DriveBay = new List<DriveBay> {
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._8x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._4x35),
                            },
                            Color = new List<Color> {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.White),
                            },
                            InstalledFans = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x140b),
                            },
                            FanBays = new List<Fans> {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_140f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120_140b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_140t),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120u),
                            },
                            WaterCoolingSlots = new List<WaterCoolingSlots> {
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x420f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x420t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x360u_rad),
                            }
                        },
                        new Case
                        {
                            Name = "KRUX Trek",
                            Price = 149,
                            ProducerId = (int)ProducerEnum.KRUX,
                            Length = 359,
                            Width = 184,
                            Height = 351,
                            MaxFanCount = 3,
                            InstalledFanCount = 1,
                            ExpansionSlots = 4,
                            MaxGPULength = 280,
                            MaxCPUCoolerHeight = 136,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Mini_Tower,
                            Material = new List<Material>
                            {
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Steel),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Glass )
                            },
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Microphone_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Headphone_x1),
                            },
                            FormFactor = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniITX),
                            },
                            PSUMount = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                            },
                            Buttons = new List<Buttons>
                            {
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Reset),
                            },
                            DriveBay = new List<DriveBay>
                            {
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x35),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x25_c_1x35),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            },
                            InstalledFans = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x80b),
                            },
                            FanBays = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x80b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120f),
                            },
                            WaterCoolingSlots = new List<WaterCoolingSlots>
                            {
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum.None),
                            }
                        },
                        new Case
                        {
                            Name = "Silver Monkey X Chest TG",
                            Price = 359,
                            ProducerId = (int)ProducerEnum.SilverMonkeyX,
                            Length = 420,
                            Width = 210,
                            Height = 455,
                            MaxFanCount = 8,
                            InstalledFanCount = 4,
                            ExpansionSlots = 9,
                            MaxGPULength = 370,
                            MaxCPUCoolerHeight = 165,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Mid_Tower,
                            Material = new List<Material>
                            {
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Steel),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.TemperedGlass )
                            },
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB20_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.MicrophoneHeadphone_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.Microphone_x1),
                            },
                            FormFactor = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniITX),
                            },
                            PSUMount = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                            },
                            Buttons = new List<Buttons>
                            {
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Reset),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.LEDControl),
                            },
                            DriveBay = new List<DriveBay>
                            {
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x35),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            },
                            InstalledFans = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120f_argb),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120b_argb),
                            },
                            FanBays = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_2x140f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120t),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120u),
                            },
                            WaterCoolingSlots = new List<WaterCoolingSlots>
                            {
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120b_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240t_rad),
                            }
                        },
                        new Case
                        {
                            Name = "Lian Li LANCOOL 216 RGB Black",
                            Price = 485.47m,
                            ProducerId = (int)ProducerEnum.LianLi,
                            Length = 481,
                            Width = 235,
                            Height = 492,
                            MaxFanCount = 10,
                            InstalledFanCount = 3,
                            ExpansionSlots = 7,
                            MaxGPULength = 392,
                            MaxCPUCoolerHeight = 180.5m,
                            SidePanelMaterialId = (int)MaterialEnum.TemperedGlass,
                            TypeId = (int)CaseTypeEnum.Mid_Tower,
                            Material = new List<Material>
                            {
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Steel),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.TemperedGlass),
                                context.Enum_Material.Single(m => m.Id == (int)MaterialEnum.Plastic),
                            },
                            Ports = new List<Connector>
                            {
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1_x2),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.USB32Gen1C_x1),
                                context.Enum_Connectors.Single(c => c.Id == (int)ConnectorEnum.MicrophoneHeadphone_x1),
                            },
                            FormFactor = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MicroATX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.MiniITX),
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.EATX_280W),
                            },
                            PSUMount = new List<FormFactor>
                            {
                                context.Enum_FormFactor.Single(f => f.Id == (int)FormFactorEnum.ATX),
                            },
                            Buttons = new List<Buttons>
                            {
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.Power),
                                context.Enum_Buttons.Single(b => b.Id == (int)ButtonsEnum.FanControl)
                            },
                            DriveBay = new List<DriveBay>
                            {
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._4x25),
                                context.Enum_Drivebay.Single(d => d.Id == (int)DriveBayEnum._2x35_25),
                            },
                            Color = new List<Color>
                            {
                                context.Enum_Color.Single(c => c.Id == (int)ColorEnum.Black),
                            },
                            InstalledFans = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x160f_argb),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x140b)
                            },
                            FanBays = new List<Fans>
                            {
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_2x140_160f),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120_140b),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._3x120_2x140t),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._2x120_140u),
                                context.Enum_Fans.Single(f => f.Id == (int)FansEnum._1x120r),
                            },
                            WaterCoolingSlots = new List<WaterCoolingSlots>
                            {
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x140f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x200f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x280f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x360f_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x140t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x280t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x360t_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x120u_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x140u_rad),
                                context.Enum_WaterCoolingSlots.Single(w => w.Id == (int)WaterCoolingSlotsEnum._1x240u_rad),
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

