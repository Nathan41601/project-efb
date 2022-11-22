using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvProducto
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Producto> recProducto_ENT();
    [OperationContract]
    Producto recProductoXId_ENT(int pId);
    [OperationContract]
    bool insProducto_ENT(Producto pProducto);
    [OperationContract]
    bool modProducto_ENT(Producto pProducto);
    [OperationContract]
    bool delProducto_ENT(Producto pProducto);
}
