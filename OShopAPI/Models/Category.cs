using System.ComponentModel.DataAnnotations;

namespace OShopAPI.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(255)]
        public string CategoryName { get; set; }

    }
}
