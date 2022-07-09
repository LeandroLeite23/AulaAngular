using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data.Interfaces;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;

        public EventoController(IEventoRepository eventoRepository)
        {
            _eventoRepository = eventoRepository;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _eventoRepository.GetAllEventos();
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _eventoRepository.GetById(id);
           
        }

        [HttpPost]
        public Evento Post(Evento evento)
        {
            _eventoRepository.AddEvento(evento);
            return evento;
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id: {id}";
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _eventoRepository.DeleteEvento(id);
        }
    }
}