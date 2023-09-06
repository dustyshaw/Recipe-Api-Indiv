using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RECIAPI.Models
{
    [Table("Instructions")]
    public class Ingredient
    {
        [Key]
        [Required]
        public string IngredientName { get; set; }

        [Required]
        public string Unit { get; set; }

        [Required]
        public int Amount { get; set; } 
    }
}
