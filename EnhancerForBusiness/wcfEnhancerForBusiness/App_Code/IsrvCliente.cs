using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvCliente
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Cliente> recCliente_ENT();
    [OperationContract]
    Cliente recClienteXId_ENT(int pId);
    [OperationContract]
    bool insCliente_ENT(Cliente pCliente);
    [OperationContract]
    bool modCliente_ENT(Cliente pCliente);
    [OperationContract]
    bool delCliente_ENT(Cliente pCliente);
}
