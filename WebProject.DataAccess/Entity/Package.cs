using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Entity
{
    public class Package : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Column(TypeName = "numeric(10, 2)")]
        public decimal Price { get; set; }

        [MaxLength(50)]
        public string Duration { get; set; }

        [MaxLength(255)]
        public string Location { get; set; }

        public string Image { get; set; }

        public string Detail { get; set; }
    }
}