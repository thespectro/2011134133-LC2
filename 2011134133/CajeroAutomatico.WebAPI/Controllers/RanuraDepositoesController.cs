using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using CajeroAutomatico.Entities;
using CajeroAutomatico.Persistance;

namespace CajeroAutomatico.WebAPI.Controllers
{
    public class RanuraDepositoesController : ApiController
    {
        private CajeroDBContext db = new CajeroDBContext();

        // GET: api/RanuraDepositoes
        public IQueryable<RanuraDeposito> GetRanuraDeposito()
        {
            return db.RanuraDeposito;
        }

        // GET: api/RanuraDepositoes/5
        [ResponseType(typeof(RanuraDeposito))]
        public IHttpActionResult GetRanuraDeposito(int id)
        {
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            if (ranuraDeposito == null)
            {
                return NotFound();
            }

            return Ok(ranuraDeposito);
        }

        // PUT: api/RanuraDepositoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRanuraDeposito(int id, RanuraDeposito ranuraDeposito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ranuraDeposito.idRanuraDeposito)
            {
                return BadRequest();
            }

            db.Entry(ranuraDeposito).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RanuraDepositoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/RanuraDepositoes
        [ResponseType(typeof(RanuraDeposito))]
        public IHttpActionResult PostRanuraDeposito(RanuraDeposito ranuraDeposito)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RanuraDeposito.Add(ranuraDeposito);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ranuraDeposito.idRanuraDeposito }, ranuraDeposito);
        }

        // DELETE: api/RanuraDepositoes/5
        [ResponseType(typeof(RanuraDeposito))]
        public IHttpActionResult DeleteRanuraDeposito(int id)
        {
            RanuraDeposito ranuraDeposito = db.RanuraDeposito.Find(id);
            if (ranuraDeposito == null)
            {
                return NotFound();
            }

            db.RanuraDeposito.Remove(ranuraDeposito);
            db.SaveChanges();

            return Ok(ranuraDeposito);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RanuraDepositoExists(int id)
        {
            return db.RanuraDeposito.Count(e => e.idRanuraDeposito == id) > 0;
        }
    }
}