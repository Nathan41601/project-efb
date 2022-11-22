using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloCliente
    {
        [Editable(allowEdit: false)]
        [Display(Name = "ID Cliente")]
        public int IdCliente { get; set; }

        [Required(ErrorMessage = "El tipo de documento es requerido, verifique...")]
        [Display(Name = "Documento")]
        public string TipoDocumento { get; set; }

        [Required(ErrorMessage = "El numero de documento es requerido, verifique...")]
        [Display(Name = "Número Documento")]
        [MaxLength(12, ErrorMessage = "El numero de documento debe tener 12 caracteres como máximo")]
        public string NumeroDocumento { get; set; }

        [Required(ErrorMessage = "El nombre es requerido, verifique...")]
        [Display(Name = "Nombre del Cliente")]
        [MaxLength(50, ErrorMessage = "El nombre debe tener 50 caracteres como máximo")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El telefono es requerido, verifique...")]
        [Display(Name = "Teléfono")]
        [MaxLength(12, ErrorMessage = "El telefono tener 12 caracteres como máximo")]
        public string Telefono { get; set; }

        [Required(ErrorMessage = "El correo electronico es requerido, verifique...")]
        [Display(Name = "Correo Electrónico")]
        [MaxLength(50, ErrorMessage = "El correo debe tener 50 caracteres como máximo")]
        public string CorreoElectronico { get; set; }

        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Fecha de Registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaRegistro { get; set; }
    }
}