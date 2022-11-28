using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.ModelBinding;

namespace EnhancerForBusiness_Web.Models
{
    //[Bind(Include = "FirstName,LastName,Address,City,State,PostalCode,Country,Phone,Email")]
    public class Order
    {
        [BindNever]
        [ScaffoldColumn(false)]
        public int OrderId { get; set; }

        [BindNever]
        [Display(Name = "Fecha de Pedido")]
        [ScaffoldColumn(false)]
        public System.DateTime OrderDate { get; set; }

        [BindNever]
        [Required(ErrorMessage = "El campo Usuario es requerido.")]
        [Display(Name = "Usuario")]
        [ScaffoldColumn(false)]
        public string Username { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [Display(Name = "Nombre")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo Dirección es requerido.")]
        [Display(Name = "Dirección")]
        [StringLength(70, MinimumLength = 3)]
        public string Address { get; set; }

        [Required(ErrorMessage = "El campo Cantón es requerido.")]
        [Display(Name = "Cantón")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "La campo Provinvia es requerido.")]
        [Display(Name = "Provincia")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "El campo Código Postal es requerido.")]
        [Display(Name = "Código Postal")]
        [StringLength(10, MinimumLength = 5)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "El campo Distrito es requerido.")]
        [Display(Name = "Distrito")]
        [StringLength(40)]
        public string Country { get; set; }

        [Required(ErrorMessage = "El campo Teléfono es requerido.")]
        [Display(Name = "Teléfono")]
        [StringLength(24)]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "El campo Correo Electrónico es requerido.")]
        [Display(Name = "Correo Electrónico")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "El correo electrónico no es válido.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [BindNever]
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
