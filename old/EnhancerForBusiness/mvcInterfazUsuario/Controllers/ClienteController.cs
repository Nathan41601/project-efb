using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class ClienteController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES*************//
        public ActionResult listarCliente_ENT()
        {
            List<Cliente> lobjRespuesta = new List<Cliente>();
            List<modeloCliente> lobjRespuestaModelo = new List<modeloCliente>();
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCliente_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCliente objModeloCliente;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCliente = new modeloCliente();
                            objModeloCliente.IdCliente = lcl.IdCliente;
                            objModeloCliente.TipoDocumento = lcl.TipoDocumento;
                            objModeloCliente.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloCliente.NombreCompleto = lcl.NombreCompleto;
                            objModeloCliente.Telefono = lcl.Telefono;
                            objModeloCliente.CorreoElectronico = lcl.CorreoElectronico;
                            objModeloCliente.Estado = lcl.Estado;
                            objModeloCliente.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCliente);
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

        public ActionResult agregarCliente_ENT()
        {
            return View();
        }

        public ActionResult modificarCliente_ENT(int pId)
        {
            Cliente lobjRespuesta = new Cliente();
            modeloCliente lobjModeloCliente;
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    lobjRespuesta = srvWCF_Cl.recClienteXId_ENT(pId);
                    lobjModeloCliente = new modeloCliente();
                    lobjModeloCliente.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloCliente.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCliente.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloCliente.Telefono = lobjRespuesta.Telefono;
                    lobjModeloCliente.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                    lobjModeloCliente.Estado = lobjRespuesta.Estado;
                    lobjModeloCliente.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloCliente);
        }

        public ActionResult eliminarCliente_ENT(int pId)
        {
            Cliente lobjRespuesta = new Cliente();
            modeloCliente lobjModeloCliente;
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    lobjRespuesta = srvWCF_Cl.recClienteXId_ENT(pId);
                    lobjModeloCliente = new modeloCliente();
                    lobjModeloCliente = new modeloCliente();
                    lobjModeloCliente.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloCliente.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCliente.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloCliente.Telefono = lobjRespuesta.Telefono;
                    lobjModeloCliente.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                    lobjModeloCliente.Estado = lobjRespuesta.Estado;
                    lobjModeloCliente.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCliente);
        }

        public ActionResult detalleCliente_ENT(int pId)
        {
            Cliente lobjRespuesta = new Cliente();
            modeloCliente lobjModeloCliente;
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    lobjRespuesta = srvWCF_Cl.recClienteXId_ENT(pId);
                    lobjModeloCliente = new modeloCliente();
                    lobjModeloCliente = new modeloCliente();
                    lobjModeloCliente.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloCliente.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCliente.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloCliente.Telefono = lobjRespuesta.Telefono;
                    lobjModeloCliente.CorreoElectronico = lobjRespuesta.CorreoElectronico;
                    lobjModeloCliente.Estado = lobjRespuesta.Estado;
                    lobjModeloCliente.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCliente);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloCliente pModeloCliente)
        {
            Cliente pCliente = new Cliente();
            pCliente.IdCliente = pModeloCliente.IdCliente;
            pCliente.TipoDocumento = pModeloCliente.TipoDocumento;
            pCliente.NumeroDocumento = pModeloCliente.NumeroDocumento;
            pCliente.Telefono = pModeloCliente.Telefono;
            pCliente.CorreoElectronico = pModeloCliente.CorreoElectronico;
            pCliente.Estado = pModeloCliente.Estado;
            pCliente.FechaRegistro = pModeloCliente.FechaRegistro;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pCliente);
                case "Modificar":
                    return modificarCl_ENT(pCliente);
                case "Eliminar":
                    return eliminarCl_ENT(pCliente);
                default:
                    return RedirectToAction("listarCliente_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Cliente pCliente)
        {
            List<Cliente> lobjRespuesta = new List<Cliente>();
            List<modeloCliente> lobjRespuestaModelo = new List<modeloCliente>();
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    if (srvWCF_Cl.insCliente_ENT(pCliente))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCliente_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCliente objModeloCliente;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCliente = new modeloCliente();
                            objModeloCliente.IdCliente = lcl.IdCliente;
                            objModeloCliente.TipoDocumento = lcl.TipoDocumento;
                            objModeloCliente.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloCliente.NombreCompleto = lcl.NombreCompleto;
                            objModeloCliente.Telefono = lcl.Telefono;
                            objModeloCliente.CorreoElectronico = lcl.CorreoElectronico;
                            objModeloCliente.Estado = lcl.Estado;
                            objModeloCliente.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCliente);
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
            return View("listarCliente_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Cliente pCliente)
        {
            List<Cliente> lobjRespuesta = new List<Cliente>();
            List<modeloCliente> lobjRespuestaModelo = new List<modeloCliente>();
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    if (srvWCF_Cl.modCliente_ENT(pCliente))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCliente_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCliente objModeloCliente;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCliente = new modeloCliente();
                            objModeloCliente.IdCliente = lcl.IdCliente;
                            objModeloCliente.TipoDocumento = lcl.TipoDocumento;
                            objModeloCliente.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloCliente.NombreCompleto = lcl.NombreCompleto;
                            objModeloCliente.Telefono = lcl.Telefono;
                            objModeloCliente.CorreoElectronico = lcl.CorreoElectronico;
                            objModeloCliente.Estado = lcl.Estado;
                            objModeloCliente.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCliente);
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
            return View("listarCliente_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Cliente pCliente)
        {
            List<Cliente> lobjRespuesta = new List<Cliente>();
            List<modeloCliente> lobjRespuestaModelo = new List<modeloCliente>();
            try
            {
                using (srvCliente.IsrvClienteClient srvWCF_Cl = new srvCliente.IsrvClienteClient())
                {
                    if (srvWCF_Cl.delCliente_ENT(pCliente))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCliente_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCliente objModeloCliente;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCliente = new modeloCliente();
                            objModeloCliente.IdCliente = lcl.IdCliente;
                            objModeloCliente.TipoDocumento = lcl.TipoDocumento;
                            objModeloCliente.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloCliente.NombreCompleto = lcl.NombreCompleto;
                            objModeloCliente.Telefono = lcl.Telefono;
                            objModeloCliente.CorreoElectronico = lcl.CorreoElectronico;
                            objModeloCliente.Estado = lcl.Estado;
                            objModeloCliente.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCliente);
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
            return View("listarCliente_ENT", lobjRespuestaModelo);
        }
    }
}