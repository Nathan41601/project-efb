using AccesoDatos.Implementacion;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Interfaces
{
    public interface ICategoriaAD
    {
        //****************ENTIDADES************//
        List<Categoria> recCategoria_ENT();
        Categoria recCategoriaXId_ENT(int pId);
        bool insCategoria_ENT(Categoria pCategoria);
        bool modCategoria_ENT(Categoria pCategoria);
        bool delCategoria_ENT(Categoria pCategoria);
    }
}
