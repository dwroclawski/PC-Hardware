using System.ComponentModel.DataAnnotations;

namespace VueBase.Models
{

    // a collection of enums. longer enums get their own file
    public enum ProducerEnum
    {
        None = 1,
        Intel = 2,
        AMD = 3,
        Lexar = 4,
        Samsung = 5,
        Preyon = 6,
        XPG = 7,
        KRUX = 8,
        Corsair = 9,
        Kingston = 10,
        GSkill = 11,
        Crucial = 12,
        Patriot = 13,
        TeamGroup = 14,
        Adata = 15,
        Apacer = 16,
        [Display(Name = "Lian Li")] LianLi = 17,
        MSI = 18,
        Gigabyte = 19,
        NVIDIA = 20,
        ENDORFY = 21,
        [Display(Name = "be quiet!")] bequiet = 22,
        [Display(Name = "Seagate")] Seagate = 23,
        Genesis = 24,
        [Display(Name = "Silver Monkey")] SilverMonkey = 25,
        [Display(Name = "Silver Monkey X")] SilverMonkeyX = 26,
        PowerColor = 27,
        ASRock = 28,
        Gainward = 29,
    }
    public class Producers
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }


    public enum MemorySlotsEnum
    {
        [Display(Name = "1")] One = 1,
        [Display(Name = "2")] Two = 2,
        [Display(Name = "4")] Four = 4,
        [Display(Name = "8")] Eight = 8
    }
    public class MemorySlots
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum CPUThreadsEnum
    {
        Unknown = 1,
        Two = 2,
        Four = 4,
        Eight = 8,
        Twelve = 12,
        Sixteen = 16,
        Twenty = 20,
        TwentyFour = 24,
        TwentyEight = 28,
        ThirtyFour = 34,
        ThirtySix = 36,
        Fourtyeight = 48,
        HundretTwentyEight = 128,
        HundretNinetyTwo = 192
    }

    public enum UnlockedMultiplierEnum
    {
        Unknown = 1,
        Yes = 2,
        No = 3
    }
    public class UnlockedMultiplier
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MaxMonitorsEnum
    {
        Unknown = 1,
        [Display(Name = "3")] Three = 3,
        [Display(Name = "4")] Four = 4,
        [Display(Name = "5")] Five = 5,
        [Display(Name = "6")] Six = 6,
        [Display(Name = "7")] Seven = 7
    }

    public class MaxMonitors
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public class CPUThreads
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum CPUCoresEnum
    {
        Unknown = 1,
        [Display(Name = "2")]Two = 2,
        [Display(Name = "4")]Four = 4,
        [Display(Name = "6")]Six = 6,
        [Display(Name = "8")]Eight = 8,
        [Display(Name = "10")]Ten = 10,
        [Display(Name = "12")]Twelve = 12,
        [Display(Name = "14")]Fourteen = 14,
        [Display(Name = "16")]Sixteen = 16,
        [Display(Name = "18")]Eightteen = 18,
        [Display(Name = "20")]Twenty = 20,
        [Display(Name = "24")]TwentyFour = 24,
        [Display(Name = "32")]ThirtyTwo = 32,
        [Display(Name = "64") ]SixtyFour = 64,
        [Display(Name = "96")]NinetySix = 96

    }
    public class CPUCores
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MemoryTypeEnum
    {
        None = 1,
        HBM2 = 2,
        DDR3 = 3,
        DDR4 = 4,
        DDR5 = 5,
        GDDR3 = 6,
        GDDR5 = 7,
        GDDR6 = 8,
        GDDR6X = 9
    }
    public class MemoryType
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum CapacityEnum
    {
        [Display(Name = "None")] None = 1,
        [Display(Name = "2 GB")] GB_2 = 2,
        [Display(Name = "4 GB")] GB_4 = 4,
        [Display(Name = "6 GB")] GB_6 = 6,
        [Display(Name = "8 GB")] GB_8 = 8,
        [Display(Name = "10 GB")] GB_10 = 10,
        [Display(Name = "12 GB")] GB_12 = 12,
        [Display(Name = "16 GB")] GB_16 = 16,
        [Display(Name = "32 GB")] GB_32 = 32,
        [Display(Name = "64 GB")] GB_64 = 64,
        [Display(Name = "96 GB")] GB_96 = 96,
        [Display(Name = "128 GB")] GB_128 = 128,
        [Display(Name = "192 GB")] GB_192 = 192,
        [Display(Name = "256 GB")] GB_256 = 256,
        [Display(Name = "512 GB")] GB_512 = 512,
        [Display(Name = "1 TB")] TB_1 = 1000,
        [Display(Name = "2 TB")] TB_2 = 2000,
        [Display(Name = "4 TB")] TB_4 = 4000,
        [Display(Name = "6 TB")] TB_6 = 6000,
        [Display(Name = "8 TB")] TB_8 = 8000,

    }
    public class Capacity
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum FormFactorEnum
    {
        None = 1,
        ATX = 2,
        SFX = 3,
        [Display(Name = "2.5\"")] Inch_2_5 = 4,
        [Display(Name = "3.5\"")] Inch_3_5 = 5,
        [Display(Name = "M.2 2280")] M2_2280 = 6,
        [Display(Name = "Micro ATX")] MicroATX = 7,
        [Display(Name = "Mini-ITX")] MiniITX = 8,
        EATX = 9,
        ITX = 10,
        [Display(Name = "Mini-DTX")] MiniDTX = 11,
        [Display(Name = "SFX-L")] SFXL = 12,
        [Display(Name = "EATX (up to 280 mm wide)")] EATX_280W= 13,
        [Display(Name = "ATX 3.0")] ATX_3_0 = 14,

    }
    public class FormFactor
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> Case_Formfactor { get; set; }
        public ICollection<Case> Case_PSUMount { get; set; }
    }

    public enum CPUSocketEnum
    {
        None = 1,
        [Display(Name = "1700")] _1700 = 2,
        [Display(Name = "1200")] _1200 = 3,
        [Display(Name = "1151")] _1151 = 4,
        [Display(Name = "AM5")] AM5 = 5,
        [Display(Name = "AM4")] AM4 = 6,
        [Display(Name = "sTRX4")] sTRX4 = 7,
        [Display(Name = "sTR4")] sTR4 = 8,
        [Display(Name = "FM2+")] FM2Plus = 9,
        [Display(Name = "FM1")] FM1 = 10,
        [Display(Name = "AM3+")] AM3Plus = 11,
        [Display(Name = "AM2+")] AM2Plus = 12,
        [Display(Name = "775")] _775 = 13,
        [Display(Name = "2011")] _2011 = 14,
        [Display(Name = "2011-3")] _2011_3 = 15,
        [Display(Name = "2066")] _2066 = 16,
        [Display(Name = "1155")] _1155 = 17,
        [Display(Name = "1156")] _1156 = 18,
        [Display(Name = "1336")] _1366 = 19,
        [Display(Name = "1150")] _1150 = 20,
    }
    public class CPUSocket
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<CPUCooler> CPUCooler { get; set; }

    }

    public enum MemoryConnectorTypeEnum
    {
        Unknown = 1,
        DIMM = 2,
        [Display(Name = "SO-DIMM")] SODIMM = 3,
        RDIMM = 4
    }

    public class MemoryConnectorType
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Motherboard> Motherboard { get; set; }
    }

    public enum MemoryChannelEnum
    {
        Unknown = 1,
        [Display(Name = "Dual-Channel")] Dual = 2,
        [Display(Name = "Quad-Channel")] Quad = 4,
        [Display(Name = "Octal-Channel")] Octa = 8,
    }

    public class MemoryChannel
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MemoryFrequencyEnum
    {
        None = 1,
        [Display(Name = "800 MHz")] _800 = 800,
        [Display(Name = "1066 MHz")] _1066 = 1066,
        [Display(Name = "1333 MHz")] _1333 = 1333,
        [Display(Name = "1600 MHz")] _1600 = 1600,
        [Display(Name = "1866 MHz")] _1866 = 1866,
        [Display(Name = "2133 MHz")] _2133 = 2133,
        [Display(Name = "2250 MHz")] _2250 = 2250,
        [Display(Name = "2400 MHz")] _2400 = 2400,
        [Display(Name = "2500 MHz")] _2500 = 2500,
        [Display(Name = "2600 MHz")] _2600 = 2600,
        [Display(Name = "2666 MHz")] _2666 = 2666,
        [Display(Name = "2667 MHz")] _2667 = 2667,
        [Display(Name = "2800 MHz")] _2800 = 2800,
        [Display(Name = "2933 MHz")] _2933 = 2933,
        [Display(Name = "3000 MHz")] _3000 = 3000,
        [Display(Name = "3066 MHz")] _3066 = 3066,
        [Display(Name = "3200 MHz")] _3200 = 3200,
        [Display(Name = "3300 MHz")] _3300 = 3300,
        [Display(Name = "3333 MHz")] _3333 = 3333,
        [Display(Name = "3400 MHz")] _3400 = 3400,
        [Display(Name = "3466 MHz")] _3466 = 3466,
        [Display(Name = "3533 MHz")] _3533 = 3533,
        [Display(Name = "3600 MHz")] _3600 = 3600,
        [Display(Name = "3666 MHz")] _3666 = 3666,
        [Display(Name = "3733 MHz")] _3733 = 3733,
        [Display(Name = "3800 MHz")] _3800 = 3800,
        [Display(Name = "3866 MHz")] _3866 = 3866,
        [Display(Name = "4000 MHz")] _4000 = 4000,
        [Display(Name = "4133 MHz")] _4133 = 4133,
        [Display(Name = "4200 MHz")] _4200 = 4200,
        [Display(Name = "4266 MHz")] _4266 = 4266,
        [Display(Name = "4300 MHz")] _4300 = 4300,
        [Display(Name = "4333 MHz")] _4333 = 4333,
        [Display(Name = "4400 MHz")] _4400 = 4400,
        [Display(Name = "4466 MHz")] _4466 = 4466,
        [Display(Name = "4500 MHz")] _4500 = 4500,
        [Display(Name = "4600 MHz")] _4600 = 4600,
        [Display(Name = "4666 MHz")] _4666 = 4666,
        [Display(Name = "4700 MHz")] _4700 = 4700,
        [Display(Name = "4733 MHz")] _4733 = 4733,
        [Display(Name = "4800 MHz")] _4800 = 4800,
        [Display(Name = "4866 MHz")] _4866 = 4866,
        [Display(Name = "4933 MHz")] _4933 = 4933,
        [Display(Name = "5000 MHz")] _5000 = 5000,
        [Display(Name = "5066 MHz")] _5066 = 5066,
        [Display(Name = "5100 MHz")] _5100 = 5100,
        [Display(Name = "5133 MHz")] _5133 = 5133,
        [Display(Name = "5200 MHz")] _5200 = 5200,
        [Display(Name = "5300 MHz")] _5300 = 5300,
        [Display(Name = "5333 MHz")] _5333 = 5333,
        [Display(Name = "5400 MHz")] _5400 = 5400,
        [Display(Name = "5600 MHz")] _5600 = 5600,
        [Display(Name = "5800 MHz")] _5800 = 5800,
        [Display(Name = "6000 MHz")] _6000 = 6000,
        [Display(Name = "6133 MHz")] _6133 = 6133,
        [Display(Name = "6200 MHz")] _6200 = 6200,
        [Display(Name = "6400 MHz")] _6400 = 6400,
        [Display(Name = "6600 MHz")] _6600 = 6600,
        [Display(Name = "6666 MHz")] _6666 = 6666,
        [Display(Name = "6800 MHz")] _6800 = 6800,
        [Display(Name = "7000 MHz")] _7000 = 7000,
        [Display(Name = "7200 MHz")] _7200 = 7200,
        [Display(Name = "7400 MHz")] _7400 = 7400,
        [Display(Name = "7467 MHz")] _7467 = 7467,
        [Display(Name = "7600 MHz")] _7600 = 7600,
        [Display(Name = "7800 MHz")] _7800 = 7800,
        [Display(Name = "7900 MHz")] _7900 = 7900,
        [Display(Name = "7950 MHz")] _7950 = 7950,
        [Display(Name = "8000 MHz")] _8000 = 8000,
        [Display(Name = "8200 MHz")] _8200 = 8200,
        [Display(Name = "8266 MHz")] _8266 = 8266,
        [Display(Name = "8333 MHz")] _8333 = 8333,
        [Display(Name = "8400 MHz")] _8400 = 8400,
        [Display(Name = "8700 MHz")] _8700 = 8700,
    }

    public class MemoryFrequency
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Motherboard> Motherboard { get; set; }
    }


    public enum MotherboardChipsetEnum
    {
        None = 1,
        [Display(Name = "Intel B760")] Intel_B760 = 2,
        [Display(Name = "Intel Z790")] Intel_Z790 = 3,
        [Display(Name = "Intel H610")] Intel_H610 = 4,
        [Display(Name = "Intel Z690")] Intel_Z690 = 5,
        [Display(Name = "AMD B650")] AMD_B650 = 6,
        [Display(Name = "AMD B550")] AMD_B550 = 7,
        [Display(Name = "AMD B450")] AMD_B450 = 8,
        [Display(Name = "AMD A520")] AMD_A520 = 9,
        [Display(Name = "Intel H770")] Intel_H770 = 10,
        [Display(Name = "Intel Q670")] Intel_Q670 = 11,
        [Display(Name = "Intel H670")] Intel_H670 = 12,
        [Display(Name = "Intel B660")] Intel_B660 = 13,
        [Display(Name = "AMD X570")] AMD_X570 = 14,
        [Display(Name = "AMD X470")] AMD_X470 = 15,
        [Display(Name = "AMD A620")] AMD_A620 = 16,
        [Display(Name = "AMD B650E")] AMD_B650E = 17,
        [Display(Name = "AMD X670")] AMD_X670 = 18,
        [Display(Name = "AMD X670E")] AMD_X670E = 19,
        [Display(Name = "Intel W680")] Intel_W680 = 20,
    }

    public class MotherboardChipset
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CPU> CPU { get; set; }
    }

    public enum MemoryTypeFreqencyEnum
    {
        None = 1,
        [Display(Name = "Up to DDR4 2133 MT/s")] DDR4_2133 = 2133,
        [Display(Name = "Up to DDR4 2400 MT/s")] DDR4_2400 = 2400,
        [Display(Name = "Up to DDR4 2666 MT/s")] DDR4_2666 = 2666,
        [Display(Name = "Up to DDR4 2800 MT/s")] DDR4_2800 = 2800,
        [Display(Name = "Up to DDR4 2933 MT/s")] DDR4_2933 = 2933,
        [Display(Name = "Up to DDR4 3000 MT/s")] DDR4_3000 = 3000,
        [Display(Name = "Up to DDR4 3200 MT/s")] DDR4_3200 = 3200,
        [Display(Name = "Up to DDR5 4800 MT/s")] DDR5_4800 = 4800,
        [Display(Name = "Up to DDR5 5000 MT/s")] DDR5_5000 = 5000,
        [Display(Name = "Up to DDR5 5200 MT/s")] DDR5_5200 = 5200,
        [Display(Name = "Up to DDR5 5400 MT/s")] DDR5_5400 = 5400,
        [Display(Name = "Up to DDR5 5600 MT/s")] DDR5_5600 = 5600,
        [Display(Name = "Up to DDR5 6000 MT/s")] DDR5_6000 = 6000,
        [Display(Name = "Up to DDR5 8000 MT/s")] DDR5_8000 = 8000,


    }

    public class MemoryTypeFrequency
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CPU> CPU { get; set; }
    }

    public enum CacheEnum
    {
        None = 1,
        Unknown = 2,
        [Display(Name = "16 KB")] KB_16 = 16,
        [Display(Name = "32 KB")] KB_32 = 32,
        [Display(Name = "64 KB")] KB_64 = 64,
        [Display(Name = "128 KB")] KB_128 = 128,
        [Display(Name = "256 KB")] KB_256 = 256,
        [Display(Name = "384 KB")] KB_384 = 384,
        [Display(Name = "512 KB")] KB_512 = 512,
        [Display(Name = "640 KB")] KB_640 = 640,
        [Display(Name = "1 MB")] MB_1 = 1024,
        [Display(Name = "1.25 MB")] MB_1_25 = 1280,
        [Display(Name = "1.5 MB")] MB_1_5 = 1536,
        [Display(Name = "2 MB")] MB_2 = 2048,
        [Display(Name = "3 MB")] MB_3 = 3072,
        [Display(Name = "4 MB")] MB_4 = 4096,
        [Display(Name = "6 MB")] MB_6 = 6144,
        [Display(Name = "7.5 MB")] MB_7_5 = 7500,
        [Display(Name = "8 MB")] MB_8 = 8192,
        [Display(Name = "8.5 MB")] MB_8_5 = 8500,
        [Display(Name = "9.5 MB")] MB_9_5 = 9500,
        [Display(Name = "12 MB")] MB_12 = 12288,
        [Display(Name = "16 MB")] MB_16 = 16384,
        [Display(Name = "18 MB")] MB_18 = 18432,
        [Display(Name = "20 MB")] MB_20 = 20480,
        [Display(Name = "24 MB")] MB_24 = 24576,
        [Display(Name = "32 MB")] MB_32 = 32768,
        [Display(Name = "36 MB")] MB_36 = 36864,
        [Display(Name = "48 MB")] MB_48 = 49152,
        [Display(Name = "64 MB")] MB_64 = 65536,
        [Display(Name = "72 MB")] MB_72 = 73728,
        [Display(Name = "96 MB")] MB_96 = 98304,
        [Display(Name = "128 MB")] MB_128 = 131072,
        [Display(Name = "144 MB")] MB_144 = 147456,
        [Display(Name = "192 MB")] MB_192 = 196608,
        [Display(Name = "256 MB")] MB_256 = 262144,
        [Display(Name = "4 GB")] GB_4 = 4194304,
    }
    public class Cache
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum ColorEnum
    {
        None = 1,
        Yellow = 2,
        Orange = 3,
        Red = 4,
        Green = 5,
        Blue = 6,
        Purple = 7,
        White = 8,
        Black = 9,
        Silver = 10,
        Gold = 11,
        Gray = 12,
    }

    public class Color
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PSU> PSU { get; set; }
        public ICollection<CaseCooler> CaseCooler { get; set; }
        public ICollection<CPUCooler> CPUCooler { get; set; }
        public ICollection<SSD> SSD { get; set; }
        public ICollection<RAM> RAM { get; set; }
        public ICollection<Case> Case { get; set; }



    }
    public enum MaterialEnum
    {
        None = 1,
        [Display(Name = "Aluminium")] Aluminium = 2,
        [Display(Name = "Steel")] Steel = 3,
        [Display(Name = "Plastic")] Plastic = 4,
        [Display(Name = "Glass")] Glass = 5,
        [Display(Name = "Carbon")] Carbon = 6,
        [Display(Name = "Wood")] Wood = 7,
        [Display(Name = "Titanium")] Titanium = 8,
        [Display(Name = "Copper")] Copper = 9,
        [Display(Name = "Mesh")] Mesh = 10,
        [Display(Name = "Tempered Glass")] TemperedGlass = 11,
        [Display(Name = "Steel SECC 0.8 mm")] SteelSECC08 = 12,
    }
    public class Material
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<CPUCooler> CPUCooler { get; set; }
        public ICollection<Case> Case { get; set; }


    }

    public enum FansEnum
    {
        None = 1,
        [Display(Name = "1 x 120 mm (back)")] _1x120b = 2,
        [Display(Name = "1 x 120 mm (front)")] _1x120f = 3,
        [Display(Name = "1 x 120 mm (top)")] _1x120t = 4,
        [Display(Name = "1 x 120 mm (under)")] _1x120u = 5,
        [Display(Name = "1 x 120 mm (left)")] _1x120l = 6,
        [Display(Name = "1 x 120 mm (right)")] _1x120r = 7,
        [Display(Name = "1 x 120 mm")] _1x120 = 8,
        [Display(Name = "3 x 120 mm/2 x 140 mm (front)")] _3x120_2x140f = 9,
        [Display(Name = "2 x 120/140 mm (top)")] _2x120_140t = 10,
        [Display(Name = "2 x 120 mm")] _2x120 = 11,
        [Display(Name = "2 x 120 mm (back)")] _2x120b = 12,
        [Display(Name = "2 x 120 mm (front)")] _2x120f = 13,
        [Display(Name = "2 x 120 mm (top)")] _2x120t = 14,
        [Display(Name = "2 x 120 mm (under)")] _2x120u = 15,
        [Display(Name = "2 x 120 mm (left)")] _2x120l = 16,
        [Display(Name = "2 x 120 mm (right)")] _2x120r = 17,
        [Display(Name = "1 x 80 mm (back)")] _1x80b = 18,
        [Display(Name = "3 x 120 mm (front)")] _3x120f = 19,
        [Display(Name = "1 x 140 mm (back)")] _1x140b = 20,
        [Display(Name = "3 x 120/140 mm (front)")] _3x120_140f = 21,
        [Display(Name = "1 x 120/140 mm (back)")] _1x120_140b = 22,
        [Display(Name = "3 x 120/140 mm (top)")] _3x120_140t = 23,
        [Display(Name = "3 x 120 mm (under)")] _3x120u = 24,
        [Display(Name = "3 x 120 mm")] _3x120 = 25,
        [Display(Name = "1 x 140 mm")] _1x140 = 26,
        [Display(Name = "3 x 120 mm (front) - ARGB")] _3x120f_argb = 27,
        [Display(Name = "1 x 120 mm (back) - ARGB")] _1x120b_argb = 28,
        [Display(Name = "2 x 140 mm")] _2x140 = 29,
        [Display(Name = "2 x 160 mm (front) - ARGB")] _2x160f_argb = 30,
        [Display(Name = "3 x 120 mm/2 x 140/160 mm (front)")] _3x120_2x140_160f = 31,
        [Display(Name = "3 x 120 mm/2 x 140 mm (top)")] _3x120_2x140t = 32,
        [Display(Name = "2 x 120 mm/140 mm (under)")] _2x120_140u = 33,
    }
    public class Fans
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> InstalledFans { get; set; }
        public ICollection<Case> FanBays { get; set; }
    }

    public enum WaterCoolingSlotsEnum
    {
        None = 1,
        [Display(Name = "1 x 120 mm (front) - radiator")] _1x120f_rad = 2,
        [Display(Name = "1 x 140 mm (front) - radiator")] _1x140f_rad = 3,
        [Display(Name = "1 x 240 mm (front) - radiator")] _1x240f_rad = 4,
        [Display(Name = "1 x 280 mm (front) - radiator")] _1x280f_rad = 5,
        [Display(Name = "1 x 360 mm (front) - radiator")] _1x360f_rad = 6,
        [Display(Name = "1 x 120 mm (back) - radiator")] _1x120b_rad = 7,
        [Display(Name = "1 x 120 mm (top) - radiator")] _1x120t_rad = 8,
        [Display(Name = "1 x 140 mm (top) - radiator")] _1x140t_rad = 9,
        [Display(Name = "1 x 240 mm (top) - radiator")] _1x240t_rad = 10,
        [Display(Name = "1 x 280 mm (top) - radiator, without ODD cage")] _1x280t_rad_without_ODD = 11,
        [Display(Name = "1 x 120 mm (under) - radiator")] _1x120u_rad = 12,
        [Display(Name = "1 x 240 mm (under) - radiator")] _1x240u_rad = 13,
        [Display(Name = "1 x 120 mm (left) - radiator")] _1x120l_rad = 14,
        [Display(Name = "1 x 240 mm (left) - radiator")] _1x240l_rad = 15,
        [Display(Name = "1 x 120 mm (right) - radiator")] _1x120r_rad = 16,
        [Display(Name = "1 x 240 mm (right) - radiator")] _1x240r_rad = 17,
        [Display(Name = "1 x 360 mm (right) - radiator")] _1x360r_rad = 18,
        [Display(Name = "1 x 120 mm (front) - radiator, without ODD cage")] _1x120f_rad_without_ODD = 19,
        [Display(Name = "1 x 420 mm (front) - radiator")] _1x420f_rad = 20,
        [Display(Name = "1 x 420 mm (top) - radiator")] _1x420t_rad = 21,
        [Display(Name = "1 x 420 mm (under) - radiator")] _1x420u_rad = 22,
        [Display(Name = "1 x 420 mm (left) - radiator")] _1x420l_rad = 23,
        [Display(Name = "1 x 420 mm (right) - radiator")] _1x420r_rad = 24,
        [Display(Name = "1 x 360 mm (top) - radiator")] _1x360t_rad = 25,
        [Display(Name = "1 x 360 mm (under) - radiator")] _1x360u_rad = 26,
        [Display(Name = "1 x 360 mm (left) - radiator")] _1x360l_rad = 27,
        [Display(Name = "1 x 200 mm (front) - radiator")] _1x200f_rad = 28,
        [Display(Name = "1 x 480 mm (front) - radiator")] _1x480f_rad = 29,
        [Display(Name = "1 x 280 mm (top) - radiator")] _1x280t_rad = 30,
        [Display(Name = "1 x 140 mm (back) - radiator")] _1x140b_rad = 31,
        [Display(Name = "1 x 280 mm (back) - radiator")] _1x280b_rad = 32,
        [Display(Name = "1 x 360 mm (back) - radiator")] _1x360b_rad = 33,
        [Display(Name = "1 x 480 mm (back) - radiator")] _1x480b_rad = 34,
        [Display(Name = "1 x 140 mm (under) - radiator")] _1x140u_rad = 35,
    }
    public class WaterCoolingSlots
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> Case { get; set; }

    }
    public enum CoolingTypeEnum
    {
        None = 1,
        Active = 2,
        Passive = 3,
        Water = 4,
        Heatsink = 5,
    }
    public class CoolingType
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum MTBFEnum
    {
        None = 1,
        [Display(Name = "25 000 h")] MTBF25_000 = 25000,
        [Display(Name = "73 500 h")] MTBF73_5000 = 73500,
        [Display(Name = "30 000 h")] MTBF30_000 = 30000,
        [Display(Name = "40 000 h")] MTBF40_000 = 40000,
        [Display(Name = "50 000 h")] MTBF50_000 = 50000,
        [Display(Name = "60 000 h")] MTBF60_000 = 60000,
        [Display(Name = "70 000 h")] MTBF70_000 = 70000,
        [Display(Name = "80 000 h")] MTBF80_000 = 80000,
        [Display(Name = "90 000 h")] MTBF90_000 = 90000,
        [Display(Name = "100 000 h")] MTBF100_000 = 100000,
        [Display(Name = "110 000 h")] MTBF110_000 = 110000,
        [Display(Name = "120 000 h")] MTBF120_000 = 120000,
        [Display(Name = "150 000 h")] MTBF150_000 = 150000,
        [Display(Name = "160 000 h")] MTBF160_000 = 160000,
        [Display(Name = "300 000 h")] MTBF300_000 = 300000
    }
    public class MTBF
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum DriveBayEnum
    {
        None = 1,
        [Display(Name = "1 x 2.5\"")] _1x25 = 2,
        [Display(Name = "1 x 3.5\"")] _1x35 = 3,
        [Display(Name = "2 x 2.5\"")] _2x25 = 4,
        [Display(Name = "2 x 3.5\"")] _2x35 = 5,
        [Display(Name = "3 x 2.5\"")] _3x25 = 6,
        [Display(Name = "4 x 2.5\"")] _4x25 = 7,
        [Display(Name = "4 x 3.5\"")] _4x35 = 8,
        [Display(Name = "5 x 2.5\"")] _5x25 = 9,
        [Display(Name = "6 x 2.5\"")] _6x25 = 10,
        [Display(Name = "6 x 3.5\"")] _6x35 = 11,
        [Display(Name = "7 x 2.5\"")] _7x25 = 12,
        [Display(Name = "8 x 2.5\"")] _8x25 = 13,
        [Display(Name = "8 x 3.5\"")] _8x35 = 14,
        [Display(Name = "9 x 2.5\"")] _9x25 = 15,
        [Display(Name = "5 x 3.5\"")] _5x35 = 16,
        [Display(Name = "2 x 3.5\"/2.5\"")] _2x35_25 = 17,
        [Display(Name = "2 x 2.5\" (convertible from 1 x 3.5\")")] _2x25_c_1x35 = 18,
    }
    public class DriveBay
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> Case { get; set; }

    }
    public enum ButtonsEnum
    {
        None = 1,
        Power = 2,
        Reset = 3,
        [Display(Name = "LED Control")] LEDControl = 4,
        [Display(Name = "RGB Control")] RGBControl = 5,
        [Display(Name = "Fan Control")] FanControl = 6,
    }

    public class Buttons
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Case> Case { get; set; }

    }

    public enum CaseTypeEnum
    {
        None = 1,
        [Display(Name = "Full Tower")] Full_Tower = 2,
        [Display(Name = "Mid Tower")] Mid_Tower = 3,
        [Display(Name = "Mini Tower")] Mini_Tower = 4,
        [Display(Name = "Small Form Factor")] Small_Form_Factor = 5,
        [Display(Name = "Big Tower")] Big_Tower = 6,
    }
    public class CaseType
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum TDPEnum
    {
        None = 1,
        [Display(Name = "65 W")] W65 = 65,
        [Display(Name = "70 W")] W70 = 70,
        [Display(Name = "85 W")] W85 = 85,
        [Display(Name = "95 W")] W95 = 95,
        [Display(Name = "100 W")] W100 = 100,
        [Display(Name = "110 W")] W110 = 110,
        [Display(Name = "120 W")] W120 = 120,
        [Display(Name = "130 W")] W130 = 130,
        [Display(Name = "140 W")] W140 = 140,
        [Display(Name = "150 W")] W150 = 150,
        [Display(Name = "160 W")] W160 = 160,
        [Display(Name = "170 W")] W170 = 170,
        [Display(Name = "180 W")] W180 = 180,
        [Display(Name = "190 W")] W190 = 190,
        [Display(Name = "200 W")] W200 = 200,
        [Display(Name = "210 W")] W210 = 210,
        [Display(Name = "220 W")] W220 = 220,
        [Display(Name = "230 W")] W230 = 230,
        [Display(Name = "240 W")] W240 = 240,
        [Display(Name = "250 W")] W250 = 250,
        [Display(Name = "260 W")] W260 = 260,
        [Display(Name = "270 W")] W270 = 270,
        [Display(Name = "280 W")] W280 = 280,
        [Display(Name = "290 W")] W290 = 290,
        [Display(Name = "300 W")] W300 = 300,
        [Display(Name = "400 W")] W400 = 400
    }
    public class TDP
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MountEnum
    {
        None = 1,
        Horizontal = 2,
        Vertical = 3
    }
    public class Mount
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum FanBearingEnum
    {
        None = 1,
        [Display(Name = "Fluid Dynamic")] FluidDynamic = 2,
        Sleeve = 3,
        Ball = 4,
        Hydraulic = 5,
        Rifle = 6,
    }
    public class FanBearing
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum FanSpeedEnum
    {
        None = 1,
        [Display(Name = "250 RPM")] _250 = 250,
        [Display(Name = "300 RPM")] _300 = 300,
        [Display(Name = "500 RPM")] _500 = 500,
        [Display(Name = "600 RPM")] _600 = 600,
        [Display(Name = "800 RPM")] _800 = 800,
        [Display(Name = "900 RPM")] _900 = 900,
        [Display(Name = "1000 RPM")] _1000 = 1000,
        [Display(Name = "1200 RPM")] _1200 = 1200,
        [Display(Name = "1300 RPM")] _1300 = 1300,
        [Display(Name = "1400 RPM")] _1400 = 1400,
        [Display(Name = "1500 RPM")] _1500 = 1500,
        [Display(Name = "1600 RPM")] _1600 = 1600,
        [Display(Name = "1700 RPM")] _1700 = 1700,
        [Display(Name = "1800 RPM")] _1800 = 1800,
        [Display(Name = "250 - 1800 RPM")] _250_1800 = 2501800,
        [Display(Name = "600 - 1500 RPM")] _600_1500 = 6001500,
    }
    public class FanSpeed
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum HeatPipesEnum
    {
        None = 1,
        [Display(Name = "1 x 6mm")] _1x6 = 2,
        [Display(Name = "2 x 6mm")] _2x6 = 3,
        [Display(Name = "3 x 6mm")] _3x6 = 4,
        [Display(Name = "4 x 6mm")] _4x6 = 5,
    }
    public class HeatPipes
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MemoryBusEnum
    {
        None = 1,
        [Display(Name = "64 bit")] _64 = 64,
        [Display(Name = "96 bit")] _96 = 96,
        [Display(Name = "128 bit")] _128 = 128,
        [Display(Name = "192 bit")] _192 = 192,
        [Display(Name = "256 bit")] _256 = 256,
        [Display(Name = "320 bit")] _320 = 320,
        [Display(Name = "384 bit")] _384 = 384,
        [Display(Name = "2048 bit")] _2048 = 2048,


    }
    public class MemoryBus
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum GPUChipsetEnum
    {
        None = 1,
        [Display(Name = "GeForce RTX 4090")] GeForce_RTX_4090 = 2,
        [Display(Name = "GeForce RTX 4080")] GeForce_RTX_4080 = 3,
        [Display(Name = "GeForce RTX 4070")] GeForce_RTX_4070 = 4,
        [Display(Name = "GeForce RTX 4070 Ti")] GeForce_RTX_4070_Ti = 5,
        [Display(Name = "GeForce RTX 4060")] GeForce_RTX_4060 = 6,
        [Display(Name = "Radeon RX 6600")] Radeon_RX_6600 = 7,
        [Display(Name = "GeForce RTX 4070 SUPER")] GeForce_RTX_4070_SUPER = 8,
        [Display(Name = "GeForce RTX 4080 SUPER")] GeForce_RTX_4080_SUPER = 9,
    }
    public class GPUChipset
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum ResolutionEnum
    {
        None = 1,
        [Display(Name = "2560 x 1600")] _2560x1600 = 2560,
        [Display(Name = "3840 x 2160")] _3840x2160 = 3840,
        [Display(Name = "4096 x 2160")] _4096x2160 = 4096,
        [Display(Name = "5120 x 2880")] _5120x2880 = 5120,
        [Display(Name = "7680 x 4320")] _7680x4320 = 7680
    }

    public class Resolution
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum RPMEnum
    {
        None = 1,
        [Display(Name = "5400 RPM")] RPM5400 = 2,
        [Display(Name = "7200 RPM")] RPM7200 = 3,
        [Display(Name = "10000 RPM")] RPM10000 = 4,
    }
    public class RPM
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum CPUFamilyEnum
    {
        None = 1,
        AMD = 2,
        Intel = 3,
    }

    public class CPUFamily
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum RAIDEnum
    {
        Unknown = 1,
        None = 2,
        [Display(Name = "RAID 0")] RAID_0 = 3,
        [Display(Name = "RAID 1")] RAID_1 = 4,
        [Display(Name = "RAID 5")] RAID_5 = 5,
        [Display(Name = "RAID 10")] RAID_10 = 6,
    }

    public class RAID
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Motherboard> Motherboard { get; set; }
    }

    public enum WirelessTechnologyEnum
    {
        None = 1,
        Unknown = 2,
        [Display(Name = "Bluetooth")] Bluetooth = 3,
        [Display(Name = "Wi-Fi 4")] WiFi_4 = 4,
        [Display(Name = "Wi-Fi 5")] WiFi_5 = 5,
        [Display(Name = "Wi-Fi 6")] WiFi_6 = 6,
        [Display(Name = "Wi-Fi 6E")] WiFi_6E = 7,
        [Display(Name = "Wi-Fi 7")] WiFi_7 = 8
    }
    public class WirelessTechnology
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Motherboard> Motherboard { get; set; }
    }

    public enum InternalGPUSupportEnum
    {
        Unknown = 1,
        Yes = 2,
        No = 3
    }

    public class InternalGPUSupport
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum RatingEnum
    {
        None = 1,
        [Display(Name = "80 PLUS")] _80PLUS = 2,
        [Display(Name = "80 PLUS Bronze")] _80PLUSBronze = 3,
        [Display(Name = "80 PLUS Silver")] _80PLUSSilver = 4,
        [Display(Name = "80 PLUS Gold")] _80PLUSGold = 5,
        [Display(Name = "80 PLUS Platinum")] _80PLUSPlatinum = 6,
        [Display(Name = "80 PLUS Titanium")] _80PLUSTitanium = 7,
        Unclassified = 8
    }
    public class Rating
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum ModularEnum
    {
        None = 1,
        [Display(Name = "Non-Modular")] NonModular = 2,
        [Display(Name = "Semi-Modular")] SemiModular = 3,
        [Display(Name = "Fully-Modular")] FullyModular = 4
    }
    public class Modular
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum PFCEnum
    {
        None = 1,
        Passive = 2,
        Active = 3
    }
    public class PFC
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }


    public enum ProtectionFeaturesEnum
    {
        None = 1,
        OVP = 2,
        UVP = 3,
        SCP = 4,
        OLP = 5,
        OTP = 6,
        OPP = 7,
        SIP = 8,
        NLO = 9,
        OCP = 10,
    }
    public class ProtectionFeatures
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PSU> PSU { get; set; }
    }

    public enum CoolingEnum
    {
        None = 1,
        [Display(Name = "120mm Fan")] _120mmFan = 2,
        [Display(Name = "135mm Fan")] _135mmFan = 3,
        [Display(Name = "140mm Fan")] _140mmFan = 4,
    }
    public class Cooling
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum OverclockingEnum
    {
        None = 1,
        [Display(Name = "AMD EXPO")] AMD_EXPO = 2,
        [Display(Name = "Intel XMP")] Intel_XMP = 3,
        [Display(Name = "Intel XMP 2.0")] Intel_XMP_2 = 4,
        [Display(Name = "Intel XMP 3.0")] Intel_XMP_3 = 5,
    }
    public class Overclocking
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<RAM> RAM { get; set; }

    }

    public enum CycleLatencyEnum
    {
        None = 1,
        [Display(Name = "CL2.5")] CL2_5 = 2,
        CL3 = 3,
        CL4 = 4,
        CL5 = 5,
        CL6 = 6,
        CL7 = 7,
        CL8 = 8,
        CL9 = 9,
        CL10 = 10,
        CL11 = 11,
        CL12 = 12,
        CL13 = 13,
        CL14 = 14,
        CL15 = 15,
        CL16 = 16,
        CL17 = 17,
        CL18 = 18,
        CL19 = 19,
        CL20 = 20,
        CL21 = 21,
        CL22 = 22,
        CL23 = 23,
        CL24 = 24,
        CL25 = 25,
        CL26 = 26,
        CL27 = 27,
        CL28 = 28,
        CL29 = 29,
        CL30 = 30,
        CL31 = 31,
        CL32 = 32,
        CL33 = 33,
        CL34 = 34,
        CL35 = 35,
        CL36 = 36,
        CL37 = 37,
        CL38 = 38,
        CL39 = 39,
        CL40 = 40,
    }
    public class CycleLatency
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum VoltageEnum
    {
        None = 1,
        [Display(Name = "1.1 V")] V1_1 = 110,
        [Display(Name = "1.2 V")] V1_2 = 120,
        [Display(Name = "1.25 V")] V1_25 = 125,
        [Display(Name = "1.3 V")] V1_3 = 130,
        [Display(Name = "1.35 V")] V1_35 = 135,
        [Display(Name = "1.4 V")] V1_4 = 140,
        [Display(Name = "1.45 V")] V1_45 = 145,
        [Display(Name = "1.5 V")] V1_5 = 150,
        [Display(Name = "1.55 V")] V1_55 = 155,
        [Display(Name = "1.6 V")] V1_6 = 160,
        [Display(Name = "1.65 V")] V1_65 = 165,
        [Display(Name = "1.7 V")] V1_7 = 170,
        [Display(Name = "1.75 V")] V1_75 = 175,
        [Display(Name = "1.8 V")] V1_8 = 180,
        [Display(Name = "1.9 V")] V1_9 = 190,
        [Display(Name = "2.5 V")] V2_5 = 250,
        [Display(Name = "2.6 V")] V2_6 = 260
    }
    public class Voltage
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum SSDKeyEnum
    {
        None = 1,
        A = 2,
        B = 3,
        C = 4,
        D = 5,
        E = 6,
        F = 7,
        G = 8,
        H = 9,
        I = 10,
        J = 11,
        K = 12,
        L = 13,
        M = 14
    }
    public class SSDKey
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum HeatsinkEnum
    {
        Unknown = 1,
        Yes = 2,
        No = 3
    }
    public class Heatsink // radiator
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum EncryptionEnum
    {
        Unknown = 1,
        Yes = 2,
        No = 3
    }
    public class Encryption
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum CellTypeEnum
    {
        None = 1,
        MLC = 2,
        QLC = 3,
        SLC = 4,
        TLC = 5
    }
    public class CellType
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum MicroarchitectureEnum
    {
        Unknown = 1,
        [Display(Name = "Comet Lake")] CometLake = 2,
        [Display(Name = "Alder Lake")] AlderLake = 3,
        [Display(Name = "Raptor Lake")] RaptorLake = 4,
        [Display(Name = "Zen 4")] Zen4 = 5,
        [Display(Name = "Zen 3")] Zen3 = 6
    }

    public class Microarchitecture
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum DataWidthEnum
    {
        None = 1,
        [Display(Name = "32 bit")] _32 = 32,
        [Display(Name = "64 bit")] _64 = 64,
    }

    public class DataWidth
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }

    public enum LithographyEnum
    {
        None = 1,
        [Display(Name = "4 nm")] _4 = 4,
        [Display(Name = "5 nm")] _5 = 5,
        [Display(Name = "7 nm")] _7 = 7,
        [Display(Name = "10 nm")] _10 = 10,
        [Display(Name = "12 nm")] _12 = 12,
        [Display(Name = "14 nm")] _14 = 14,
        [Display(Name = "16 nm")] _16 = 16,
        [Display(Name = "22 nm")] _22 = 22,
        [Display(Name = "28 nm")] _28 = 28,
    }

    public class Lithography
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
    public enum InternalGPUEnum
    {
        None = 1,
        Intel = 2,
        AMD = 3,
        [Display(Name = "AMD Radeon Graphics")] AMD_Radeon_Graphics = 4,
    }
    public class InternalGPU
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}
