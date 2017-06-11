﻿using System;
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
    public class RetiroesController : ApiController
    {
        private CajeroDBContext db = new CajeroDBContext();

        // GET: api/Retiroes
        public IQueryable<Retiro> GetRetiro()
        {
            return db.Retiro;
        }

        // GET: api/Retiroes/5
        [ResponseType(typeof(Retiro))]
        public IHttpActionResult GetRetiro(int id)
        {
            Retiro retiro = db.Retiro.Find(id);
            if (retiro == null)
            {
                return NotFound();
            }

            return Ok(retiro);
        }

        // PUT: api/Retiroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRetiro(int id, Retiro retiro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != retiro.idRetiro)
            {
                return BadRequest();
            }

            db.Entry(retiro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RetiroExists(id))
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

        // POST: api/Retiroes
        [ResponseType(typeof(Retiro))]
        public IHttpActionResult PostRetiro(Retiro retiro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Retiro.Add(retiro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = retiro.idRetiro }, retiro);
        }

        // DELETE: api/Retiroes/5
        [ResponseType(typeof(Retiro))]
        public IHttpActionResult DeleteRetiro(int id)
        {
            Retiro retiro = db.Retiro.Find(id);
            if (retiro == null)
            {
                return NotFound();
            }

            db.Retiro.Remove(retiro);
            db.SaveChanges();

            return Ok(retiro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RetiroExists(int id)
        {
            return db.Retiro.Count(e => e.idRetiro == id) > 0;
        }
    }
}