using Entidades;
using LogicaNegocio.Implementacion;
using LogicaNegocio.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class VentaController : ApiController
    {
        private readonly IVentaLN gobjVentaLN = new VentaLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Venta> recVenta_ENT()
        {
            List<Venta> lObjRespuesta = new List<Venta>();
            try
            {
                lObjRespuesta = gobjVentaLN.recVenta_ENT();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        [HttpGet]
        public Venta recVentaXId_ENT(int pId)
        {
            Venta lObjRespuesta = new Venta();
            try
            {
                lObjRespuesta = gobjVentaLN.recVentaXId_ENT(pId);
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            return lObjRespuesta;
        }

        [HttpPost]
        public IHttpActionResult insVenta([FromBody] Venta pVenta)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjVentaLN.insVenta_ENT(pVenta);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pVenta);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modVenta([FromBody] Venta pVenta)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjVentaLN.modVenta_ENT(pVenta);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pVenta);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delVenta([FromBody] Venta pVenta)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjVentaLN.delVenta_ENT(pVenta);
                    lEstado = true;
                }
                else
                {
                    lEstado = false;
                }
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                    " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            if (lEstado)
            {
                return Ok(pVenta);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
