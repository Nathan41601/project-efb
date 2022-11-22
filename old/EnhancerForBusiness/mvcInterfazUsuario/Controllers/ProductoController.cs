using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class ProductoController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();
        //****************ENTIDADES*************//
        public ActionResult listarProducto_ENT()
        {
            List<Producto> lobjRespuesta = new List<Producto>();
            List<modeloProducto> lobjRespuestaModelo = new List<modeloProducto>();
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProducto_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProducto objModeloProducto;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProducto = new modeloProducto();
                            objModeloProducto.IdProducto = lcl.IdProducto;
                            objModeloProducto.Codigo = lcl.Codigo;
                            objModeloProducto.Nombre = lcl.Nombre;
                            objModeloProducto.Descripcion = lcl.Descripcion;
                            objModeloProducto.IdCategoria = lcl.IdCategoria;
                            objModeloProducto.Stock = lcl.Stock;
                            objModeloProducto.Precio = lcl.Precio;
                            objModeloProducto.Estado = lcl.Estado;
                            objModeloProducto.FechaRegistro = lcl.FechaRegistro;
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

        public ActionResult agregarProducto_ENT()
        {
            return View();
        }

        public ActionResult modificarProducto_ENT(int pId)
        {
            Producto lobjRespuesta = new Producto();
            modeloProducto lobjModeloProducto;
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProductoXId_ENT(pId);
                    lobjModeloProducto = new modeloProducto();
                    lobjModeloProducto.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloProducto.Codigo = lobjRespuesta.Codigo;
                    lobjModeloProducto.Nombre = lobjRespuesta.Nombre;
                    lobjModeloProducto.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloProducto.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloProducto.Stock = lobjRespuesta.Stock;
                    lobjModeloProducto.Precio = lobjRespuesta.Precio;
                    lobjModeloProducto.Estado = lobjRespuesta.Estado;
                    lobjModeloProducto.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloProducto);
        }

        public ActionResult eliminarProducto_ENT(int pId)
        {
            Producto lobjRespuesta = new Producto();
            modeloProducto lobjModeloProducto;
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProductoXId_ENT(pId);
                    lobjModeloProducto = new modeloProducto();
                    lobjModeloProducto.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloProducto.Codigo = lobjRespuesta.Codigo;
                    lobjModeloProducto.Nombre = lobjRespuesta.Nombre;
                    lobjModeloProducto.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloProducto.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloProducto.Stock = lobjRespuesta.Stock;
                    lobjModeloProducto.Precio = lobjRespuesta.Precio;
                    lobjModeloProducto.Estado = lobjRespuesta.Estado;
                    lobjModeloProducto.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloProducto);
        }

        public ActionResult detalleProducto_ENT(int pId)
        {
            Producto lobjRespuesta = new Producto();
            modeloProducto lobjModeloProducto;
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProductoXId_ENT(pId);
                    lobjModeloProducto = new modeloProducto();
                    lobjModeloProducto.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloProducto.Codigo = lobjRespuesta.Codigo;
                    lobjModeloProducto.Nombre = lobjRespuesta.Nombre;
                    lobjModeloProducto.Descripcion = lobjRespuesta.Descripcion;
                    lobjModeloProducto.IdCategoria = lobjRespuesta.IdCategoria;
                    lobjModeloProducto.Stock = lobjRespuesta.Stock;
                    lobjModeloProducto.Precio = lobjRespuesta.Precio;
                    lobjModeloProducto.Estado = lobjRespuesta.Estado;
                    lobjModeloProducto.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloProducto);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloProducto pModeloProducto)
        {
            Producto pProducto = new Producto();
            pProducto.IdProducto = pModeloProducto.IdProducto;
            pProducto.Codigo = pModeloProducto.Codigo;
            pProducto.Nombre = pModeloProducto.Nombre;
            pProducto.Descripcion = pModeloProducto.Descripcion;
            pProducto.IdCategoria = pModeloProducto.IdCategoria;
            pProducto.Stock = pModeloProducto.Stock;
            pProducto.Precio = pModeloProducto.Precio;
            pProducto.Estado = pModeloProducto.Estado;
            pProducto.FechaRegistro = pModeloProducto.FechaRegistro;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pProducto);
                case "Modificar":
                    return modificarCl_ENT(pProducto);
                case "Eliminar":
                    return eliminarCl_ENT(pProducto);
                default:
                    return RedirectToAction("listarProducto_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Producto pProducto)
        {
            List<Producto> lobjRespuesta = new List<Producto>();
            List<modeloProducto> lobjRespuestaModelo = new List<modeloProducto>();
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    if (srvWCF_Cl.insProducto_ENT(pProducto))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProducto_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProducto objModeloProducto;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProducto = new modeloProducto();
                            objModeloProducto.IdProducto = lcl.IdProducto;
                            objModeloProducto.Codigo = lcl.Codigo;
                            objModeloProducto.Nombre = lcl.Nombre;
                            objModeloProducto.Descripcion = lcl.Descripcion;
                            objModeloProducto.IdCategoria = lcl.IdCategoria;
                            objModeloProducto.Stock = lcl.Stock;
                            objModeloProducto.Precio = lcl.Precio;
                            objModeloProducto.Estado = lcl.Estado;
                            objModeloProducto.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProducto);
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
            return View("listarProducto_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Producto pProducto)
        {
            List<Producto> lobjRespuesta = new List<Producto>();
            List<modeloProducto> lobjRespuestaModelo = new List<modeloProducto>();
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    if (srvWCF_Cl.modProducto_ENT(pProducto))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProducto_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProducto objModeloProducto;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProducto = new modeloProducto();
                            objModeloProducto.IdProducto = lcl.IdProducto;
                            objModeloProducto.Codigo = lcl.Codigo;
                            objModeloProducto.Nombre = lcl.Nombre;
                            objModeloProducto.Descripcion = lcl.Descripcion;
                            objModeloProducto.IdCategoria = lcl.IdCategoria;
                            objModeloProducto.Stock = lcl.Stock;
                            objModeloProducto.Precio = lcl.Precio;
                            objModeloProducto.Estado = lcl.Estado;
                            objModeloProducto.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProducto);
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
            return View("listarProducto_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Producto pProducto)
        {
            List<Producto> lobjRespuesta = new List<Producto>();
            List<modeloProducto> lobjRespuestaModelo = new List<modeloProducto>();
            try
            {
                using (srvProducto.IsrvProductoClient srvWCF_Cl = new srvProducto.IsrvProductoClient())
                {
                    if (srvWCF_Cl.delProducto_ENT(pProducto))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProducto_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProducto objModeloProducto;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProducto = new modeloProducto();
                            objModeloProducto.IdProducto = lcl.IdProducto;
                            objModeloProducto.Codigo = lcl.Codigo;
                            objModeloProducto.Nombre = lcl.Nombre;
                            objModeloProducto.Descripcion = lcl.Descripcion;
                            objModeloProducto.IdCategoria = lcl.IdCategoria;
                            objModeloProducto.Stock = lcl.Stock;
                            objModeloProducto.Precio = lcl.Precio;
                            objModeloProducto.Estado = lcl.Estado;
                            objModeloProducto.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProducto);
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
            return View("listarProducto_ENT", lobjRespuestaModelo);
        }
    }
}