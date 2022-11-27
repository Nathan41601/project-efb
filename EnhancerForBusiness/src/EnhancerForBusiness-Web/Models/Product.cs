using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;
using Newtonsoft.Json;

namespace EnhancerForBusiness_Web.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Sku Number")]
        public string SkuNumber { get; set; }

        [Display(Name = "Categoría")]
        public int CategoryId { get; set; }

        public int RecommendationId { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(160, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Precio")]
        [Range(0.01, 500.00)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Precio de Venta")]
        [Range(0.01, 500.00)]
        [DataType(DataType.Currency)]
        public decimal SalePrice { get; set; }

        [Display(Name = "URL del Producto")]
        [StringLength(1024)]
        public string ProductArtUrl { get; set; }

        [Required]
        [Display(Name = "Descripción")]
        public string Description { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }

        [ScaffoldColumn(false)]
        [BindNever]
        [Required]
        public DateTime Created { get; set; }

        [Required]
        [Display(Name = "Detalles del Producto")]
        public string ProductDetails { get; set; }

        public int Inventory { get; set; }

        public int LeadTime { get; set; }

        public Dictionary<string, string> ProductDetailList
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ProductDetails))
                {
                    return new Dictionary<string, string>();
                }
                return JsonConvert.DeserializeObject<Dictionary<string, string>>(ProductDetails);
            }
        }
    }
}
