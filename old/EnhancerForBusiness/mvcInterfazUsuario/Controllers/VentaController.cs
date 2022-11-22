using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class VentaController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();
        //****************ENTIDADES*************//
        public ActionResult listarVenta_ENT()
        {
            List<Venta> lobjRespuesta = new List<Venta>();
            List<modeloVenta> lobjRespuestaModelo = new List<modeloVenta>();
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recVenta_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloVenta objModeloVenta;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloVenta = new modeloVenta();
                            objModeloVenta.IdVenta = lcl.IdVenta;
                            objModeloVenta.IdCliente = lcl.IdCliente;
                            objModeloVenta.TipoDocumento = lcl.TipoDocumento;
                            objModeloVenta.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloVenta.MontoPago = lcl.MontoPago;
                            objModeloVenta.MontoCambio = lcl.MontoCambio;
                            objModeloVenta.MontoTotal = lcl.MontoTotal;
                            objModeloVenta.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloVenta);
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

        public ActionResult agregarVenta_ENT()
        {
            return View();
        }

        public ActionResult modificarVenta_ENT(int pId)
        {
            Venta lobjRespuesta = new Venta();
            modeloVenta lobjModeloVenta;
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recVentaXId_ENT(pId);
                    lobjModeloVenta = new modeloVenta();
                    lobjModeloVenta.IdVenta = lobjRespuesta.IdVenta;
                    lobjModeloVenta.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloVenta.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloVenta.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloVenta.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloVenta.MontoPago = lobjRespuesta.MontoPago;
                    lobjModeloVenta.MontoCambio = lobjRespuesta.MontoCambio;
                    lobjModeloVenta.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloVenta.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloVenta);
        }

        public ActionResult eliminarVenta_ENT(int pId)
        {
            Venta lobjRespuesta = new Venta();
            modeloVenta lobjModeloVenta;
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recVentaXId_ENT(pId);
                    lobjModeloVenta = new modeloVenta();
                    lobjModeloVenta.IdVenta = lobjRespuesta.IdVenta;
                    lobjModeloVenta.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloVenta.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloVenta.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloVenta.MontoPago = lobjRespuesta.MontoPago;
                    lobjModeloVenta.MontoCambio = lobjRespuesta.MontoCambio;
                    lobjModeloVenta.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloVenta.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloVenta);
        }

        public ActionResult detalleVenta_ENT(int pId)
        {
            Venta lobjRespuesta = new Venta();
            modeloVenta lobjModeloVenta;
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    lobjRespuesta = srvWCF_Cl.recVentaXId_ENT(pId);
                    lobjModeloVenta = new modeloVenta();
                    lobjModeloVenta.IdVenta = lobjRespuesta.IdVenta;
                    lobjModeloVenta.IdCliente = lobjRespuesta.IdCliente;
                    lobjModeloVenta.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloVenta.NumeroDocumento = lobjRespuesta.NumeroDocumento;
                    lobjModeloVenta.MontoPago = lobjRespuesta.MontoPago;
                    lobjModeloVenta.MontoCambio = lobjRespuesta.MontoCambio;
                    lobjModeloVenta.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloVenta.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloVenta);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloVenta pModeloVenta)
        {
            Venta pVenta = new Venta();
            pVenta.IdVenta = pModeloVenta.IdVenta;
            pVenta.IdCliente = pModeloVenta.IdCliente;
            pVenta.TipoDocumento = pModeloVenta.TipoDocumento;
            pVenta.NumeroDocumento = pModeloVenta.NumeroDocumento;
            pVenta.MontoPago = pModeloVenta.MontoPago;
            pVenta.MontoCambio = pModeloVenta.MontoCambio;
            pVenta.MontoTotal = pModeloVenta.MontoTotal;
            pVenta.FechaRegistro = pModeloVenta.FechaRegistro;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pVenta);
                case "Modificar":
                    return modificarCl_ENT(pVenta);
                case "Eliminar":
                    return eliminarCl_ENT(pVenta);
                default:
                    return RedirectToAction("listarVenta_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Venta pVenta)
        {
            List<Venta> lobjRespuesta = new List<Venta>();
            List<modeloVenta> lobjRespuestaModelo = new List<modeloVenta>();
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    if (srvWCF_Cl.insVenta_ENT(pVenta))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recVenta_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloVenta objModeloVenta;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloVenta = new modeloVenta();
                            objModeloVenta.IdVenta = lcl.IdVenta;
                            objModeloVenta.IdCliente = lcl.IdCliente;
                            objModeloVenta.TipoDocumento = lcl.TipoDocumento;
                            objModeloVenta.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloVenta.MontoPago = lcl.MontoPago;
                            objModeloVenta.MontoCambio = lcl.MontoCambio;
                            objModeloVenta.MontoTotal = lcl.MontoTotal;
                            objModeloVenta.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloVenta);
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
            return View("listarVenta_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Venta pVenta)
        {
            List<Venta> lobjRespuesta = new List<Venta>();
            List<modeloVenta> lobjRespuestaModelo = new List<modeloVenta>();
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    if (srvWCF_Cl.modVenta_ENT(pVenta))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recVenta_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloVenta objModeloVenta;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloVenta = new modeloVenta();
                            objModeloVenta.IdVenta = lcl.IdVenta;
                            objModeloVenta.IdCliente = lcl.IdCliente;
                            objModeloVenta.TipoDocumento = lcl.TipoDocumento;
                            objModeloVenta.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloVenta.MontoPago = lcl.MontoPago;
                            objModeloVenta.MontoCambio = lcl.MontoCambio;
                            objModeloVenta.MontoTotal = lcl.MontoTotal;
                            objModeloVenta.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloVenta);
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
            return View("listarVenta_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Venta pVenta)
        {
            List<Venta> lobjRespuesta = new List<Venta>();
            List<modeloVenta> lobjRespuestaModelo = new List<modeloVenta>();
            try
            {
                using (srvVenta.IsrvVentaClient srvWCF_Cl = new srvVenta.IsrvVentaClient())
                {
                    if (srvWCF_Cl.delVenta_ENT(pVenta))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recVenta_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloVenta objModeloVenta;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloVenta = new modeloVenta();
                            objModeloVenta.IdVenta = lcl.IdVenta;
                            objModeloVenta.IdCliente = lcl.IdCliente;
                            objModeloVenta.TipoDocumento = lcl.TipoDocumento;
                            objModeloVenta.NumeroDocumento = lcl.NumeroDocumento;
                            objModeloVenta.MontoPago = lcl.MontoPago;
                            objModeloVenta.MontoCambio = lcl.MontoCambio;
                            objModeloVenta.MontoTotal = lcl.MontoTotal;
                            objModeloVenta.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloVenta);
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
            return View("listarVenta_ENT", lobjRespuestaModelo);
        }
    }
}