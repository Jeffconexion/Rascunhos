using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class CategoriaMap : EntityTypeConfiguration<Categoria>
    {

        public CategoriaMap()
        {
            ToTable("Categoria");

            HasKey(c => c.Id);
            Property(c => c.Nome).HasMaxLength(30).IsRequired();

            HasMany(c => c.Livros)
                .WithRequired(l => l.Categoria);
        }
    }
}