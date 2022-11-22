using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvCompra
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Compra> recCompra_ENT();
    [OperationContract]
    Compra recCompraXId_ENT(int pId);
    [OperationContract]
    bool insCompra_ENT(Compra pCompra);
    [OperationContract]
    bool modCompra_ENT(Compra pCompra);
    [OperationContract]
    bool delCompra_ENT(Compra pCompra);
}
