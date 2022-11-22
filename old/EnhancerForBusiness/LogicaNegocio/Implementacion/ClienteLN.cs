using AccesoDatos;
using AccesoDatos.Implementacion;
using AccesoDatos.Interfaces;
using Entidades;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;

namespace LogicaNegocio.Implementacion
{
    public class ClienteLN : IClienteLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly IClienteAD gobjClienteAD = new ClienteAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Cliente> recCliente_ENT()
        {
            List<Cliente> lObjRespuesta = new List<Cliente>();
            try
            {
                lObjRespuesta = gobjClienteAD.recCliente_ENT();
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
                lObjRespuesta = gobjClienteAD.recClienteXId_ENT(pId);
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
                lObjRespuesta = gobjClienteAD.insCliente_ENT(pCliente);
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
                lObjRespuesta = gobjClienteAD.modCliente_ENT(pCliente);
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
                lObjRespuesta = gobjClienteAD.delCliente_ENT(pCliente);
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
}
