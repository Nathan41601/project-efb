using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloProducto
    {
        [Display(Name = "ID Producto")]
        [Editable(allowEdit: false)]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "El codigo del producto es requerido, verifique...")]
        [Display(Name = "Código")]
        [MaxLength(10, ErrorMessage = "El codigo del producto debe tener 10 caracteres como máximo")]
        public string Codigo { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido, verifique...")]
        [Display(Name = "Nombre de Producto")]
        [MaxLength(50, ErrorMessage = "El nombre del producto debe tener 50 caracteres como máximo")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "La descripcion del producto es requerida, verifique...")]
        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "La descripcion del producto debe tener 100 caracteres como máximo")]
        public string Descripcion { get; set; }

        [Display(Name = "Categoría")]
        [Editable(allowEdit: false)]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Las unidades de producto es requerida, verifique...")]
        [Display(Name = "Cantidad Disponible")]
        [MaxLength(10, ErrorMessage = "Las unidades de producto debe tener 10 caracteres como máximo")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "El precio del producto es requerido, verifique...")]
        [Display(Name = "Precio de Venta")]
        [MaxLength(10, ErrorMessage = "El precio del producto debe tener 10 caracteres como máximo")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El estado del producto es requerido, verifique...")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Hora de registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaRegistro { get; set; }
    }
}