using System.ComponentModel.DataAnnotations;

namespace OShopAPI.Dtos
{
    public class ProductDTO
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(255)]
        public string ProductTitle { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}