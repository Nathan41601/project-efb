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
    public class ProveedorAD : IProveedorAD
    {
        private CMEntidades gObjConexionCM;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public ProveedorAD(CMEntidades lObjConexionCM)
        {
            gObjConexionCM = lObjConexionCM;
        }

        //**************ENTIDADES**************//
        public List<Proveedor> recProveedor_ENT()
        {
            List<Proveedor> lobjRespuesta = new List<Proveedor>();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Proveedor.ToList();
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

        public Proveedor recProveedorXId_ENT(int pId)
        {
            Proveedor lobjRespuesta = new Proveedor();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Proveedor.ToList().Find(cr => cr.IdProveedor == pId);
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

        public bool insProveedor_ENT(Proveedor pProveedor)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Proveedor.Find(pProveedor.IdProveedor);
                if (regEncontrado == null)
                {
                    gObjConexionCM.Proveedor.Add(pProveedor);
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

        public bool modProveedor_ENT(Proveedor pProveedor)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Proveedor.Find(pProveedor.IdProveedor);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pProveedor);
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

        public bool delProveedor_ENT(Proveedor pProveedor)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Proveedor.Find(pProveedor.IdProveedor);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pProveedor);
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
