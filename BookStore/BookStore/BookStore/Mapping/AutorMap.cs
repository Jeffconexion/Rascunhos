using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class AutorMap : EntityTypeConfiguration<Autor>
    {

        public AutorMap()
        {
            ToTable("Autor");

            HasKey(a => a.Id);
            Property(a => a.Nome).HasMaxLength(60).IsRequired();

            HasMany(a => a.Livros)
                .WithMany(l => l.Autores)
                .Map(a => a.ToTable("LivroAutor"));
        }


    }
}