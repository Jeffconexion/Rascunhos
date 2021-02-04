using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Categoria
    {
        public Categoria()
        {
            /* É importante porque se eu tentar acessar o objeto 
             * sem iniciar daria erro.
             * categoria.Livros.Add(livro); sem o construtor daria erro.
             */
            this.Livros = new List<Livro>();
        }

        public int Id { set; get; }

        public string Nome { set; get; }

        //ICollection é uma interface obrigatoria para utilizar o ORM
        public ICollection<Livro> Livros { set; get; }
    }
}