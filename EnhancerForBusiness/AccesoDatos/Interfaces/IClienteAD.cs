using Entidades;
using AccesoDatos.Implementacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface IClienteAD
    {
        //****************ENTIDADES************//
        List<Cliente> recCliente_ENT();
        Cliente recClienteXId_ENT(int pId);
        bool insCliente_ENT(Cliente pCliente);
        bool modCliente_ENT(Cliente pCliente);
        bool delCliente_ENT(Cliente pCliente);
    }
}
