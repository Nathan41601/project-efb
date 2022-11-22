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
    public class VentaLN : IVentaLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly IVentaAD gobjVentaAD = new VentaAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Venta> recVenta_ENT()
        {
            List<Venta> lObjRespuesta = new List<Venta>();
            try
            {
                lObjRespuesta = gobjVentaAD.recVenta_ENT();
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
                lObjRespuesta = gobjVentaAD.recVentaXId_ENT(pId);
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
                lObjRespuesta = gobjVentaAD.insVenta_ENT(pVenta);
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
                lObjRespuesta = gobjVentaAD.modVenta_ENT(pVenta);
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
                lObjRespuesta = gobjVentaAD.delVenta_ENT(pVenta);
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
