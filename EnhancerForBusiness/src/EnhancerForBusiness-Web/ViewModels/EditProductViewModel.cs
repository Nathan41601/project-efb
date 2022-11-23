using System.Collections.Generic;
using System.Web.Mvc;
using EnhancerForBusiness_Web.Models;

namespace EnhancerForBusiness_Web.ViewModels
{
    public class EditProductViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
    }
}