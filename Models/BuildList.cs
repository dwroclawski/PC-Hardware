using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VueBase.Models
{
    public class BuildList
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }

        public string UserId { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Case { get; set; }

        public string CPU { get; set; }

        public string GPU { get; set; }

        public string Motherboard { get; set; }

        public string PSU { get; set; }

        public string RAM { get; set; }

        public string HDD { get; set; }

        public string SSD { get; set; }

        public string CaseCooler { get; set; }

        public string CPUCooler { get; set; }



    }
}
