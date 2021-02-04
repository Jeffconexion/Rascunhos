using System;
using System.Collections.Generic;


namespace BookStore.Domain
{
    public class Autor
    {
        public Autor()
        {
            this.Livros = new List<Livro>();
        }
        public int Id { set; get; }
        public string Nome { set; get; }
        public ICollection<Livro> Livros { set; get; }
    }
}