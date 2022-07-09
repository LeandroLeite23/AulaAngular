using System.Collections.Generic;
using ProEventos.API.Models;

namespace ProEventos.API.Data.Interfaces
{
    public interface IEventoRepository
    {
        Evento AddEvento(Evento evento);
        void DeleteEvento(int id);
        IEnumerable<Evento> GetAllEventos();
        Evento GetById(int id);
    }
}