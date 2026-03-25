using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEjem.Data;

namespace WebEjem.Services
{
    public class ServicesRoles
    {
        ejemploDbEntities conexion = null;
      public ServicesRoles()
        {
            conexion = new ejemploDbEntities();
        }


        public bool Create(roles roles)
        {
            bool result = false;
            var transaction = conexion.Database.BeginTransaction();
            try
            {
                conexion.roles.Add(roles);
                conexion.SaveChanges();
                transaction.Commit();
                result = true;
                return result;
            }

            catch (Exception ex)
            {
                transaction.Rollback();
                result = false;
                return result;
            }
        }

        //metodo que se encarga de devolver kis rolesque hay en la base de datos
        //devolviendolos como una lista

        public List<roles> GetRoles()
        {
            return conexion.roles.ToList();
        }

        //otra manera

        public List<roles> GetTodosRoles()
        {
            //se crea una lista
            List<roles> listaRoles = new List<roles>();
            //la consulta que trae todos los roles ordenados
            var query = from r in conexion.roles
                        orderby r.strValor descending
                        select r;
            //se agregan a la lista ordenada
            foreach (var item in query)
            {
                listaRoles.Add(item);
            }
            //se regresa la lista ordenada
            return listaRoles;
        }
    }
}