using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Repositories
{
    public class LivroRepository : ILivroRepository
    {
        private BookStoreDataContext _db = new BookStoreDataContext();


        public bool Create(Livro livro)
        {
            _db.Livros.Add(livro);
            _db.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            Livro livroApagar = _db.Livros.Find(id);
            _db.Livros.Remove(livroApagar);

            _db.SaveChanges();

            return true;
        }

        public List<Livro> Get()
        {
            return _db.Livros.ToList();
        }

        public Livro Get(int id)
        {
            return _db.Livros.Find(id);
        }

        public List<Livro> GetByName(string name)
        {
            return _db.Livros.Where(l => l.Nome.Contains(name)).ToList();
        }

        public bool Update(Livro livro)
        {
            _db.Entry<Livro>(livro).State = EntityState.Modified;
            _db.SaveChanges();

            return true;
        }
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}