using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento(){
                EventoId = 1,
                Local = "Touros",
                DataEvento = DateTime.Now.AddDays(15).ToString(),
                Tema = "Semana de Arte do Descobrimento",
                QtdPessoas = 100,
                Lote = 001,
                ImagemURL = "http://img.com/0frt56.jpg",
            },

            new Evento(){
                EventoId = 2,
                Local = "São Miguel",
                DataEvento = DateTime.Now.AddDays(30).ToString(),
                Tema = "Semana de Esportes Aguáticos",
                QtdPessoas = 150,
                Lote = 002,
                ImagemURL = "http://img.com/yt67uj.jpg",
            },
        };

        public EventosController() { }
        
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

    }
}
