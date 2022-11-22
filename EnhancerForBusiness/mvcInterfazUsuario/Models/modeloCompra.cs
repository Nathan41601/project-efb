using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloCompra
    {
        [Display(Name = "ID Compra")]
        [Editable(allowEdit: false)]
        public int IdCompra { get; set; }

        [Display(Name = "Categoria")]
        [Editable(allowEdit: false)]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [Display(Name = "Documento")]
        [MaxLength(15, ErrorMessage = "El tipo de documento debe tener 15 caracteres como máximo")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El numero de factura es requerido, verifique...")]
        [Display(Name = "Número Factura")]
        [MaxLength(15, ErrorMessage = "El numero de factura debe tener 15 caracteres como máximo")]
        public string NumeroFactura { get; set; }

        [Required(ErrorMessage = "El producto es requerido, verifique...")]
        [Display(Name = "Producto")]
        [MaxLength(15, ErrorMessage = "El producto debe tener 30 caracteres como máximo")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida, verifique...")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "El precio de unidad es requerido, verifique...")]
        [Display(Name = "Precio Unidad")]
        [MaxLength(15, ErrorMessage = "El precio de unidad debe tener 15 caracteres como máximo")]
        public decimal PrecioUnidad { get; set; }

        [Required(ErrorMessage = "El monto de la compra es requerido, verifique...")]
        [Display(Name = "Monto Total")]
        [MaxLength(10, ErrorMessage = "El monto de compra debe tener 10 caracteres como máximo")]
        public decimal MontoTotal { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Hora de registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaRegistro { get; set; }
    }
}