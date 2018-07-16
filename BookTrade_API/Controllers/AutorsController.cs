using System.Data;
using System.Linq;
using System.Web.Http;
using BookTrade_API.Models;

namespace BookTrade.Api {
    public class AutorsController : ApiController {

        //referência para a base de dados 
        private DbCtxt db = new DbCtxt();

        // GET: api/AutorsAPI
        [HttpGet, Route("api/autor")]
        public IHttpActionResult GetAutors() {
            var a = db.Autors.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id do Autor
                    nome = aa.Nome, // Retorna o nome do autor
                    Aniv = aa.DataNasc, // Retorna a data de nascimento do autor
                    sinopse = aa.Descricao, //Rertorna a sinopse do autor
                    imagem = aa.AutorFotografia
                });

            return Ok(a);
        }

        // GET: api/AutorsAPI/5
        [HttpGet, Route("api/autor/{id}")]
        public IHttpActionResult GetAutor(int id) {
            var a = db.Autors.Select(
               aa => new {
                   id = aa.Id,  // Retorna o Id do Autor
                   nome = aa.Nome, // Retorna o nome do autor
                   Aniv = aa.DataNasc, // Retorna a data de nascimento do autor
                   sinopse = aa.Descricao, //Rertorna a sinopse do autor
                   imagem = aa.AutorFotografia
               }).Where(r => r.id == id).First();

            if (a == null) return NotFound();
            var Autor = new {
                id = a.id,  // Retorna o Id do Autor
                nome = a.nome, // Retorna o nome do autor
                Aniv = a.Aniv, // Retorna a data de nascimento do autor
                sinopse = a.sinopse, //Rertorna a sinopse do autor
                imagem = a.imagem
            };
            return Ok(Autor);
        }
    }


}

