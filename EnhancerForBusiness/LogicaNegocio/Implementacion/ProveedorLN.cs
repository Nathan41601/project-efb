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
    public class ProveedorLN : IProveedorLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly IProveedorAD gobjProveedorAD = new ProveedorAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Proveedor> recProveedor_ENT()
        {
            List<Proveedor> lObjRespuesta = new List<Proveedor>();
            try
            {
                lObjRespuesta = gobjProveedorAD.recProveedor_ENT();
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
                lObjRespuesta = gobjProveedorAD.recProveedorXId_ENT(pId);
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
                lObjRespuesta = gobjProveedorAD.insProveedor_ENT(pProveedor);
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
                lObjRespuesta = gobjProveedorAD.modProveedor_ENT(pProveedor);
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
                lObjRespuesta = gobjProveedorAD.delProveedor_ENT(pProveedor);
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
