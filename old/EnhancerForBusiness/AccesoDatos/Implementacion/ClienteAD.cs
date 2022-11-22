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
    public class ClienteAD : IClienteAD
    {
        private CMEntidades gObjConexionCM;
        private readonly Logger gObjError = LogManager.GetCurrentClassLogger();

        public ClienteAD(CMEntidades lObjConexionCM)
        {
            gObjConexionCM = lObjConexionCM;
        }

        //**************ENTIDADES**************//
        public List<Cliente> recCliente_ENT()
        {
            List<Cliente> lobjRespuesta = new List<Cliente>();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Cliente.ToList();
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

        public Cliente recClienteXId_ENT(int pId)
        {
            Cliente lobjRespuesta = new Cliente();
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                lobjRespuesta = gObjConexionCM.Cliente.ToList().Find(cr => cr.IdCliente == pId);
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

        public bool insCliente_ENT(Cliente pCliente)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Cliente.Find(pCliente.IdCliente);
                if (regEncontrado == null)
                {
                    gObjConexionCM.Cliente.Add(pCliente);
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

        public bool modCliente_ENT(Cliente pCliente)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Cliente.Find(pCliente.IdCliente);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCliente);
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

        public bool delCliente_ENT(Cliente pCliente)
        {
            bool lobjRespuesta = false;
            try
            {
                gObjConexionCM.Configuration.ProxyCreationEnabled = false;
                var regEncontrado = gObjConexionCM.Cliente.Find(pCliente.IdCliente);
                if (regEncontrado != null)
                {
                    gObjConexionCM.Entry(regEncontrado).CurrentValues.SetValues(pCliente);
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
