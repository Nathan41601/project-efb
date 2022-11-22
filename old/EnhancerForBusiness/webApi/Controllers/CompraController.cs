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
    public class CompraController : ApiController
    {
        private readonly ICompraLN gobjCompraLN = new CompraLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Compra> recCompra_ENT()
        {
            List<Compra> lObjRespuesta = new List<Compra>();
            try
            {
                lObjRespuesta = gobjCompraLN.recCompra_ENT();
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
        public Compra recCompraXId_ENT(int pId)
        {
            Compra lObjRespuesta = new Compra();
            try
            {
                lObjRespuesta = gobjCompraLN.recCompraXId_ENT(pId);
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
        public IHttpActionResult insCompra([FromBody] Compra pCompra)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCompraLN.insCompra_ENT(pCompra);
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
                return Ok(pCompra);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modCompra([FromBody] Compra pCompra)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCompraLN.modCompra_ENT(pCompra);
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
                return Ok(pCompra);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delCompra([FromBody] Compra pCompra)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCompraLN.delCompra_ENT(pCompra);
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
                return Ok(pCompra);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
