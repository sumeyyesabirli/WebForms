using System.ComponentModel.DataAnnotations;

namespace WebProject.Entity
{
    public class Settings : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Email { get; set; }

        [MaxLength(20)]
        public string Phone { get; set; }

        public string Address { get; set; }

        [MaxLength(255)]
        public string X { get; set; }

        [MaxLength(255)]
        public string Instagram { get; set; }

        public string Logo_image { get; set; }

        public string Description { get; set; }
    }
}