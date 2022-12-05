using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEvento.Persistence;
using ProEvento.Domain;
using ProEvento.Persistence.Contextos;

namespace ProEvento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EventosController : ControllerBase
    {
        private readonly ProEventoContext _context;

        public EventosController(ProEventoContext context)
        {
            _context = context;

        }

        [HttpGet]

        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

        [HttpGet("{id}")]

        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(evento => evento.Id == id);
        }


        [HttpPost]

        public string Post()
        {
            return "Exemlo de Post";
        }

        [HttpPut("{id}")]

        public string Put(int id)
        {
            return $"Exemlo de Put com id = {id}";
        }


        [HttpPost("{id}")]

        public string Post(int id)
        {
            return $"Exemlo de Put com id = {id}";
        }

        [HttpDelete("{id}")]

        public string Delete(int id)
        {
            return $"Exemlo de Delete com id = {id}";
        }

    }
}

