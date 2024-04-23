using VueBase.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection.Emit;
using System.Reflection;
using System.ComponentModel.DataAnnotations;


namespace VueBase.Data;

public class PCContext : DbContext
{


    // MAIN PC PARTS
    public DbSet<Case> Case { get; set; }
    public DbSet<CaseCooler> CaseCooler { get; set; }
    public DbSet<CPU> CPU { get; set; }
    public DbSet<CPUCooler> CPUCooler { get; set; }
    public DbSet<GPU> GPU { get; set; }
    public DbSet<HDD> HDD { get; set; }
    public DbSet<Motherboard> Motherboard { get; set; }
    public DbSet<PSU> PSU { get; set; }
    public DbSet<RAM> RAM { get; set; }
    public DbSet<SSD> SSD { get; set; }

    public DbSet<BuildList> BuildList { get; set; }

    // ENUMS
    public DbSet<Buttons> Enum_Buttons { get; set; }
    public DbSet<CPUFamily> Enum_CPUFamily { get; set; }
    public DbSet<Cache> Enum_Cache { get; set; }
    public DbSet<Capacity> Enum_Capacity { get; set; }
    public DbSet<CaseType> Enum_CaseType { get; set; }
    public DbSet<CellType> Enum_CellType { get; set; }
    public DbSet<Color> Enum_Color { get; set; }
    public DbSet<Connector> Enum_Connectors { get; set; }
    public DbSet<Cooling> Enum_Cooling { get; set; }
    public DbSet<CoolingType> Enum_CoolingType { get; set; }
    public DbSet<CPUSocket> Enum_CPUSocket { get; set; }
    public DbSet<CPUCores> Enum_CPUCores { get; set; }
    public DbSet<CPUThreads> Enum_CPUThreads { get; set; }
    public DbSet<CycleLatency> Enum_CycleLatency { get; set; }
    public DbSet<DataWidth> Enum_DataWidth { get; set; }
    public DbSet<DriveBay> Enum_Drivebay { get; set; }
    public DbSet<Encryption> Enum_Encryption { get; set; }
    public DbSet<FanBearing> Enum_FanBearing { get; set; }
    public DbSet<FanSpeed> Enum_FanSpeed { get; set; }
    public DbSet<Fans> Enum_Fans { get; set; }
    public DbSet<FormFactor> Enum_FormFactor { get; set; }
    public DbSet<GPUChipset> Enum_Chipset { get; set; }
    public DbSet<HeatPipes> Enum_HeatPipes { get; set; }
    public DbSet<Heatsink> Enum_Heatsink { get; set; }
    public DbSet<InternalGPUSupport> Enum_InternalGPUSupport { get; set; }
    public DbSet<InternalGPU> Enum_InternalGPU { get; set; }
    public DbSet<Lithography> Enum_Lithography { get; set; }
    public DbSet<MaxMonitors> Enum_MaxMonitors {  get; set; }
    public DbSet<Material> Enum_Material { get; set; }
    public DbSet<Microarchitecture> Enum_Microarchitecture { get; set; }
    public DbSet<MotherboardChipset> Enum_MotherboardChipset { get; set; }
    public DbSet<MemoryBus> Enum_MemoryBus { get; set; }
    public DbSet<MemoryChannel> Enum_MemoryChannel { get; set; }
    public DbSet<MemoryConnectorType> Enum_MemoryConnectorType { get; set; }
    public DbSet<MemoryFrequency> Enum_MemoryFrequency { get; set; }
    public DbSet<MemoryType> Enum_MemoryType { get; set; }
    public DbSet<MemoryTypeFrequency> Enum_MemoryTypeFrequency { get; set; }
    public DbSet<MemorySlots> Enum_MemorySlots { get; set; }
    public DbSet<Modular> Enum_Modular { get; set; }
    public DbSet<Mount> Enum_Mount { get; set; }
    public DbSet<MTBF> Enum_MTBF { get; set; }
    public DbSet<Overclocking> Enum_Overclocking { get; set; }
    public DbSet<PFC> Enum_PFC { get; set; }
    public DbSet<Producers> Enum_Producers { get; set; }
    public DbSet<ProtectionFeatures> Enum_ProtectionFeatures { get; set; }
    public DbSet<RAID> Enum_RAID { get; set; }
    public DbSet<Rating> Enum_Rating { get; set; }
    public DbSet<Resolution> Enum_Resolution { get; set; }
    public DbSet<RPM> Enum_RPM { get; set; }
    public DbSet<SSDKey> Enum_Key { get; set; }
    public DbSet<TDP> Enum_TDP { get; set; }
    public DbSet<UnlockedMultiplier> Enum_UnlockedMultiplier { get; set; }
    public DbSet<Voltage> Enum_Voltage { get; set; }
    public DbSet<WaterCoolingSlots> Enum_WaterCoolingSlots { get; set; }
    public DbSet<WirelessTechnology> Enum_WirelessTechnology { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PC-Database;Integrated Security=True;");
    }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        // CREATES ENUMS AS TABLES IN DB
        CreateEnum<ButtonsEnum, Buttons>(modelBuilder);
        CreateEnum<CacheEnum, Cache>(modelBuilder);
        CreateEnum<CapacityEnum, Capacity>(modelBuilder);
        CreateEnum<CaseTypeEnum, CaseType>(modelBuilder);
        CreateEnum<CellTypeEnum, CellType>(modelBuilder);
        CreateEnum<ColorEnum, Color>(modelBuilder);
        CreateEnum<ConnectorEnum, Connector>(modelBuilder);
        CreateEnum<CoolingEnum, Cooling>(modelBuilder);
        CreateEnum<CoolingTypeEnum, CoolingType>(modelBuilder);
        CreateEnum<CPUCoresEnum, CPUCores>(modelBuilder);
        CreateEnum<CPUThreadsEnum, CPUThreads>(modelBuilder);
        CreateEnum<CPUFamilyEnum, CPUFamily>(modelBuilder);
        CreateEnum<CPUSocketEnum, CPUSocket>(modelBuilder);
        CreateEnum<CycleLatencyEnum, CycleLatency>(modelBuilder);
        CreateEnum<DataWidthEnum, DataWidth>(modelBuilder);
        CreateEnum<DriveBayEnum, DriveBay>(modelBuilder);
        CreateEnum<EncryptionEnum, Encryption>(modelBuilder);
        CreateEnum<FanBearingEnum, FanBearing>(modelBuilder);
        CreateEnum<FansEnum, Fans>(modelBuilder);
        CreateEnum<FanSpeedEnum, FanSpeed>(modelBuilder);
        CreateEnum<FormFactorEnum, FormFactor>(modelBuilder);
        CreateEnum<GPUChipsetEnum, GPUChipset>(modelBuilder);
        CreateEnum<HeatPipesEnum, HeatPipes>(modelBuilder);
        CreateEnum<HeatsinkEnum, Heatsink>(modelBuilder);
        CreateEnum<InternalGPUSupportEnum, InternalGPUSupport>(modelBuilder);
        CreateEnum<InternalGPUEnum, InternalGPU>(modelBuilder); 
        CreateEnum<LithographyEnum, Lithography>(modelBuilder);
        CreateEnum<MaterialEnum, Material>(modelBuilder);
        CreateEnum<MaxMonitorsEnum,  MaxMonitors>(modelBuilder);
        CreateEnum<MemoryBusEnum, MemoryBus>(modelBuilder);
        CreateEnum<MemoryChannelEnum, MemoryChannel>(modelBuilder);
        CreateEnum<MemoryConnectorTypeEnum, MemoryConnectorType>(modelBuilder);
        CreateEnum<MemoryFrequencyEnum, MemoryFrequency>(modelBuilder);
        CreateEnum<MemoryTypeEnum, MemoryType>(modelBuilder);
        CreateEnum<MemoryTypeFreqencyEnum, MemoryTypeFrequency>(modelBuilder);
        CreateEnum<MemorySlotsEnum, MemorySlots>(modelBuilder);
        CreateEnum<MicroarchitectureEnum,  Microarchitecture>(modelBuilder);
        CreateEnum<ModularEnum, Modular>(modelBuilder);
        CreateEnum<MotherboardChipsetEnum, MotherboardChipset>(modelBuilder);
        CreateEnum<MountEnum, Mount>(modelBuilder);
        CreateEnum<MTBFEnum, MTBF>(modelBuilder);
        CreateEnum<OverclockingEnum, Overclocking>(modelBuilder);
        CreateEnum<PFCEnum, PFC>(modelBuilder);
        CreateEnum<ProducerEnum, Producers>(modelBuilder);
        CreateEnum<ProtectionFeaturesEnum, ProtectionFeatures>(modelBuilder);
        CreateEnum<RAIDEnum, RAID>(modelBuilder);
        CreateEnum<RatingEnum, Rating>(modelBuilder);
        CreateEnum<ResolutionEnum, Resolution>(modelBuilder);
        CreateEnum<RPMEnum, RPM>(modelBuilder);
        CreateEnum<SSDKeyEnum, SSDKey>(modelBuilder);
        CreateEnum<TDPEnum, TDP>(modelBuilder);
        CreateEnum<UnlockedMultiplierEnum, UnlockedMultiplier>(modelBuilder);
        CreateEnum<VoltageEnum, Voltage>(modelBuilder);
        CreateEnum<WaterCoolingSlotsEnum, WaterCoolingSlots>(modelBuilder);
        CreateEnum<WirelessTechnologyEnum, WirelessTechnology>(modelBuilder);

        // CONFIGURES MANY-MANY RELATIONS AND CREATES JOIN TABLES
        ConfigureManyToMany<GPU, Connector>(modelBuilder, "Join_GPU_Port", g => g.Ports, p => p.GPU, "PortId", "GPUId");

        ConfigureManyToMany<PSU, ProtectionFeatures>(modelBuilder, "Join_PSU_ProtectionFeatures", p => p.ProtectionFeatures, pf => pf.PSU, "ProtectionFeaturesId", "PSUId");
        ConfigureManyToMany<PSU, Connector>(modelBuilder, "Join_PSU_Connector", p => p.Connectors, c => c.PSU, "ConnectorId", "PSUId");
        ConfigureManyToMany<PSU, Color>(modelBuilder, "Join_PSU_Color", g => g.Color, p => p.PSU, "ColorId", "PSUId");

        ConfigureManyToMany<CPU, MotherboardChipset>(modelBuilder, "Join_CPU_MotherboardChipset", g => g.MotherboardChipsetCompatibility, p => p.CPU, "MotherboardChipsetId", "CPUId");
        ConfigureManyToMany<CPU, MemoryTypeFrequency>(modelBuilder, "Join_CPU_MemoryTypeFrequency", g => g.MemoryTypes, p => p.CPU, "MemoryTypeFrequencyId", "CPUId");

        ConfigureManyToMany<Motherboard, RAID>(modelBuilder, "Join_Motherboard_RAID", g => g.RAID, p => p.Motherboard, "RAIDId", "MotherboardId");
        ConfigureManyToMany<Motherboard, WirelessTechnology>(modelBuilder, "Join_Motherboard_WirelessTechnology", g => g.WirelessTechnologies, p => p.Motherboard, "WirelessTechnologyId", "MotherboardId");
        ConfigureManyToMany<Motherboard, MemoryFrequency>(modelBuilder, "Join_Motherboard_MemoryFrequency", g => g.MemoryFrequencies, p => p.Motherboard, "MemoryFrequencyId", "MotherboardId");
        ConfigureManyToMany<Motherboard, Connector>(modelBuilder, "Join_Motherboard_ExternalConnector", g => g.ExternalConnectors, p => p.Motherboard_ExternalConnector, "ExternalConnectorId", "MotherboardId");
        ConfigureManyToMany<Motherboard, Connector>(modelBuilder, "Join_Motherboard_InternalConnector", g => g.InternalConnectors, p => p.Motherboard_InternalConnector, "InternalConnectorId", "MotherboardId");

        ConfigureManyToMany<CPUCooler, Material>(modelBuilder, "Join_CPUCooler_Material", g => g.Material, p => p.CPUCooler, "MaterialId", "CPUCoolerId");
        ConfigureManyToMany<CPUCooler, Color>(modelBuilder, "Join_CPUCooler_Color", g => g.Color, p => p.CPUCooler, "ColorId", "CPUCoolerId");
        ConfigureManyToMany<CPUCooler, CPUSocket>(modelBuilder, "Join_CPUCooler_CPUSocket", g => g.CPUSocket, p => p.CPUCooler, "CPUSocketId", "CPUCoolerId");


        ConfigureManyToMany<CaseCooler, Color>(modelBuilder, "Join_CaseCooler_Color", g => g.Color, p => p.CaseCooler, "ColorId", "CaseCoolerId");

        ConfigureManyToMany<SSD, Color>(modelBuilder, "Join_SSD_Color", g => g.Color, p => p.SSD, "ColorId", "SSDId");
       
        ConfigureManyToMany<RAM, Color>(modelBuilder, "Join_RAM_Color", g => g.Color, p => p.RAM, "ColorId", "RAMId");
        ConfigureManyToMany<RAM, Overclocking>(modelBuilder, "Join_RAM_Overclocking", g => g.Overclocking, p => p.RAM, "OverclockingId", "RAMId");


        ConfigureManyToMany<Case, Material>(modelBuilder, "Join_Case_Material", g => g.Material, p => p.Case, "MaterialId", "CaseId");
        ConfigureManyToMany<Case, Connector>(modelBuilder, "Join_Case_Port", g => g.Ports, p => p.Case, "PortId", "CaseId");
        ConfigureManyToMany<Case, FormFactor>(modelBuilder, "Join_Case_FormFactor", g => g.FormFactor, p => p.Case_Formfactor, "FormFactorId", "CaseId");
        ConfigureManyToMany<Case, FormFactor>(modelBuilder, "Join_Case_PSUMount", g => g.PSUMount, p => p.Case_PSUMount, "PSUMountId", "CaseId");
        ConfigureManyToMany<Case, Buttons>(modelBuilder, "Join_Case_Buttons", g => g.Buttons, p => p.Case, "ButtonsId", "CaseId");
        ConfigureManyToMany<Case, DriveBay>(modelBuilder, "Join_Case_DriveBay", g => g.DriveBay, p => p.Case, "DriveBayId", "CaseId");
        ConfigureManyToMany<Case, Color>(modelBuilder, "Join_Case_Color", g => g.Color, p => p.Case, "ColorId", "CaseId");
        ConfigureManyToMany<Case, Fans>(modelBuilder, "Join_Case_InstalledFans", g => g.InstalledFans, p => p.InstalledFans, "InstalledFansId", "CaseId");
        ConfigureManyToMany<Case, Fans>(modelBuilder, "Join_Case_FanBays", g => g.FanBays, p => p.FanBays, "FanBaysId", "CaseId");
        ConfigureManyToMany<Case, WaterCoolingSlots>(modelBuilder, "Join_Case_WaterCoolingSlots", g => g.WaterCoolingSlots, p => p.Case, "WaterCoolingSlotId", "CaseId");


        // the 1-n relations that wan't work on their own -> when a 1-n and n-m relelation to the same enum exists
        modelBuilder.Entity<Case>()
            .HasOne(c => c.SidePanelMaterial)
            .WithMany()  
            .HasForeignKey(c => c.SidePanelMaterialId);

        modelBuilder.Entity<GPU>()
            .HasOne(c => c.InterFace)
            .WithMany()
            .HasForeignKey(c => c.InterFaceId);

        modelBuilder.Entity<GPU>()
            .HasOne(c => c.PowerConnector)
            .WithMany()
            .HasForeignKey(c => c.PowerConnectorID);

        // Get all entity types registered in the model
        var entityTypes = modelBuilder.Model.GetEntityTypes();

        foreach (var entityType in entityTypes)
        {
            foreach (var property in entityType.GetProperties())
            {
                // Here, you can apply settings to properties dynamically
                // For example, setting all decimal properties to have precision 18 and scale 2
                if (property.ClrType == typeof(decimal))
                {
                    modelBuilder.Entity(entityType.ClrType)
                        .Property(property.Name)
                        .HasPrecision(18, 2); // Modify precision and scale as needed
                }

            }
        }
    }


    // **** METHODS USED IN ONMODELCREATING ****

    private static void CreateEnum<TEnum, TEntity>(ModelBuilder modelBuilder)
      where TEnum : Enum
      where TEntity : class, new()
    {
        modelBuilder.Entity<TEntity>()
            .HasData(Enum.GetValues(typeof(TEnum))
                .Cast<TEnum>()
                .Select(e => new 

                {
                    Id = Convert.ChangeType(e, typeof(int)), 
                    Name = DisplayToString(e)
                }));
    }
    private static string DisplayToString<TEnum>(TEnum enumValue)
    {
        var displayAttribute = typeof(TEnum)
            .GetField(enumValue.ToString())
            .GetCustomAttributes(typeof(DisplayAttribute), false)
            .FirstOrDefault() as DisplayAttribute;

        return displayAttribute?.Name ?? enumValue.ToString();
    }

    public static void ConfigureManyToMany<TLeft, TRight>(
     ModelBuilder modelBuilder,
     string joinTableName,
     Expression<Func<TLeft, IEnumerable<TRight>>> leftNavigationProperty,
     Expression<Func<TRight, IEnumerable<TLeft>>> rightNavigationProperty,
     string leftForeignKeyName,
     string rightForeignKeyName)
     where TLeft : class
     where TRight : class
    {
        modelBuilder.Entity<TLeft>()
            .HasMany(leftNavigationProperty)
            .WithMany(rightNavigationProperty)
            .UsingEntity<Dictionary<string, object>>(
                joinTableName,
                j => j.HasOne<TRight>().WithMany().HasForeignKey(leftForeignKeyName),
                j => j.HasOne<TLeft>().WithMany().HasForeignKey(rightForeignKeyName)
            );
    }

}