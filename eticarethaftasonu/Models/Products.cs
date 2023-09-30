using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eticarethaftasonu.Models
{
	public class Products
	{
		[Key]
		public int ProductId { get; set; }
		[DisplayName("Ürün Adı")]
		[Required(ErrorMessage ="Boş Bırakmazsınız")]
		[StringLength(50, ErrorMessage = "En fazla {1} karakter uzunluğunda olmalıdır.")]

		public string? ProductName { get; set; }
		[DisplayName("Ürün Kodu")]
		[Required(ErrorMessage = "Boş Bırakmazsınız")]
		public string? ProductCode { get; set; }
		[DisplayName("Ürün Açıklaması")]
		[Required(ErrorMessage = "Boş Bırakmazsınız")]
		public string? ProductDescription { get; set; }
		[DisplayName("Ürün Resmi")]
		[Required(ErrorMessage = "Boş Bırakmazsınız")]
		public string? ProuctPicture { get; set; }
		[DisplayName("Ürün Kategorisi")]
		public int? CategoryId { get; set; }
		virtual public Category? Category { get; set; }
		[NotMapped]
		public IFormFile? ResimYukle { get; set; }
	}
}
