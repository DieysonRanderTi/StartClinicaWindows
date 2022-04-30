using Microsoft.EntityFrameworkCore;
using StartClinica.Data;
using StartClinica.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StartClinica.Controller
{
    public static class EventoController
    {
        public static Context context;
        static EventoController()
        {
            context = new Context();
        }
        public static void InsertEvento(Evento Evento)
        {
            context.Eventos.Add(Evento);
            context.Entry(Evento).State = Evento.Id > 0 ? EntityState.Modified : EntityState.Added;
            context.SaveChanges();
        }
        public static Evento GetEvento(int id)
        {
            return context.Eventos.Where(x => x.Id == id).FirstOrDefault();
        }
        public static IEnumerable<Evento> GetAllEventos()
        {
            return context.Eventos.Where(x => x.Id > 0)
                .Include(x => x.Cliente)
                .Include(x => x.Usuario).ToList();
        }
        public static void DeleteEvento(int id)
        {
            var Evento = GetEvento(id);
            context.RemoveRange(Evento);
            context.SaveChanges();
        }
    }
}
