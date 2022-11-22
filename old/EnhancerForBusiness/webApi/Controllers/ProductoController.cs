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
    public class ProductoController : ApiController
    {
        private readonly IProductoLN gobjProductoLN = new ProductoLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Producto> recProducto_ENT()
        {
            List<Producto> lObjRespuesta = new List<Producto>();
            try
            {
                lObjRespuesta = gobjProductoLN.recProducto_ENT();
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
        public Producto recProductoXId_ENT(int pId)
        {
            Producto lObjRespuesta = new Producto();
            try
            {
                lObjRespuesta = gobjProductoLN.recProductoXId_ENT(pId);
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
        public IHttpActionResult insProducto([FromBody] Producto pProducto)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProductoLN.insProducto_ENT(pProducto);
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
                return Ok(pProducto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modProducto([FromBody] Producto pProducto)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProductoLN.modProducto_ENT(pProducto);
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
                return Ok(pProducto);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delProducto([FromBody] Producto pProducto)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProductoLN.delProducto_ENT(pProducto);
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
                return Ok(pProducto);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
