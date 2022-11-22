using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloProveedor
    {
        [Display(Name = "ID Proveedor")]
        [Editable(allowEdit: false)]
        public int IdProveedor { get; set; }

        [Required(ErrorMessage = "La identificacion es requerida, verifique...")]
        [Display(Name = "Identificación")]
        [MaxLength(15, ErrorMessage = "El identificacion debe tener 15 caracteres como máximo")]
        public string Identificacion { get; set; }

        [Required(ErrorMessage = "La razon social es requerida, verifique...")]
        [Display(Name = "Razón Social")]
        [MaxLength(50, ErrorMessage = "La razon social debe tener 50 caracteres como máximo")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El correo es requerido, verifique...")]
        [Display(Name = "Correo Electrónico")]
        [MaxLength(50, ErrorMessage = "El correo debe tener 50 caracteres como máximo")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "La direccion es requerida, verifique...")]
        [Display(Name = "Dirección")]
        [MaxLength(100, ErrorMessage = "La direccion debe tener 100 caracteres como máximo")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El estado de documento es requerido, verifique...")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Hora de registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaRegistro { get; set; }
    }
}