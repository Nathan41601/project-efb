using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvProveedor : IsrvProveedor
{
    private readonly IProveedorLN gobjProveedorLN = new ProveedorLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Proveedor> recProveedor_ENT()
    {
        List<Proveedor> lObjRespuesta = new List<Proveedor>();
        try
        {
            lObjRespuesta = gobjProveedorLN.recProveedor_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Proveedor recProveedorXId_ENT(int pId)
    {
        Proveedor lObjRespuesta = new Proveedor();
        try
        {
            lObjRespuesta = gobjProveedorLN.recProveedorXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insProveedor_ENT(Proveedor pProveedor)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProveedorLN.insProveedor_ENT(pProveedor);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modProveedor_ENT(Proveedor pProveedor)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProveedorLN.modProveedor_ENT(pProveedor);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delProveedor_ENT(Proveedor pProveedor)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProveedorLN.delProveedor_ENT(pProveedor);
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

