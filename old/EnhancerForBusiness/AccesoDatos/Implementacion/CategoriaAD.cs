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
    public class CategoriaAD : ICategoriaAD
    {
        private CMEntidades gObjConexionCM;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public CategoriaAD(CMEntidades lObjConexionCM)
        {
            gObjConexionCM = lObjConexionCM;
        }


        //**************ENTIDADES**************//
        public List<Categoria> recCategoria_ENT()
        {
            List<Categoria> lobjRespuesta = new List<Categoria>();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Categoria.ToList();
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

        public Categoria recCategoriaXId_ENT(int pId)
        {
            Categoria lobjRespuesta = new Categoria();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Categoria.ToList().Find(cr => cr.IdCategoria == pId);
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

        public bool insCategoria_ENT(Categoria pCategoria)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Categoria.Find(pCategoria.IdCategoria);
                if (regEncontrado == null)
                {
                    gObjConexionCM.Categoria.Add(pCategoria);
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

        public bool modCategoria_ENT(Categoria pCategoria)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Categoria.Find(pCategoria.IdCategoria);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCategoria);
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

        public bool delCategoria_ENT(Categoria pCategoria)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Categoria.Find(pCategoria.IdCategoria);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCategoria);
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
