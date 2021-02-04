using System;
using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Livro
    {

        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { set; get; }

        public string Nome { set; get; }

        public string ISBN { set; get; }

        public DateTime DataLacamento { set; get; }

        public int CategoriaId { set; get; }

        //var livro = ObterLivro(1);
        //livro.Categoria.Nome (consigo caminhar entre os meus objetos.)
        public Categoria Categoria { set; get; }
        public ICollection<Autor> Autores { set; get; }
    }
}