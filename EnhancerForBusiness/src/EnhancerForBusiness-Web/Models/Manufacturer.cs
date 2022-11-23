using System.ComponentModel.DataAnnotations;

namespace EnhancerForBusiness_Web.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}