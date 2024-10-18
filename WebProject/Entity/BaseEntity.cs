using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace WebProject.Entity
{
    public class BaseEntity
	{
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public bool IsActive { get; set; } = true;
		public DateTime CreatedDate { get; set; } = DateTime.Now;
		public DateTime UpdatedDate { get; set; }
	}
}