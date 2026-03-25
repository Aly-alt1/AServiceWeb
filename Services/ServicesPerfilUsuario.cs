using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEjem.Data;

namespace WebEjem.Services
{
    public class ServicesPerfilUsuario
    {
        ejemploDbEntities conexion = null;
        public ServicesPerfilUsuario()
        {
            conexion = new ejemploDbEntities();
        }
        public bool CrearPerfil(Data.perfilUsuario x)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();

            try
            {
                this.conexion.perfilUsuario.Add(x);
                this.conexion.SaveChanges();
                transaccion.Commit();
                result = true;
                return result;
            }
            catch (Exception ex) {
                transaccion.Rollback();
                return result;
            }
        }
    }
}