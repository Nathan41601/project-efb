using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;


public class srvCliente : IsrvCliente
{
    private readonly IClienteLN gobjClienteLN = new ClienteLN();
    private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

    //****************ENTIDADES************//
    public List<Cliente> recCliente_ENT()
    {
        List<Cliente> lObjRespuesta = new List<Cliente>();
        try
        {
            lObjRespuesta = gobjClienteLN.recCliente_ENT();
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public Cliente recClienteXId_ENT(int pId)
    {
        Cliente lObjRespuesta = new Cliente();
        try
        {
            lObjRespuesta = gobjClienteLN.recClienteXId_ENT(pId);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool insCliente_ENT(Cliente pCliente)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjClienteLN.insCliente_ENT(pCliente);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool modCliente_ENT(Cliente pCliente)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjClienteLN.modCliente_ENT(pCliente);
        }
        catch (Exception lEx)
        {
            //throw lEx;
            gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
            " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
        }
        return lObjRespuesta;
    }

    public bool delCliente_ENT(Cliente pCliente)
    {
        bool lObjRespuesta = false;
        try
        {
            lObjRespuesta = gobjClienteLN.delCliente_ENT(pCliente);
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

