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
    public class ProveedorController : ApiController
    {
        private readonly IProveedorLN gobjProveedorLN = new ProveedorLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Proveedor> recProveedor_ENT()
        {
            List<Proveedor> lObjRespuesta = new List<Proveedor>();
            try
            {
                lObjRespuesta = gobjProveedorLN.recProveedor_ENT();
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
        public Proveedor recProveedorXId_ENT(int pId)
        {
            Proveedor lObjRespuesta = new Proveedor();
            try
            {
                lObjRespuesta = gobjProveedorLN.recProveedorXId_ENT(pId);
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
        public IHttpActionResult insProveedor([FromBody] Proveedor pProveedor)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProveedorLN.insProveedor_ENT(pProveedor);
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
                return Ok(pProveedor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modProveedor([FromBody] Proveedor pProveedor)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProveedorLN.modProveedor_ENT(pProveedor);
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
                return Ok(pProveedor);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delProveedor([FromBody] Proveedor pProveedor)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjProveedorLN.delProveedor_ENT(pProveedor);
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
                return Ok(pProveedor);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
