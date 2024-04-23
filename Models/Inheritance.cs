using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VueBase.Models
{
    public abstract class Base
    {
        [Key][DatabaseGenerated(DatabaseGeneratedOption.Identity)] public int Id { get; set; }    
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public virtual Producers Producer { get; set; }
        public int? ProducerId { get; set; }
        public ProducerEnum ProducerEnum => (ProducerEnum)ProducerId;

    }

    public abstract class Dimensions : Base
    {
        public decimal Length { get; set; } 
        public decimal Width { get; set; } 
        public decimal Height { get; set; }
    }

}
