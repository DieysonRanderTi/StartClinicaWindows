using Microsoft.EntityFrameworkCore;
using StartClinica.Data;
using StartClinica.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StartClinica.Controller
{
    public static class ClienteController
    {
        public static Context context;
        static ClienteController()
        {
            context = new Context();
        }
        public static void InsertCliente(Cliente cliente)
        {
            context.Clientes.Add(cliente);
            context.Entry(cliente).State = cliente.Id > 0 ? EntityState.Modified : EntityState.Added;
            context.SaveChanges();
        }
        public static Cliente GetCliente(int id)
        {
            return context.Clientes.Where(x => x.Id == id).FirstOrDefault();
        }
        public static Cliente GetClienteByName(string name)
        {
            return context.Clientes.Where(x => x.Nome == name).FirstOrDefault();
        }
        public static List<Cliente> GetClientesAtivos()
        {
            return context.Clientes.Where(x => x.Ativo).ToList();
        }
        public static List<Cliente> GetClientesAniversariantes(int id)
        {
            return context.Clientes.Where(x => x.DataNascimento.ToString("dd/MM") == DateTime.Now.ToString("dd/MM")).ToList();
        }
        public static List<Cliente> GetClientes()
        {
            return context.Clientes.ToList();
        }
        public static void DeleteCliente(int id)
        {
            Cliente cliente = GetCliente(id);
            context.RemoveRange(cliente);
            context.SaveChanges();
        }
    }
}
