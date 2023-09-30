using System.ComponentModel.DataAnnotations;

namespace eticarethaftasonu.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        virtual public List<Products> Products { get; set; }
        //kateogir birden fazla ürün bilgiisi taşınambilir
        //
    }
}
