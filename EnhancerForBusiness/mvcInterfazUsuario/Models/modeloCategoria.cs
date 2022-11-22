using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace mvcInterfazUsuario.Models
{
    public class modeloCategoria
    {
        [Editable(allowEdit: false)]
        [Display(Name = "ID Categoria")]
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "Se quiere una descripcion para la categoria, verifique...")]
        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "La descripcion debe tener 100 caracteres como máximo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El estado del producto es requerido, verifique...")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        [Required(ErrorMessage = "La hora de registro es requerida, verifique...")]
        [Display(Name = "Hora de registro")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm:ss}", ApplyFormatInEditMode = true)]
        public System.DateTime FechaCreacion { get; set; }
    }
}