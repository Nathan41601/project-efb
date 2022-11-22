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
    public class CompraLN : ICompraLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly ICompraAD gobjCompraAD = new CompraAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Compra> recCompra_ENT()
        {
            List<Compra> lObjRespuesta = new List<Compra>();
            try
            {
                lObjRespuesta = gobjCompraAD.recCompra_ENT();
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
                lObjRespuesta = gobjCompraAD.recCompraXId_ENT(pId);
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
                lObjRespuesta = gobjCompraAD.insCompra_ENT(pCompra);
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
                lObjRespuesta = gobjCompraAD.modCompra_ENT(pCompra);
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
                lObjRespuesta = gobjCompraAD.delCompra_ENT(pCompra);
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
