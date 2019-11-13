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
using RegistroDeImoveisMigrationApiWeb.Models;


namespace RegistroDeImoveisMigrationApiWeb.Controllers
{
    public class ProprietariosController : ApiController
    {
        private MigrationContext db = new MigrationContext();

        // GET: api/Proprietarios
        public IQueryable<Proprietario> GetProprietarios()
        {
            return db.Proprietarios;
        }

        // GET: api/Proprietarios/5
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult GetProprietario(string id)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            return Ok(proprietario);
        }

        // PUT: api/Proprietarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProprietario(string id, Proprietario proprietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != proprietario.Nome)
            {
                return BadRequest();
            }

            db.Entry(proprietario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProprietarioExists(id))
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

        // POST: api/Proprietarios
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult PostProprietario(Proprietario proprietario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Proprietarios.Add(proprietario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ProprietarioExists(proprietario.Nome))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = proprietario.Nome }, proprietario);
        }

        // DELETE: api/Proprietarios/5
        [ResponseType(typeof(Proprietario))]
        public IHttpActionResult DeleteProprietario(int id)
        {
            Proprietario proprietario = db.Proprietarios.Find(id);
            if (proprietario == null)
            {
                return NotFound();
            }

            db.Proprietarios.Remove(proprietario);
            db.SaveChanges();

            return Ok(proprietario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProprietarioExists(string id)
        {
            return db.Proprietarios.Count(e => e.Nome == id) > 0;
        }
    }
}