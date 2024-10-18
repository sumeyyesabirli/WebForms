using System.ComponentModel.DataAnnotations;

namespace WebProject.Entity
{
    public class Aboutus : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Summary { get; set; }
    }

}