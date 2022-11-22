using Entidades;
using System.Collections.Generic;
using System.ServiceModel;


[ServiceContract]
public interface IsrvCategoria
{
    //****************ENTIDADES************//
    [OperationContract]
    List<Categoria> recCategoria_ENT();
    [OperationContract]
    Categoria recCategoriaXId_ENT(int pId);
    [OperationContract]
    bool insCategoria_ENT(Categoria pCategoria);
    [OperationContract]
    bool modCategoria_ENT(Categoria pCategoria);
    [OperationContract]
    bool delCategoria_ENT(Categoria pCategoria);
}
