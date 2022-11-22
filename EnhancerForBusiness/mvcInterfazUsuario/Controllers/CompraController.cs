using Entidades;
using mvcInterfazUsuario.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace mvcInterfazUsuario.Controllers
{
    public class CompraController : Controller
    {
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();
        //****************ENTIDADES*************//
        public ActionResult listarCompra_ENT()
        {
            List<Compra> lobjRespuesta = new List<Compra>();
            List<modeloCompra> lobjRespuestaModelo = new List<modeloCompra>();
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCompra_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCompra objModeloCompra;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCompra = new modeloCompra();
                            objModeloCompra.IdCompra = lcl.IdCompra;
                            objModeloCompra.IdProveedor = lcl.IdProveedor;
                            objModeloCompra.TipoDocumento = lcl.TipoDocumento;
                            objModeloCompra.NumeroFactura = lcl.NumeroFactura;
                            objModeloCompra.IdProducto = lcl.IdProducto;
                            objModeloCompra.Cantidad = lcl.Cantidad;
                            objModeloCompra.PrecioUnidad = lcl.PrecioUnidad;
                            objModeloCompra.MontoTotal = lcl.MontoTotal;
                            objModeloCompra.FechaRegistro = lcl.FechaRegistro;
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

        public ActionResult agregarCompra_ENT()
        {
            return View();
        }

        public ActionResult modificarCompra_ENT(int pId)
        {
            Compra lobjRespuesta = new Compra();
            modeloCompra lobjModeloCompra;
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCompraXId_ENT(pId);
                    lobjModeloCompra = new modeloCompra();
                    lobjModeloCompra.IdCompra = lobjRespuesta.IdCompra;
                    lobjModeloCompra.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloCompra.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCompra.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloCompra.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloCompra.Cantidad = lobjRespuesta.Cantidad;
                    lobjModeloCompra.PrecioUnidad = lobjRespuesta.PrecioUnidad;
                    lobjModeloCompra.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloCompra.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            return View(lobjModeloCompra);
        }

        public ActionResult eliminarCompra_ENT(int pId)
        {
            Compra lobjRespuesta = new Compra();
            modeloCompra lobjModeloCompra;
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCompraXId_ENT(pId);
                    lobjModeloCompra = new modeloCompra();
                    lobjModeloCompra.IdCompra = lobjRespuesta.IdCompra;
                    lobjModeloCompra.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloCompra.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCompra.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloCompra.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloCompra.Cantidad = lobjRespuesta.Cantidad;
                    lobjModeloCompra.PrecioUnidad = lobjRespuesta.PrecioUnidad;
                    lobjModeloCompra.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloCompra.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCompra);
        }

        public ActionResult detalleCompra_ENT(int pId)
        {
            Compra lobjRespuesta = new Compra();
            modeloCompra lobjModeloCompra;
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    lobjRespuesta = srvWCF_Cl.recCompraXId_ENT(pId);
                    lobjModeloCompra = new modeloCompra();
                    lobjModeloCompra.IdCompra = lobjRespuesta.IdCompra;
                    lobjModeloCompra.IdProveedor = lobjRespuesta.IdProveedor;
                    lobjModeloCompra.TipoDocumento = lobjRespuesta.TipoDocumento;
                    lobjModeloCompra.NumeroFactura = lobjRespuesta.NumeroFactura;
                    lobjModeloCompra.IdProducto = lobjRespuesta.IdProducto;
                    lobjModeloCompra.Cantidad = lobjRespuesta.Cantidad;
                    lobjModeloCompra.PrecioUnidad = lobjRespuesta.PrecioUnidad;
                    lobjModeloCompra.MontoTotal = lobjRespuesta.MontoTotal;
                    lobjModeloCompra.FechaRegistro = lobjRespuesta.FechaRegistro;
                }
            }
            catch (Exception lEx)
            {

                throw lEx;
            }
            return View(lobjModeloCompra);
        }

        //***************Acciones entidades**************//

        public ActionResult accionesEntidades(string enviarAccion, modeloCompra pModeloCompra)
        {
            Compra pCompra = new Compra();
            pCompra.IdCompra = pModeloCompra.IdCompra;
            pCompra.IdProveedor = pModeloCompra.IdProveedor;
            pCompra.TipoDocumento = pModeloCompra.TipoDocumento;
            pCompra.NumeroFactura = pModeloCompra.NumeroFactura;
            pCompra.IdProducto = pModeloCompra.IdProducto;
            pCompra.Cantidad = pModeloCompra.Cantidad;
            pCompra.PrecioUnidad = pModeloCompra.PrecioUnidad;
            pCompra.MontoTotal = pModeloCompra.MontoTotal;
            pCompra.FechaRegistro = pModeloCompra.FechaRegistro;

            switch (enviarAccion)
            {
                case "Agregar":
                    return insertarCl_ENT(pCompra);
                case "Modificar":
                    return modificarCl_ENT(pCompra);
                case "Eliminar":
                    return eliminarCl_ENT(pCompra);
                default:
                    return RedirectToAction("listarCompra_ENT");
            }
        }

        public ActionResult insertarCl_ENT(Compra pCompra)
        {
            List<Compra> lobjRespuesta = new List<Compra>();
            List<modeloCompra> lobjRespuestaModelo = new List<modeloCompra>();
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    if (srvWCF_Cl.insCompra_ENT(pCompra))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCompra_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCompra objModeloCompra;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCompra = new modeloCompra();
                            objModeloCompra.IdCompra = lcl.IdCompra;
                            objModeloCompra.IdProveedor = lcl.IdProveedor;
                            objModeloCompra.TipoDocumento = lcl.TipoDocumento;
                            objModeloCompra.NumeroFactura = lcl.NumeroFactura;
                            objModeloCompra.IdProducto = lcl.IdProducto;
                            objModeloCompra.Cantidad = lcl.Cantidad;
                            objModeloCompra.PrecioUnidad = lcl.PrecioUnidad;
                            objModeloCompra.MontoTotal = lcl.MontoTotal;
                            objModeloCompra.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCompra);
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
            return View("listarCompra_ENT", lobjRespuestaModelo);
        }

        public ActionResult modificarCl_ENT(Compra pCompra)
        {
            List<Compra> lobjRespuesta = new List<Compra>();
            List<modeloCompra> lobjRespuestaModelo = new List<modeloCompra>();
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    if (srvWCF_Cl.modCompra_ENT(pCompra))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCompra_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCompra objModeloCompra;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCompra = new modeloCompra();
                            objModeloCompra.IdCompra = lcl.IdCompra;
                            objModeloCompra.IdProveedor = lcl.IdProveedor;
                            objModeloCompra.TipoDocumento = lcl.TipoDocumento;
                            objModeloCompra.NumeroFactura = lcl.NumeroFactura;
                            objModeloCompra.IdProducto = lcl.IdProducto;
                            objModeloCompra.Cantidad = lcl.Cantidad;
                            objModeloCompra.PrecioUnidad = lcl.PrecioUnidad;
                            objModeloCompra.MontoTotal = lcl.MontoTotal;
                            objModeloCompra.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCompra);
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
            return View("listarCompra_ENT", lobjRespuestaModelo);
        }

        public ActionResult eliminarCl_ENT(Compra pCompra)
        {
            List<Compra> lobjRespuesta = new List<Compra>();
            List<modeloCompra> lobjRespuestaModelo = new List<modeloCompra>();
            try
            {
                using (srvCompra.IsrvCompraClient srvWCF_Cl = new srvCompra.IsrvCompraClient())
                {
                    if (srvWCF_Cl.delCompra_ENT(pCompra))
                    {
                        //enviar mensaje positivo
                    }
                    else
                    {
                        //enviar mensaje negativo
                    }
                    lobjRespuesta = srvWCF_Cl.recCompra_ENT();
                    if (lobjRespuesta.Count > 0)
                    {
                        modeloCompra objModeloCompra;
                        foreach (var lcl in lobjRespuesta)
                        {
                            objModeloCompra = new modeloCompra();
                            objModeloCompra.IdCompra = lcl.IdCompra;
                            objModeloCompra.IdProveedor = lcl.IdProveedor;
                            objModeloCompra.TipoDocumento = lcl.TipoDocumento;
                            objModeloCompra.NumeroFactura = lcl.NumeroFactura;
                            objModeloCompra.IdProducto = lcl.IdProducto;
                            objModeloCompra.Cantidad = lcl.Cantidad;
                            objModeloCompra.PrecioUnidad = lcl.PrecioUnidad;
                            objModeloCompra.MontoTotal = lcl.MontoTotal;
                            objModeloCompra.FechaRegistro = lcl.FechaRegistro;
                            lobjRespuestaModelo.Add(objModeloCompra);
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
            return View("listarCompra_ENT", lobjRespuestaModelo);
        }
    }
}