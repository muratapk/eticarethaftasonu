using System.ComponentModel.DataAnnotations;

namespace eticarethaftasonu.Models
{
	public class Products
	{
		[Key]
		public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductDescription { get; set; }
        public string? ProuctPicture { get; set; }
		public int? CategoryId { get; set; }
		virtual public Category? Category { get; set; } 
	}
}
