using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();
        //****************ENTIDADES*************//
        public ActionResult listarProveedor_ENT()
        {
            List<Proveedor> lobjRespuesta = new List<Proveedor>();
            List<modeloProveedor> lobjRespuestaModelo = new List<modeloProveedor>();
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProveedor_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProveedor objModeloProveedor;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProveedor = new modeloProveedor();
                            objModeloProveedor.IdProveedor = lcl.IdProveedor;
                            objModeloProveedor.Identificacion = lcl.Identificacion;
                            objModeloProveedor.RazonSocial = lcl.RazonSocial;
                            objModeloProveedor.Correo = lcl.Correo;
                            objModeloProveedor.Direccion = lcl.Direccion;
                            objModeloProveedor.Estado = lcl.Estado;
                            objModeloProveedor.FechaRegistro = lcl.FechaRegistro;
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

        public ActionResult agregarProveedor_ENT()
        {
            return View();
        }

        public ActionResult modificarProveedor_ENT(int pId)
        {
            Proveedor lobjRespuesta = new Proveedor();
            modeloProveedor lobjModeloProveedor;
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProveedorXId_ENT(pId);
                    lobjModeloProveedor = new modeloProveedor();
                    lobjModeloProveedor.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloProveedor.Identificacion = lobjRespuesta.Identificacion;
                    lobjModeloProveedor.RazonSocial = lobjRespuesta.RazonSocial;
                    lobjModeloProveedor.Correo = lobjRespuesta.Correo;
                    lobjModeloProveedor.Direccion = lobjRespuesta.Direccion;
                    lobjModeloProveedor.Estado = lobjRespuesta.Estado;
                    lobjModeloProveedor.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloProveedor);
        }

        public ActionResult eliminarProveedor_ENT(int pId)
        {
            Proveedor lobjRespuesta = new Proveedor();
            modeloProveedor lobjModeloProveedor;
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProveedorXId_ENT(pId);
                    lobjModeloProveedor = new modeloProveedor();
                    lobjModeloProveedor.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloProveedor.Identificacion = lobjRespuesta.Identificacion;
                    lobjModeloProveedor.RazonSocial = lobjRespuesta.RazonSocial;
                    lobjModeloProveedor.Correo = lobjRespuesta.Correo;
                    lobjModeloProveedor.Direccion = lobjRespuesta.Direccion;
                    lobjModeloProveedor.Estado = lobjRespuesta.Estado;
                    lobjModeloProveedor.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloProveedor);
        }

        public ActionResult detalleProveedor_ENT(int pId)
        {
            Proveedor lobjRespuesta = new Proveedor();
            modeloProveedor lobjModeloProveedor;
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    lobjRespuesta = srvWCF_Cl.recProveedorXId_ENT(pId);
                    lobjModeloProveedor = new modeloProveedor();
                    lobjModeloProveedor.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloProveedor.Identificacion = lobjRespuesta.Identificacion;
                    lobjModeloProveedor.RazonSocial = lobjRespuesta.RazonSocial;
                    lobjModeloProveedor.Correo = lobjRespuesta.Correo;
                    lobjModeloProveedor.Direccion = lobjRespuesta.Direccion;
                    lobjModeloProveedor.Estado = lobjRespuesta.Estado;
                    lobjModeloProveedor.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloProveedor);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloProveedor pModeloProveedor)
        {
            Proveedor pProveedor = new Proveedor();
            pProveedor.IdProveedor = pModeloProveedor.IdProveedor;
            pProveedor.Identificacion = pModeloProveedor.Identificacion;
            pProveedor.RazonSocial = pModeloProveedor.RazonSocial;
            pProveedor.Correo = pModeloProveedor.Correo;
            pProveedor.Direccion = pModeloProveedor.Direccion;
            pProveedor.Estado = pModeloProveedor.Estado;
            pProveedor.FechaRegistro = pModeloProveedor.FechaRegistro;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pProveedor);
                case "Modificar":
                    return modificarCl_ENT(pProveedor);
                case "Eliminar":
                    return eliminarCl_ENT(pProveedor);
                default:
                    return RedirectToAction("listarProveedor_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Proveedor pProveedor)
        {
            List<Proveedor> lobjRespuesta = new List<Proveedor>();
            List<modeloProveedor> lobjRespuestaModelo = new List<modeloProveedor>();
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    if (srvWCF_Cl.insProveedor_ENT(pProveedor))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProveedor_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProveedor objModeloProveedor;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProveedor = new modeloProveedor();
                            objModeloProveedor.IdProveedor = lcl.IdProveedor;
                            objModeloProveedor.Identificacion = lcl.Identificacion;
                            objModeloProveedor.RazonSocial = lcl.RazonSocial;
                            objModeloProveedor.Correo = lcl.Correo;
                            objModeloProveedor.Direccion = lcl.Direccion;
                            objModeloProveedor.Estado = lcl.Estado;
                            objModeloProveedor.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProveedor);
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
            return View("listarProveedor_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Proveedor pProveedor)
        {
            List<Proveedor> lobjRespuesta = new List<Proveedor>();
            List<modeloProveedor> lobjRespuestaModelo = new List<modeloProveedor>();
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    if (srvWCF_Cl.modProveedor_ENT(pProveedor))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProveedor_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProveedor objModeloProveedor;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProveedor = new modeloProveedor();
                            objModeloProveedor.IdProveedor = lcl.IdProveedor;
                            objModeloProveedor.Identificacion = lcl.Identificacion;
                            objModeloProveedor.RazonSocial = lcl.RazonSocial;
                            objModeloProveedor.Correo = lcl.Correo;
                            objModeloProveedor.Direccion = lcl.Direccion;
                            objModeloProveedor.Estado = lcl.Estado;
                            objModeloProveedor.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProveedor);
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
            return View("listarProveedor_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Proveedor pProveedor)
        {
            List<Proveedor> lobjRespuesta = new List<Proveedor>();
            List<modeloProveedor> lobjRespuestaModelo = new List<modeloProveedor>();
            try
            {
                using (srvProveedor.IsrvProveedorClient srvWCF_Cl = new srvProveedor.IsrvProveedorClient())
                {
                    if (srvWCF_Cl.delProveedor_ENT(pProveedor))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recProveedor_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloProveedor objModeloProveedor;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloProveedor = new modeloProveedor();
                            objModeloProveedor.IdProveedor = lcl.IdProveedor;
                            objModeloProveedor.Identificacion = lcl.Identificacion;
                            objModeloProveedor.RazonSocial = lcl.RazonSocial;
                            objModeloProveedor.Correo = lcl.Correo;
                            objModeloProveedor.Direccion = lcl.Direccion;
                            objModeloProveedor.Estado = lcl.Estado;
                            objModeloProveedor.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloProveedor);
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
            return View("listarProveedor_ENT", lobjRespuestaModelo);
        }
    }
}