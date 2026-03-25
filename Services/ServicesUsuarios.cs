using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebEjem.Data;
using WebEjem.Models;

namespace WebEjem.Services
{
    public class ServicesUsuarios
    {
        ejemploDbEntities conexion = null;

    

    public ServicesUsuarios()
        {
            conexion = new ejemploDbEntities();
        }

        /*
        public bool CreateUsuario(webExamen.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();

            try
            {
                if (usuario != null)
                {

                    conexion.usuarios.Add(usuario);
                   
                    conexion.SaveChanges();
                    transaccion.Commit();
                }
                return result = true;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }
        }

        */
        public bool Crear(WebEjem.Data.usuarios usuarios)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                if (usuarios != null)
                {
                    conexion.usuarios.Add(usuarios);
                    foreach (var u in usuarios.usuarioRoles)
                    {
                        conexion.usuarioRoles.Add(u);
                    }
                    conexion.SaveChanges();
                    transaccion.Commit();
                    result = true;
                }
                return result;

            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }
        }
        /*
        public bool deleteUsuario(int id)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                webExamen.Data.usuarios user = conexion.usuarios.First(p => p.idUser == id);
                if (user != null)
                {
                    conexion.usuarios.Remove(user);
                    conexion.SaveChanges();
                    transaccion.Commit();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }

        }


        public bool SuspenderCuenta(webExamen.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                webExamen.Data.usuarios user = conexion.usuarios.First(p => p.idUser == usuario.idUser);
                if (user != null)
                {
                    user.suspendido = true;
                    conexion.SaveChanges();
                    transaccion.Commit();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }
        }
        public bool ValidarLogin(webExamen.Data.usuarios usuario)
        {
            bool result = false;
            try
            {
                webExamen.Data.usuarios user = conexion.usuarios.First(p => p.username.Equals(usuario.username)
                    && p.password.Equals(usuario.password) && p.suspendido == false);
                if (user != null)
                {
                    result = true;
                }

                return result;
            }
            catch (Exception ex)
            {
                return result;
            }

        }
        */
        public WebEjem.Data.usuarios Login(Usuarios usuario)
        {
            try
            {
                WebEjem.Data.usuarios user = conexion.usuarios.First(p => p.username.Equals(usuario.username)
                    && p.password.Equals(usuario.password) && p.suspendido == false);

                if (user != null)
                {
                    return user;
                }
                else
                {
                    WebEjem.Data.usuarios usuarioNull = new WebEjem.Data.usuarios { username = string.Empty, idUser = 0 };
                    return usuarioNull;
                }
            }
            catch (Exception ex)
            {

                WebEjem.Data.usuarios usuarioNull = new WebEjem.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuarioNull;
            }
        }

        public bool ValidarSuspension(WebEjem.Data.usuarios usuario)
        {
            bool result = false;
            try
            {
                return result = conexion.usuarios.Any(
                    p => p.username.Equals(usuario.username)
                    && p.password.Equals(usuario.password)
                    && p.suspendido == false);
            }
            catch (Exception ex)
            {
                return result;
            }
        }


        public bool ActivarSuspencion(WebEjem.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                WebEjem.Data.usuarios user = conexion.usuarios.First(p => p.idUser == usuario.idUser);
                if (user != null)
                {
                    user.suspendido = false;
                    conexion.SaveChanges();
                    transaccion.Commit();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }

        }
        public WebEjem.Data.usuarios GetUsuario(WebEjem.Data.usuarios usuarios)
        {
            try
            {
                return conexion.usuarios
                    .Where(p => p.username == usuarios.username.Trim() && p.password.Equals(usuarios.password.Trim()))
                    .First();
            }
            catch (Exception ex)
            {
                WebEjem.Data.usuarios usuario = new WebEjem.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuario;
            }
        }

        public bool EditarUsuario(WebEjem.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {

                if (usuario == null || usuario.idUser <= 0)
                {
                    return result;
                }
                WebEjem.Data.usuarios user = conexion.usuarios.FirstOrDefault(p => p.idUser == usuario.idUser);
                if (user == null)
                {
                    return result;
                }
                user.username = usuario.username.ToLower().Trim();
                user.password = usuario.password.ToLower().Trim();
                conexion.SaveChanges();
                transaccion.Commit();
                result = true;
                return result;
            }
            catch (Exception ex)
            {
                transaccion.Rollback();
                return result;
            }
        }

        public List<WebEjem.Data.usuarios> GetAllUsuarios()
        {
            try
            {
                return conexion.usuarios.OrderBy(p => p.username).ToList();
            }
            catch (Exception ex)
            {
                return new List<WebEjem.Data.usuarios>();
            }


        }


        public List<WebEjem.Data.usuarios> GetSuspendidosSp()
        {
            try
            {
                return conexion.usuarios
                    .SqlQuery("EXEC dbo.sp.GetSuspendidos")
                    .AsNoTracking()
                    .ToList();
            }
            catch (Exception ex)
            {
                return new List<WebEjem.Data.usuarios>();
            }
        }
        /*este metodo se encarga de consultar al usuario utilizando la clausula like de sql */
        public WebEjem.Data.usuarios GetUsuarioByName(string username)
        {
            try
            {
                return conexion.usuarios.Where(p => p.username.StartsWith(username) && p.suspendido == false).FirstOrDefault();
            }
            catch (Exception ex)
            {
                WebEjem.Data.usuarios usuario = new WebEjem.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuario;
            }
        }

        public int GetIdMax()
        {
            try
            {
                return conexion.usuarios.Max(p => p.idUser);
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public int GetIdMin()
        {
            try
            {
                return conexion.usuarios.Min(p => p.idUser);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        //es igual al de get usuarios by name pero este devuelve una lista de usuarios que cumplen con la condicion de like
        public List<WebEjem.Data.usuarios> GetUsuariosByLike(string letra)
        {
            var query = from u in conexion.usuarios
                        where u.username.StartsWith(letra) && u.suspendido == false
                        select u;
            return query.ToList();
        }

        public void GetSumAll(string letra)
        {
            var query = from u in conexion.usuarios
                        where u.suspendido == false && u.username.StartsWith(letra)
                        select u.idUser;

            int suma = query.Sum();

            //oriendtado a objetos

            var query2 = conexion.usuarios
                .Where(p => p.suspendido == false && p.username.StartsWith(letra))
                .Select(p => p.idUser).Sum();
        }

        public double GetAlgo()
        {
            //conexion.usuarios.Where(p => p.suspendido == false).ToList();

            //conexion.usuarios.ToList();

            //promedio
            var query = (from u in conexion.usuarios
                         where u.username.StartsWith("a") && u.suspendido == false
                         select u).Average(p => p.idUser);
            double result = double.Parse(query.ToString());
            return result;

            /*where u.suspendido == true
            orderby u ascending
            select new { Nombre = u.username, Status = u.suspendido};

var result = query.GroupBy(p => p.Nombre).ToList();
List<UsuarioSimple> user = new List<UsuarioSimple>();
foreach (var item in result)
{
    UsuarioSimple usuario = new UsuarioSimple();
    usuario.Nombre = item.Key;
}
            */
        }

        
        public List<UsuarioConRoles> GetUsuariosRoles()
        {
            try
            {
                var consulta = from u in conexion.usuarios
                               join ur in conexion.usuarioRoles
                               on u.idUser equals ur.idUser
                               join r in conexion.roles
                               on ur.idRoles equals r.idRoles
                               select new UsuarioConRoles
                               {
                                   IdUsuario = u.idUser,
                                   Nombre = u.username.Trim().ToLower(),
                                   IdRol = r.idRoles,
                                   NombreRol = r.strValor.Trim().ToLower(),
                                   Descripcion = r.strDescripcion.Trim().ToLower(),
                               };


                return consulta.ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}