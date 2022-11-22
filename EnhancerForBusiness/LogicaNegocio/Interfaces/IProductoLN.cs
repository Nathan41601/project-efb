using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio.Interfaces
{
    public interface IProductoLN
    {
        //****************ENTIDADES************//
        List<Producto> recProducto_ENT();
        Producto recProductoXId_ENT(int pId);
        bool insProducto_ENT(Producto pProducto);
        bool modProducto_ENT(Producto pProducto);
        bool delProducto_ENT(Producto pProducto);
    }
}
