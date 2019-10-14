using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventzy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventzy.Controllers
{
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public EventController(ApplicationContext context)
        {
            _context = context;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Event Get(int id)
        {
            var item = _context.Events.Find(id);
            return item;
        }

        //POST api/values
        [HttpPost]
        public void PostEvent([FromBody]Event value)
        {
            _context.Events.Add(value);
            _context.SaveChanges();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.Events.Find(id);

            _context.Events.Remove(item);
            _context.SaveChanges();
        }
    }
}
