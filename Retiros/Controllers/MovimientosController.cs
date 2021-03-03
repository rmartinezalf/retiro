using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Retiros.Contexts;
using Retiros.Entities;
using System.Data.SqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Retiros.Controllers
{
    [Route("api/[controller]")]
    public class MovimientosController : Controller
    {
        private AppDbContext context;

        public MovimientosController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Movimientos> Get()
        {
            return context.movimientos.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Movimientos Get(int id)
        {

            var movimientos = context.movimientos.FirstOrDefault(p => p.IdMovimiento == id);
            return movimientos;
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody]Movimientos movimientos)
        {
            //List<Movimientos> lst = context.movimientos.FromSql("calculoSaldo",movimientos.IdCuenta, movimientos.Fecha, movimientos.ValorRetiro,movimientos.CuentaDestino).ToList();
            //int result = context.Database.ExecuteSqlCommand("calculoSaldo", movimientos.IdCuenta, movimientos.Fecha, movimientos.ValorRetiro, movimientos.CuentaDestino);
            try
            {
                SqlParameter  cta = new SqlParameter("@nombreCta", movimientos.IdCuenta);

                SqlParameter retiro = new SqlParameter("@valorRetiro", movimientos.ValorRetiro);
                SqlParameter ctaDestino = new SqlParameter(" @cuentaDestino", movimientos.CuentaDestino);
                SqlParameter tipoTransaccion = new SqlParameter(" @tipoTransaccion", null);
                
                int result = context.Database.ExecuteSqlCommand("calculoSaldo @nombreCta,  @valorRetiro, @cuentaDestino, @tipoTransaccion", cta, retiro, ctaDestino, tipoTransaccion);

                //    context.movimientos.Add(movimientos);
                //    context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        //// PUT api/<controller>/5
        //[HttpPut("{id}")]
        //public ActionResult Put(int id, [FromBody]Movimientos movimientos)
        //{
        //    try
        //    {
        //        context.Entry(movimientos).State = EntityState.Modified;
        //        context.SaveChanges();

        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }

        //}

        // DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        var movimientos = context.movimientos.FirstOrDefault(p => p.IdMovimiento == id);
        //        if (movimientos != null)
        //        {
        //            context.movimientos.Remove(movimientos);
        //            context.SaveChanges();
        //            return Ok();
        //        }
        //        else
        //        {
        //            return BadRequest();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest();
        //    }
        //}
    }
}
