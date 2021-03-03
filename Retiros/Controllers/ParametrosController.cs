using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retiros.Contexts;
using Retiros.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retiros.Controllers
{

    [Route("api/[controller]")]
    public class ParametrosController : Controller
    {
        private AppDbContext context;

        public ParametrosController(AppDbContext context)
        {
            this.context = context;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Parametros> Get()
        {
            return context.parametros.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Parametros Get(int id)
        {
            var parametros = context.parametros.FirstOrDefault(p => p.IdParametros == id);
            return parametros;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Parametros parametros)
        {
            try
            {
                context.parametros.Add(parametros);
                context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]Parametros parametros)
        {
            try
            {
                context.Entry(parametros).State = EntityState.Modified;
                context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var parametros = context.parametros.FirstOrDefault(p => p.IdParametros == id);
                if (parametros != null)
                {
                    context.parametros.Remove(parametros);
                    context.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
