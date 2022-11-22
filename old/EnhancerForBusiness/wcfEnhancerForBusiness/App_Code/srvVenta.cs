using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvVenta : IsrvVenta
{
    private readonly IVentaLN gobjVentaLN = new VentaLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Venta> recVenta_ENT()
    {
        List<Venta> lObjRespuesta = new List<Venta>();
        try
        {
            lObjRespuesta = gobjVentaLN.recVenta_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Venta recVentaXId_ENT(int pId)
    {
        Venta lObjRespuesta = new Venta();
        try
        {
            lObjRespuesta = gobjVentaLN.recVentaXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insVenta_ENT(Venta pVenta)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjVentaLN.insVenta_ENT(pVenta);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modVenta_ENT(Venta pVenta)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjVentaLN.modVenta_ENT(pVenta);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delVenta_ENT(Venta pVenta)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjVentaLN.delVenta_ENT(pVenta);
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
