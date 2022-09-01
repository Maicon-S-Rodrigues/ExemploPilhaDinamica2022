using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPilhaDinamica2022
{
    internal class Livro
    {

        public string Titulo { get; set; }
        public int ISBN { get; set; }
        public string Autor { get; set; }
        public Livro Anterior { get; set; }

        public Livro (string titulo, int ISBN, string Autor)
        {
            this.Titulo = titulo;
            this.ISBN = ISBN;
            this.Autor = Autor;
            this.Anterior = null;
        }

        public override string ToString()
        {
            return "\nDados do livro:\nTitulo: " + this.Titulo + "\nAutor: " + this.Autor + "\nISBN: " + this.ISBN;
        }
    }
}
