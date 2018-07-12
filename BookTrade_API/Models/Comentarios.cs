namespace BookTrade.Models {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Comentarios {
        //Chave Prim�ria
        [Key]
        public int Id { get; set; }

        [Required]
        public string Texto { get; set; }

        public DateTime Data { get; set; }

        //Chaves Forasteiras da tabela Coment�rios
        [ForeignKey("Livros")]
        public int LivroId { get; set; }

        public virtual Livro Livros { get; set; }

        [ForeignKey("Utilizadores")]
        public int UtilizadorId { get; set; }

        public virtual Utilizador Utilizadores { get; set; }
    }
}
