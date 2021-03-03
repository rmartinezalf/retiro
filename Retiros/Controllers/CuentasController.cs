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
    public class CuentasController : Controller
    {
        private AppDbContext context;

        public CuentasController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Cuentas> Get()
        {
            return context.cuentas.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Cuentas Get(int id)
        {
            var cuentas = context.cuentas.FirstOrDefault(p => p.IdCuenta == id);
            return cuentas;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Cuentas cuentas)
        {
            try
            {
                context.cuentas.Add(cuentas);
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
        public ActionResult Put(int id, [FromBody]Cuentas cuentas)
        {
            try
            {
                context.Entry(cuentas).State = EntityState.Modified;
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
                var cuentas = context.cuentas.FirstOrDefault(p => p.IdCuenta == id);
                if (cuentas != null)
                {
                    context.cuentas.Remove(cuentas);
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
