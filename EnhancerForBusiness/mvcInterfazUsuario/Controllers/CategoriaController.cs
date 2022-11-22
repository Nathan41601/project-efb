using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();
        //****************ENTIDADES*************//
        public ActionResult listarCategoria_ENT()
        {
            List<Categoria> lobjRespuesta = new List<Categoria>();
            List<modeloCategoria> lobjRespuestaModelo = new List<modeloCategoria>();
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCategoria_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCategoria objModeloCategoria;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCategoria = new modeloCategoria();
                            objModeloCategoria.IdCategoria = lcl.IdCategoria;
                            objModeloCategoria.Descripcion = lcl.Descripcion;
                            objModeloCategoria.Estado = lcl.Estado;
                            objModeloCategoria.FechaCreacion = lcl.FechaCreacion;
                            lobjRespuestaModelo.Add(objModeloCategoria);
                        }
                    }
                }

            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View(lobjRespuestaModelo);
        }

        public ActionResult agregarCategoria_ENT()
        {
            return View();
        }

        public ActionResult modificarCategoria_ENT(int pId)
        {
            Categoria lobjRespuesta = new Categoria();
            modeloCategoria lobjModeloCategoria;
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCategoriaXId_ENT(pId);
                    lobjModeloCategoria = new modeloCategoria();
                    lobjModeloCategoria.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloCategoria.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloCategoria.Estado = lobjRespuesta.Estado;
                    lobjModeloCategoria.FechaCreacion = lobjRespuesta.FechaCreacion;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloCategoria);
        }

        public ActionResult eliminarCategoria_ENT(int pId)
        {
            Categoria lobjRespuesta = new Categoria();
            modeloCategoria lobjModeloCategoria;
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCategoriaXId_ENT(pId);
                    lobjModeloCategoria = new modeloCategoria();
                    lobjModeloCategoria.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloCategoria.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloCategoria.Estado = lobjRespuesta.Estado;
                    lobjModeloCategoria.FechaCreacion = lobjRespuesta.FechaCreacion;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCategoria);
        }

        public ActionResult detalleCategoria_ENT(int pId)
        {
            Categoria lobjRespuesta = new Categoria();
            modeloCategoria lobjModeloCategoria;
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCategoriaXId_ENT(pId);
                    lobjModeloCategoria = new modeloCategoria();
                    lobjModeloCategoria.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloCategoria.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloCategoria.Estado = lobjRespuesta.Estado;
                    lobjModeloCategoria.FechaCreacion = lobjRespuesta.FechaCreacion;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCategoria);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloCategoria pModeloCategoria)
        {
            Categoria pCategoria = new Categoria();
            pCategoria.IdCategoria = pModeloCategoria.IdCategoria;
            pCategoria.Descripcion = pModeloCategoria.Descripcion;
            pCategoria.Estado = pModeloCategoria.Estado;
            pCategoria.FechaCreacion = pModeloCategoria.FechaCreacion;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pCategoria);
                case "Modificar":
                    return modificarCl_ENT(pCategoria);
                case "Eliminar":
                    return eliminarCl_ENT(pCategoria);
                default:
                    return RedirectToAction("listarCategoria_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Categoria pCategoria)
        {
            List<Categoria> lobjRespuesta = new List<Categoria>();
            List<modeloCategoria> lobjRespuestaModelo = new List<modeloCategoria>();
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    if (srvWCF_Cl.insCategoria_ENT(pCategoria))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCategoria_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCategoria objModeloCategoria;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCategoria = new modeloCategoria();
                            objModeloCategoria.IdCategoria = lcl.IdCategoria;
                            objModeloCategoria.Descripcion = lcl.Descripcion;
                            objModeloCategoria.Estado = lcl.Estado;
                            objModeloCategoria.FechaCreacion = lcl.FechaCreacion;
                            lobjRespuestaModelo.Add(objModeloCategoria);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCategoria_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Categoria pCategoria)
        {
            List<Categoria> lobjRespuesta = new List<Categoria>();
            List<modeloCategoria> lobjRespuestaModelo = new List<modeloCategoria>();
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    if (srvWCF_Cl.modCategoria_ENT(pCategoria))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCategoria_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCategoria objModeloCategoria;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCategoria = new modeloCategoria();
                            objModeloCategoria.IdCategoria = lcl.IdCategoria;
                            objModeloCategoria.Descripcion = lcl.Descripcion;
                            objModeloCategoria.Estado = lcl.Estado;
                            objModeloCategoria.FechaCreacion = lcl.FechaCreacion;
                            lobjRespuestaModelo.Add(objModeloCategoria);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCategoria_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Categoria pCategoria)
        {
            List<Categoria> lobjRespuesta = new List<Categoria>();
            List<modeloCategoria> lobjRespuestaModelo = new List<modeloCategoria>();
            try
            {
                using (srvCategoria.IsrvCategoriaClient srvWCF_Cl = new srvCategoria.IsrvCategoriaClient())
                {
                    if (srvWCF_Cl.delCategoria_ENT(pCategoria))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCategoria_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCategoria objModeloCategoria;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCategoria = new modeloCategoria();
                            objModeloCategoria.IdCategoria = lcl.IdCategoria;
                            objModeloCategoria.Descripcion = lcl.Descripcion;
                            objModeloCategoria.Estado = lcl.Estado;
                            objModeloCategoria.FechaCreacion = lcl.FechaCreacion;
                            lobjRespuestaModelo.Add(objModeloCategoria);
                        }
                    }
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return View("listarCategoria_ENT", lobjRespuestaModelo);
        }
    }
}