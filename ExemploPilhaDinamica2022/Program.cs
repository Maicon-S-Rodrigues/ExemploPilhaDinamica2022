using System;

namespace ExemploPilhaDinamica2022
{
    internal class Program
    {
        //----------------------------------------------------------------//
        static PilhaLivros minhaPilha = new PilhaLivros();//--------------//
        //----------------------------------------------------------------//
        static void TelaInicial ()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\t\t1 - Inserir um novo Livro na Pilha");
                Console.WriteLine("\n\t\t2 - Remover um Livro da Pilha");
                Console.WriteLine("\n\t\t3 - Imprimir Pilha");
                Console.WriteLine("\n\t\t4 - Mostrar a quantidade de Livros na Pilha");
                Console.WriteLine("\n\t\t5 - Procurar por um Livro Específico");
                Console.WriteLine("\n\t\t0 - Encerrar Programa");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        CadastrarNovoLivro();
                        break;

                    case 2:
                        minhaPilha.Pop();
                        break;
                    case 3:
                        minhaPilha.Print();
                        break;

                    case 4:
                        minhaPilha.VerQuantidade();
                        break;

                    case 5:
                        string titulo;
                        Console.Clear();
                        Console.Write("\n\t\tQual o Titulo deseja: ");
                        titulo = Console.ReadLine();
                        minhaPilha.procurarTitulo(titulo);
                        break;
                }
            } while (opc != 0);
            Console.WriteLine("\n\n\t\tEncerrando...\n\n\n\n\n\n\n\n\n\n");
        }

        static void CadastrarNovoLivro ()
        {
            string titulo, autor;
            int isbn;

            Console.Clear();
            Console.Write("\n\t\tQual é o nome do Autor do Livro: ");
            autor = Console.ReadLine();
            Console.Write("\n\t\tQual é o Titulo do Livro: ");
            titulo = Console.ReadLine();
            Console.Write("\n\t\tQual é o ISBN do Livro: ");
            isbn = int.Parse(Console.ReadLine());

            minhaPilha.Push(new Livro(titulo, isbn, autor));
        }
        static void Main(string[] args)
        {
            TelaInicial();
        }
    }
}
