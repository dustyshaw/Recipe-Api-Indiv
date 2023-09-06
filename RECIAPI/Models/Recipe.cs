using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace RECIAPI.Models
{
    [Table("Recipes")]
    public class Recipe
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Instructions { get; set; }

        [Required]
        public IEnumerable<Ingredient> Ingredients { get; set; }

        public ICollection<Recipes_domains>? Recipees_Domains { get; set; }
    }
}
