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
    public class CompraAD : ICompraAD
    {
        private CMEntidades gObjConexionCM;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public CompraAD(CMEntidades lObjConexionCM)
        {
            gObjConexionCM = lObjConexionCM;
        }

        //**************ENTIDADES**************//
        public List<Compra> recCompra_ENT()
        {
            List<Compra> lobjRespuesta = new List<Compra>();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Compra.ToList();
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

        public Compra recCompraXId_ENT(int pId)
        {
            Compra lobjRespuesta = new Compra();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Compra.ToList().Find(cr => cr.IdCompra == pId);
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

        public bool insCompra_ENT(Compra pCompra)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Compra.Find(pCompra.IdCompra);
                if (regEncontrado == null)
                {
                    gObjConexionCM.Compra.Add(pCompra);
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

        public bool modCompra_ENT(Compra pCompra)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Compra.Find(pCompra.IdCompra);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCompra);
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

        public bool delCompra_ENT(Compra pCompra)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Compra.Find(pCompra.IdCompra);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCompra);
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