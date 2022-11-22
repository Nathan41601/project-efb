using AccesoDatos.Implementacion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IProveedorAD
    {
        //****************ENTIDADES************//
        List<Proveedor> recProveedor_ENT();
        Proveedor recProveedorXId_ENT(int pId);
        bool insProveedor_ENT(Proveedor pProveedor);
        bool modProveedor_ENT(Proveedor pProveedor);
        bool delProveedor_ENT(Proveedor pProveedor);
    }
}
