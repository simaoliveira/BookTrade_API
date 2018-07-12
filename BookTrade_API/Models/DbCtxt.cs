
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookTrade.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BookTrade_API.Models
{
        public class DbCtxt : DbContext
        {

            public virtual DbSet<Categorias> Categorias { get; set; }
            public virtual DbSet<Livro> Livros { get; set; }
            public virtual DbSet<Autor> Autors { get; set; }
            public virtual DbSet<Utilizador> Utilizador { get; set; }
            public virtual DbSet<Comentarios> Comentarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
                modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

                base.OnModelCreating(modelBuilder);

            }

        }

}