using System.ComponentModel.DataAnnotations;

namespace OShopAPI.Dtos
{
    public class CategoryDTO
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }
    }
}