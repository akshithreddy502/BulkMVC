using System;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
	public class Category
	{
		[Key] //Data Annotation -  To let Database know it is Primary Key
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
}

