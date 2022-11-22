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
    public class CategoriaController : ApiController
    {
        private readonly ICategoriaLN gobjCategoriaLN = new CategoriaLN();
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        //****************ENTIDADES************//

        [HttpGet]
        public List<Categoria> recCategoria_ENT()
        {
            List<Categoria> lObjRespuesta = new List<Categoria>();
            try
            {
                lObjRespuesta = gobjCategoriaLN.recCategoria_ENT();
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
        public Categoria recCategoriaXId_ENT(int pId)
        {
            Categoria lObjRespuesta = new Categoria();
            try
            {
                lObjRespuesta = gobjCategoriaLN.recCategoriaXId_ENT(pId);
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
        public IHttpActionResult insCategoria([FromBody] Categoria pCategoria)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCategoriaLN.insCategoria_ENT(pCategoria);
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
                return Ok(pCategoria);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IHttpActionResult modCategoria([FromBody] Categoria pCategoria)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCategoriaLN.modCategoria_ENT(pCategoria);
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
                return Ok(pCategoria);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        public IHttpActionResult delCategoria([FromBody] Categoria pCategoria)
        {
            bool lEstado = false;
            try
            {
                if (ModelState.IsValid)
                {
                    gobjCategoriaLN.delCategoria_ENT(pCategoria);
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
                return Ok(pCategoria);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
