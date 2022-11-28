using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EnhancerForBusiness_Web.Models
{
    public class Category
    {

        public int CategoryId { get; set; }

        [Required]
        [Display(Name = "Categoría")]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        public string Description { get; set; }

        [Display(Name = "URL de Imagen")]
        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}