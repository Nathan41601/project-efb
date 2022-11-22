using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvVenta
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Venta> recVenta_ENT();
    [OperationContract]
    Venta recVentaXId_ENT(int pId);
    [OperationContract]
    bool insVenta_ENT(Venta pVenta);
    [OperationContract]
    bool modVenta_ENT(Venta pVenta);
    [OperationContract]
    bool delVenta_ENT(Venta pVenta);
}
