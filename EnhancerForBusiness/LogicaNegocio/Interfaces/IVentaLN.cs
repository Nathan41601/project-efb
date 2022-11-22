using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IVentaLN
    {
        //****************ENTIDADES************//
        List<Venta> recVenta_ENT();
        Venta recVentaXId_ENT(int pId);
        bool insVenta_ENT(Venta pVenta);
        bool modVenta_ENT(Venta pVenta);
        bool delVenta_ENT(Venta pVenta);
    }
}

