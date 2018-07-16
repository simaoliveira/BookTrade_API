using System.Data;
using System.Linq;
using System.Web.Http;
using BookTrade_API.Models;

namespace BookTrade.Api {
    public class LivrosController : ApiController {

        //referência para a base de dados 
        private DbCtxt db = new DbCtxt();

        // GET: api/LivrosAPI
        [HttpGet, Route("api/livros")]
        public IHttpActionResult GetBooks() {
            var a = db.Livros.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id do Livro
                    titulo = aa.Titulo, // Retorna o Titulo do Livro
                    autores = aa.Autores.Id,// Retorna o Id Autor do Livro
                    autoresNome = aa.Autores.Nome, //Retorna o Nome do Autor
                    editora = aa.Editora, //Retorna a editora do livro
                    idioma = aa.Idioma, //Retorna o idioma do livro
                    ano = aa.AnoLanc, // Retorna o Ano de Lançamento 
                    numPag = aa.NumeroDePaginas, //Retorna o Número de Páginas
                    categoria = aa.Categorias.Select(bb => new { bb.Nome, bb.Id }), // Retorna a Categoria do Livro 
                    fotografia = aa.Fotografia, // Retorna o nome da Imagem do Livro 
                    sinopse = aa.Sinopse, //Rertorna a Sinopse do livro 
                })

             .ToList();  // O ToList() executa a query na base de dados e guarda os resultados numa List<>.

            return Ok(a);
        }

        // GET: api/LivrosAPI/5
        [HttpGet, Route("api/livros/{id}")]
        public IHttpActionResult GetBook(int id) {
            var livro = db.Livros.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id do Livro
                    titulo = aa.Titulo, // Retorna o Titulo do Livro
                    autores = aa.Autores.Id,// Retorna o Id Autor do Livro
                    autoresNome = aa.Autores.Nome, //Retorna o Nome do Autor
                    editora = aa.Editora, //Retorna a editora do livro
                    idioma = aa.Idioma, //Retorna o idioma do livro
                    ano = aa.AnoLanc, // Retorna o Ano de Lançamento 
                    numPag = aa.NumeroDePaginas, //Retorna o Número de Páginas
                    categoria = aa.Categorias.Select(bb => new { bb.Nome, bb.Id }), // Retorna a Categoria do Livro 
                    fotografia = aa.Fotografia, // Retorna o nome da Imagem do Livro 
                    sinopse = aa.Sinopse, //Retorna a Sinopse do livro
                }).Where(aa => aa.id == id).FirstOrDefault();

            if (livro == null) {
                return NotFound();
            }
            return Ok(livro);
        }

    }
}
