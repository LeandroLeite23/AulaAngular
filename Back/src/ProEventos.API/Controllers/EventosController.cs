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
    public class EventosController : ControllerBase
    {
        private readonly IEventoRepository _eventoRepository;

        public EventosController(IEventoRepository eventoRepository)
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
            return _eventoRepository.AddEvento(evento);
        }

        [HttpPut]
        public Evento Put(Evento evento)
        {
            return _eventoRepository.EditEvento(evento);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _eventoRepository.DeleteEvento(id);
        }
    }
}