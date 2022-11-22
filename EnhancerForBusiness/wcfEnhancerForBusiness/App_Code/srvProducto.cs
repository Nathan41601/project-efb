using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvProducto : IsrvProducto
{
    private readonly IProductoLN gobjProductoLN = new ProductoLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Producto> recProducto_ENT()
    {
        List<Producto> lObjRespuesta = new List<Producto>();
        try
        {
            lObjRespuesta = gobjProductoLN.recProducto_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Producto recProductoXId_ENT(int pId)
    {
        Producto lObjRespuesta = new Producto();
        try
        {
            lObjRespuesta = gobjProductoLN.recProductoXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insProducto_ENT(Producto pProducto)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProductoLN.insProducto_ENT(pProducto);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modProducto_ENT(Producto pProducto)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProductoLN.modProducto_ENT(pProducto);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delProducto_ENT(Producto pProducto)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjProductoLN.delProducto_ENT(pProducto);
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

