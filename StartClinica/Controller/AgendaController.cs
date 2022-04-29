using Microsoft.EntityFrameworkCore;
using StartClinica.Data;
using StartClinica.Model;
using System.Collections.Generic;
using System.Linq;

namespace StartClinica.Controller
{
    public static class AgendaController
    {
        public static Context context;
        static AgendaController()
        {
            context = new Context();
        }
        public static void InsertAgenda(Agenda agenda)
        {
            context.Agendas.Add(agenda);
            context.Entry(agenda).State = agenda.Id > 0 ? EntityState.Modified : EntityState.Added;
            context.SaveChanges();
        }
        public static Agenda GetAgenda(int id)
        {
            return context.Agendas.Where(x => x.Id == id).FirstOrDefault();
        }
        public static List<Agenda> GetAgendas()
        {
            return context.Agendas.Where(x => x.Id > 0)
                .Include(x => x.Cliente)
                .Include(x => x.Usuario).ToList();
        }
        public static void DeleteAgenda(int id)
        {
            var agenda = GetAgenda(id);
            context.RemoveRange(agenda);
            context.SaveChanges();
        }
    }
}
