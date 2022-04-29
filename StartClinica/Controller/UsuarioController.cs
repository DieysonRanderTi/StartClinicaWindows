using Microsoft.EntityFrameworkCore;
using StartClinica.Data;
using StartClinica.Model;
using System.Collections.Generic;
using System.Linq;

namespace StartClinica.Controller
{
    public static class UsuarioController
    {
        public static Context context;
        static UsuarioController()
        {
            context = new Context();
        }
        public static void InsertUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            context.Entry(usuario).State = usuario.Id > 0 ? EntityState.Modified : EntityState.Added;
            context.SaveChanges();
        }
        public static Usuario GetUsuario(int id)
        {
            return context.Usuarios.Where(x => x.Id == id).FirstOrDefault();
        }
        public static List<Usuario> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }
        public static void DeleteUsuario(int id)
        {
            Usuario usuario = GetUsuario(id);
            context.RemoveRange(usuario);
            context.SaveChanges();
        }
        public static Usuario GetUsuarioByName(string name)
        {
            return context.Usuarios.Where(x => x.Nome == name).FirstOrDefault();
        }
        public static Usuario UsuarioPadrao()
        {
            return new Usuario()
            {
                Nome = "Administrador",
                Login = "admin123456",
                Senha = "123456",
                EhAdministrador = true
            };
        }
    }
}
