using System.ComponentModel.DataAnnotations;

namespace WebProject.Entity
{
    public class BlogCategory : BaseEntity
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }

}