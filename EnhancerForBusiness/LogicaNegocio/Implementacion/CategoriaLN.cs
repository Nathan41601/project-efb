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
    public class CategoriaLN : ICategoriaLN
    {
        public static CMEntidades _objContextoCM = new CMEntidades();
        private readonly ICategoriaAD gobjCategoriaAD = new CategoriaAD(_objContextoCM);
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//
        public List<Categoria> recCategoria_ENT()
        {
            List<Categoria> lObjRespuesta = new List<Categoria>();
            try
            {
                lObjRespuesta = gobjCategoriaAD.recCategoria_ENT();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        public Categoria recCategoriaXId_ENT(int pId)
        {
            Categoria lObjRespuesta = new Categoria();
            try
            {
                lObjRespuesta = gobjCategoriaAD.recCategoriaXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        public bool insCategoria_ENT(Categoria pCategoria)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = gobjCategoriaAD.insCategoria_ENT(pCategoria);
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        public bool modCategoria_ENT(Categoria pCategoria)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = gobjCategoriaAD.modCategoria_ENT(pCategoria);
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        public bool delCategoria_ENT(Categoria pCategoria)
        {
            bool lObjRespuesta = false;
            try
            {
                lObjRespuesta = gobjCategoriaAD.delCategoria_ENT(pCategoria);
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
