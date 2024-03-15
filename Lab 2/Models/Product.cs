using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, StringLength(100), DisplayName("Tên sản Phẩm")]
        public string Name { get; set; }
        [Range(0.01, 10000.00), DisplayName("Giá")]
        public decimal Price { get; set; }
        [DisplayName("Mô Tả")]
        public string Description { get; set; }
        public int CategoryId { get; set; }

    }
}
