using System.Collections.Generic;
using System.Linq;
using ProEventos.API.Data.Interfaces;
using ProEventos.API.Models;

namespace ProEventos.API.Data
{
    public class EventoRepository : IEventoRepository
    {
        private readonly DataContext _context;

        public EventoRepository(DataContext context)
        {
            _context = context;
        }

        public Evento AddEvento(Evento evento)
        {
            _context.Add(evento);
            _context.SaveChanges();

            return evento;
        }

        public void DeleteEvento(int id)
        {
            var registro = _context.Eventos.SingleOrDefault(e => e.EventoId == id);

            if(registro != null){
                _context.Remove(registro);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Evento> GetAllEventos()
        {
            return _context.Eventos;
        }

        public Evento GetById(int id)
        {
            return _context.Eventos.SingleOrDefault(e => e.EventoId == id);
        }
    }
}