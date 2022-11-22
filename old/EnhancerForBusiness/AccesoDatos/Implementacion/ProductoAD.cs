using AccesoDatos.Interfaces;
using Entidades;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Implementacion
{
    public class ProductoAD : IProductoAD
    {
        private CMEntidades gObjConexionCM;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public ProductoAD(CMEntidades lObjConexionCM)
        {
            gObjConexionCM = lObjConexionCM;
        }

        //**************ENTIDADES**************//
        public List<Producto> recProducto_ENT()
        {
            List<Producto> lobjRespuesta = new List<Producto>();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Producto.ToList();
            }
            catch (Exception lEx)
            {
                //throw lEx;
                gObjError.Error("Se produjo un error. Detalle: " + lEx.Message + " " + lEx.InnerException.Message +
                " . Ubicación: " + System.Reflection.MethodInfo.GetCurrentMethod().ToString());
            }
            finally
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public Producto recProductoXId_ENT(int pId)
        {
            Producto lobjRespuesta = new Producto();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Producto.ToList().Find(cr => cr.IdProducto == pId);
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool insProducto_ENT(Producto pProducto)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Producto.Find(pProducto.IdProducto);
                if (regEncontrado == null)
                {
                    gObjConexionCM.Producto.Add(pProducto);
                    gObjConexionCM.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool modProducto_ENT(Producto pProducto)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Producto.Find(pProducto.IdProducto);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pProducto);
                    gObjConexionCM.Entry(regEncontrado).State = System.Data.Entity.EntityState.Modified;
                    gObjConexionCM.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;
        }

        public bool delProducto_ENT(Producto pProducto)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Producto.Find(pProducto.IdProducto);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pProducto);
                    gObjConexionCM.Entry(regEncontrado).State = System.Data.Entity.EntityState.Deleted;
                    gObjConexionCM.SaveChanges();
                    lobjRespuesta = true;
                }
            }
            catch (Exception lEx)
            {
                throw lEx;
            }
            finally
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = true;
            }
            return lobjRespuesta;

        }
    }
}