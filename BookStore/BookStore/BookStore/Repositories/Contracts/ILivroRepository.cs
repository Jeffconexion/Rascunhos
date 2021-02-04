using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repositories.Contracts
{
    public interface ILivroRepository : IDisposable
    {
        List<Livro> Get();
        Livro Get(int id);
        List<Livro> GetByName(string name);
        bool Create(Livro livro);
        bool Update(Livro livro);
        bool Delete(int id);
    }
}
