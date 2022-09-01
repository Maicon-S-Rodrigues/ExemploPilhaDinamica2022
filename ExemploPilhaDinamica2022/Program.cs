using System;

namespace ExemploPilhaDinamica2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivros minhaPilha = new PilhaLivros();

            minhaPilha.Print();

            Livro livro = new Livro("A volta dos que não foram!", 1234, "Alexandre");
            minhaPilha.Push(livro);

            minhaPilha.Push(new Livro("Poeira em alto mar!", 4321, "Baratão"));

            minhaPilha.Print();

            minhaPilha.Pop();
            minhaPilha.Print();

            /////
            minhaPilha.Pop();
            minhaPilha.Print();
            /////
            minhaPilha.Pop();
        }
    }
}
