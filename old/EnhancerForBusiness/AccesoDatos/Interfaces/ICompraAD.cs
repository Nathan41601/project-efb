using AccesoDatos.Implementacion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ICompraAD
    {
        //****************ENTIDADES************//
        List<Compra> recCompra_ENT();
        Compra recCompraXId_ENT(int pId);
        bool insCompra_ENT(Compra pCompra);
        bool modCompra_ENT(Compra pCompra);
        bool delCompra_ENT(Compra pCompra);
    }
}
