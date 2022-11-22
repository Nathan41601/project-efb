using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvCompra : IsrvCompra
{
    private readonly ICompraLN gobjCompraLN = new CompraLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Compra> recCompra_ENT()
    {
        List<Compra> lObjRespuesta = new List<Compra>();
        try
        {
            lObjRespuesta = gobjCompraLN.recCompra_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Compra recCompraXId_ENT(int pId)
    {
        Compra lObjRespuesta = new Compra();
        try
        {
            lObjRespuesta = gobjCompraLN.recCompraXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insCompra_ENT(Compra pCompra)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCompraLN.insCompra_ENT(pCompra);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modCompra_ENT(Compra pCompra)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCompraLN.modCompra_ENT(pCompra);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delCompra_ENT(Compra pCompra)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjCompraLN.delCompra_ENT(pCompra);
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

