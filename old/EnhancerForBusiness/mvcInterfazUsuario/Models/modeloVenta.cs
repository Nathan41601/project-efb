using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloVenta
    {
        [Display(Name = "ID Venta")]
        [Editable(allowEdit: false)]
        public int IdVenta { get; set; }

        [Display(Name = "Cliente")]
        [Editable(allowEdit: false)]
        public int IdCliente { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(15, ErrorMessage = "El nombre debe tener 15 caracteres como máximo")]
        public string TipoDocumento { get; set; }

        [Display(Name = "Número Documento")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(15, ErrorMessage = "El nombre debe tener 15 caracteres como máximo")]
        public string NumeroDocumento { get; set; }

        [Required(ErrorMessage = "El producto es requerido, verifique...")]
        [Display(Name = "Producto")]
        [MaxLength(15, ErrorMessage = "El producto debe tener 30 caracteres como máximo")]
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "La cantidad es requerida, verifique...")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Display(Name = "Precio Unidad")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener 10 caracteres como máximo")]
        public decimal PrecioUnidad { get; set; }

        [Display(Name = "Monto Total")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener 10 caracteres como máximo")]
        public decimal MontoTotal { get; set; }

        [Display(Name = "Monto Pago")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener 10 caracteres como máximo")]
        public decimal MontoPago { get; set; }

        [Display(Name = "Monto Cambio")]
        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [MaxLength(10, ErrorMessage = "El nombre debe tener 10 caracteres como máximo")]
        public decimal MontoCambio { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Hora de Registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaRegistro { get; set; }
    }
}