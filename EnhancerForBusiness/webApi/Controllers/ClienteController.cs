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
    public class ClienteController : ApiController
    {
        private readonly IClienteLN gobjClienteLN = new ClienteLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Cliente> recCliente_ENT()
        {
            List<Cliente> lObjRespuesta = new List<Cliente>();
            try
            {
                lObjRespuesta = gobjClienteLN.recCliente_ENT();
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
        public Cliente recClienteXId_ENT(int pId)
        {
            Cliente lObjRespuesta = new Cliente();
            try
            {
                lObjRespuesta = gobjClienteLN.recClienteXId_ENT(pId);
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
        public IHttpActionResult insCliente([FromBody] Cliente pCliente)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClienteLN.insCliente_ENT(pCliente);
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
                return Ok(pCliente);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modCliente([FromBody] Cliente pCliente)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClienteLN.modCliente_ENT(pCliente);
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
                return Ok(pCliente);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delCliente([FromBody] Cliente pCliente)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjClienteLN.delCliente_ENT(pCliente);
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
                return Ok(pCliente);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
