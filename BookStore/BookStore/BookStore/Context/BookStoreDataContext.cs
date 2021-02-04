using BookStore.Domain;
using BookStore.Mapping;
using System.Data.Entity;

namespace BookStore.Context
{
    public class BookStoreDataContext : DbContext
    {

        public BookStoreDataContext()
            : base("BookStoreConnectionString")
        {

        }

        public DbSet<Autor> Autores { set; get; }
        public DbSet<Categoria> Categorias { set; get; }
        public DbSet<Livro> Livros { set; get; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AutorMap());
            modelBuilder.Configurations.Add(new CategoriaMap());
            modelBuilder.Configurations.Add(new LivroMap());

        }

    }
}