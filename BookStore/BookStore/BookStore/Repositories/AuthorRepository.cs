﻿using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookStoreDataContext _db;

        public AuthorRepository(BookStoreDataContext context)
        {
            _db = context;
        }

        public bool Create(Autor autor)
        {
            try
            {
                _db.Autores.Add(autor);
                _db.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Delete(int id)
        {
            Autor autor = _db.Autores.Find(id);

            _db.Autores.Remove(autor);
            _db.SaveChanges();
        }

        public List<Autor> Get()
        {
            return _db.Autores.ToList();
        }

        public Autor Get(int id)
        {
            return _db.Autores.Find(id);
        }

        public List<Autor> GetByName(string name)
        {
            return _db.Autores.Where(a => a.Nome.Contains(name)).ToList();
        }

        public bool Update(Autor autor)
        {
            try
            {
                _db.Entry<Autor>(autor).State = EntityState.Modified;
                _db.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}