using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvCategoria : IsrvCategoria
{
    private readonly ICategoriaLN gobjCategoriaLN = new CategoriaLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Categoria> recCategoria_ENT()
    {
        List<Categoria> lObjRespuesta = new List<Categoria>();
        try
        {
            lObjRespuesta = gobjCategoriaLN.recCategoria_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Categoria recCategoriaXId_ENT(int pId)
    {
        Categoria lObjRespuesta = new Categoria();
        try
        {
            lObjRespuesta = gobjCategoriaLN.recCategoriaXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insCategoria_ENT(Categoria pCategoria)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCategoriaLN.insCategoria_ENT(pCategoria);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modCategoria_ENT(Categoria pCategoria)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCategoriaLN.modCategoria_ENT(pCategoria);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delCategoria_ENT(Categoria pCategoria)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCategoriaLN.delCategoria_ENT(pCategoria);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }
}


