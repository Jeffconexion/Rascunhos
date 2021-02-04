using BookStore.Domain;
using System.Data.Entity.ModelConfiguration;

namespace BookStore.Mapping
{
    public class LivroMap : EntityTypeConfiguration<Livro>
    {

        public LivroMap()
        {
            ToTable("Livro");

            HasKey(l => l.Id);
            Property(l => l.Nome).HasMaxLength(60).IsRequired().HasColumnType("varchar");
            Property(l => l.ISBN).HasMaxLength(32).IsRequired();
            Property(l => l.DataLacamento).IsRequired();
        }

    }
}