using System.ComponentModel.DataAnnotations;

namespace RECIAPI.Models
{
    public class Recipes_domains
    {
        public Recipe? BoardGame { get; set; }
        public Domain? Domain { get; set; }

        [Key]
        [Required]
        public int RecipeId { get; set; }

        [Key]
        [Required]
        public int DomainId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
