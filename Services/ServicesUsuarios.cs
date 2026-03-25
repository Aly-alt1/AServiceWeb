using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webExamen.Data;
using webExamen.Models;
using usuarios = webExamen.Data.usuarios;

namespace webExamen.Services
{
    public class ServicesUsuarios
    {
        productosDbEntities conexion = null;
        public ServicesUsuarios()
        {
            conexion = new productosDbEntities();
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
        public bool Crear(webExamen.Data.usuarios usuarios)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                if (usuarios != null)
                {
                    conexion.usuarios.Add(usuarios);
                    foreach (var u in usuarios.UsuarioRoles)
                    {
                        conexion.UsuarioRoles.Add(u);
                    }
                    conexion.SaveChanges();
                    transaccion.Commit();
                    result = true;
                }
                return result;

            }
            catch(Exception ex)
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
        public webExamen.Data.usuarios Login(Usuarios usuario)
        {
            try
            {
                webExamen.Data.usuarios user = conexion.usuarios.First(p => p.username.Equals(usuario.username)
                    && p.password.Equals(usuario.password) && p.suspendido == false);

                if (user != null)
                {
                    return user;
                }
                else
                {
                    webExamen.Data.usuarios usuarioNull = new webExamen.Data.usuarios { username = string.Empty, idUser = 0 };
                    return usuarioNull;
                }
            }
            catch (Exception ex)
            {

                webExamen.Data.usuarios usuarioNull = new webExamen.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuarioNull;
            }
        }

        public bool ValidarSuspension(webExamen.Data.usuarios usuario)
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


        public bool ActivarSuspencion(webExamen.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {
                webExamen.Data.usuarios user = conexion.usuarios.First(p => p.idUser == usuario.idUser);
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
        public webExamen.Data.usuarios GetUsuario(webExamen.Data.usuarios usuarios)
        {
            try
            {
                return conexion.usuarios
                    .Where(p => p.username == usuarios.username.Trim() && p.password.Equals(usuarios.password.Trim()))
                    .First();
            }
            catch (Exception ex)
            {
                webExamen.Data.usuarios usuario = new webExamen.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuario;
            }
        }

        public bool EditarUsuario(webExamen.Data.usuarios usuario)
        {
            bool result = false;
            var transaccion = conexion.Database.BeginTransaction();
            try
            {

                if (usuario == null || usuario.idUser <= 0)
                {
                    return result;
                }
                webExamen.Data.usuarios user = conexion.usuarios.FirstOrDefault(p => p.idUser == usuario.idUser);
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

        public List<webExamen.Data.usuarios> GetAllUsuarios()
        {
            try
            {
                return conexion.usuarios.OrderBy(p => p.username).ToList();
            }
            catch (Exception ex)
            {
                return new List<webExamen.Data.usuarios>();
            }

            
        }

      
        public List<webExamen.Data.usuarios> GetSuspendidosSp()
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
                return new List<webExamen.Data.usuarios>();
            }
        }
        /*este metodo se encarga de consultar al usuario utilizando la clausula like de sql */
        public webExamen.Data.usuarios GetUsuarioByName(string username)
        {
            try
            {
                return conexion.usuarios.Where(p => p.username.StartsWith(username) && p.suspendido==false).FirstOrDefault();
            }
            catch (Exception ex)
            {
                webExamen.Data.usuarios usuario = new webExamen.Data.usuarios { username = string.Empty, idUser = 0 };
                return usuario;
            }
        }

        public int GetIdMax()
        {
            try
            {
                return conexion.usuarios.Max(p => p.idUser);
            }
            catch(Exception ex)
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
        public List <webExamen.Data.usuarios> GetUsuariosByLike(string letra)
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
                        select u).Average(p=> p.idUser);
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


        public List<UsuarioConRoles> GetUsuarioRoles()
        {
            try
            {
                var consulta = from u in conexion.usuarios
                               join ur in conexion.UsuarioRoles
                               on u.idUser equals ur.idUser
                               join r in conexion.roles
                               on ur.idRoles equals r.idRoles
                               select new
                               {
                                   idUsuario = u.idUser,
                                   nombre = u.username.Trim().ToLower(),
                                   idRol = r.idRoles,
                                   nombreRol = r.strValor.Trim().ToLower(),
                                   descripcion = r.strDescripcion.Trim().ToLower(),
                               };
                return consulta.ToList();
            }
            catch(Exception ex)
            {

            }
        }

       
    }
}