using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using BookTrade.Models;
using BookTrade_API.Models;

namespace BookTrade.Api
    {
    public class AutorsController : ApiController {
        private DbCtxt db = new DbCtxt();

        // GET: api/Autors
        public IQueryable<Autor> GetAutors() {
            return db.Autors;
        }

        // GET: api/Autors/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult GetAtor(int id) {
            Autor autor = db.Autors.Find(id);
            if (autor == null) {
                return NotFound();
            }

            return Ok(autor);
        }

        // PUT: api/Autors/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAutor(int id, Autor autor) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            if (id != autor.Id) {
                return BadRequest();
            }

            db.Entry(autor).State = EntityState.Modified;

            try {
                db.SaveChanges();
            } catch (DbUpdateConcurrencyException) {
                if (!AutorExists(id)) {
                    return NotFound();
                } else {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Autors
        [ResponseType(typeof(Autor))]
        public IHttpActionResult PostAtor(Autor autor) {
            if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }

            db.Autors.Add(autor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = autor.Id }, autor);
        }

        // DELETE: api/Autors/5
        [ResponseType(typeof(Autor))]
        public IHttpActionResult DeleteAtor(int id) {
            Autor ator = db.Autors.Find(id);
            if (ator == null) {
                return NotFound();
            }

            db.Autors.Remove(ator);
            db.SaveChanges();

            return Ok(ator);
        }

        protected override void Dispose(bool disposing) {
            if (disposing) {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutorExists(int id) {
            return db.Autors.Count(e => e.Id == id) > 0;
        }
    }
}
