using System.Data;
using System.Linq;
using System.Web.Http;
using BookTrade_API.Models;

namespace BookTrade.Api {
    public class CategoriasController : ApiController {

        //referência para a base de dados
        private DbCtxt db = new DbCtxt();

        // GET: api/Categorias/5
        [HttpGet, Route("api/categorias")]
        public IHttpActionResult GetCategory() {

            var resultado = db.Categorias.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id da categoria  
                    nome = aa.Nome, // Retorna o Nome da categoria
                })
                .ToList();  // O ToList() executa a query na base de dados e guarda os resultados numa List<>.

            return Ok(resultado);
        }
    }
}
