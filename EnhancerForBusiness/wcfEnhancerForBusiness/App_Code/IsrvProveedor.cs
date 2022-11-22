using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvProveedor
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Proveedor> recProveedor_ENT();
    [OperationContract]
    Proveedor recProveedorXId_ENT(int pId);
    [OperationContract]
    bool insProveedor_ENT(Proveedor pProveedor);
    [OperationContract]
    bool modProveedor_ENT(Proveedor pProveedor);
    [OperationContract]
    bool delProveedor_ENT(Proveedor pProveedor);
}
