using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Entity
{
    public class Blog : BaseEntity
	{
		[Required]
		[MaxLength(255)]
		public string Title { get; set; }

		public string Summary { get; set; }

		[Required]
		public DateTime Date { get; set; }

		[ForeignKey("BlogCategory")]
		public int Categoryid { get; set; }

		public string Image { get; set; }

		public string Detail { get; set; }

		public virtual BlogCategory BlogCategory { get; set; }
	}
}