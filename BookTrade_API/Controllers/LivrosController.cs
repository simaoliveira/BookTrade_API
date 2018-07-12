using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using BookTrade.Models;
using BookTrade_API.Models;

namespace BookTrade.Api
    {
    public class LivrosController : ApiController {

        //referência para a base de dados 
        private DbCtxt db = new DbCtxt();

        // GET: api/LivrosAPI
        [HttpGet, Route("api/livros")]
        public IHttpActionResult GetLivros() {
            var a = db.Livros.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id do Livro
                    titulo = aa.Titulo, // Retorna o Titulo do Livro 
                    ano = aa.AnoLanc, // Retorna o Ano de Lançamento 
                    autores = aa.Autores.Id,// Retorna o Id Autor do Livro
                    autoresNome = aa.Autores.Nome, //Retorna o Nome do Autor 
                    categoria = aa.Categorias.Select(bb => new { bb.Nome, bb.Id }), // Retorna a Categoria do Livro 
                    fotografia = aa.Fotografia, // Retorna o nomde da Imagem do Livro 
                    sinopse = aa.Sinopse, //Rertorna a Sinopse do livro 
                })

             .ToList();  // O ToList() executa a query na base de dados e guarda os resultados numa List<>.

            return Ok(a);
        }

        // GET: api/LivrosAPI/5
        [HttpGet, Route("api/filme/{id}")]
        public IHttpActionResult GetLivro(int id) {
            var livro = db.Livros.Select(
                aa => new {
                    id = aa.Id,  // Retorna o Id do Livro
                    titulo = aa.Titulo, // Retorna o Titulo do Livro 
                    ano = aa.AnoLanc, // Retorna o Ano de Lançamento 
                    realizador = aa.Autores.Id,// Retorna o Id Autor do Livro
                    realizadorNome = aa.Autores.Nome, //Retorna o Nome do Livro 
                    categoria = aa.Categorias.Select(bb => new { bb.Nome, bb.Id }), // Retorna a Categoria do Livro 
                    fotografia = aa.Fotografia, // Retorna o nomde da Imagem do Livro 
                    sinopse = aa.Sinopse, //Rertorna a Sinopse do Livro 
                }).Where(aa => aa.id == id).FirstOrDefault();

            if (livro == null) {
                return NotFound();
            }
            return Ok(livro);
        }

    }
}
