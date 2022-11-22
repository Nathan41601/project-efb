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
    public class ProductoLN : IProductoLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly IProductoAD gobjProductoAD = new ProductoAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Producto> recProducto_ENT()
        {
            List<Producto> lObjRespuesta = new List<Producto>();
            try
            {
                lObjRespuesta = gobjProductoAD.recProducto_ENT();
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
                lObjRespuesta = gobjProductoAD.recProductoXId_ENT(pId);
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
                lObjRespuesta = gobjProductoAD.insProducto_ENT(pProducto);
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
                lObjRespuesta = gobjProductoAD.modProducto_ENT(pProducto);
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
                lObjRespuesta = gobjProductoAD.delProducto_ENT(pProducto);
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
