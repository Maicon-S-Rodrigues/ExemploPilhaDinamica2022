using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploPilhaDinamica2022
{
    internal class PilhaLivros
    {
        public Livro TOPO { get; set; }

        public PilhaLivros()
        {
            this.TOPO = null;
        } //iniciando uma nova pilha

        public void Push(Livro auxiliar)
        {
            if (Vazia())
            {
                this.TOPO = auxiliar;
            }
            else
            {
                auxiliar.Anterior = TOPO;
                this.TOPO = auxiliar;
            }

        }   // "Push" é usado para colocar itens na pilha

        public void Pop() // "Pop" é usado para remover itens da lista
        {
            if (Vazia())
            {
                Console.WriteLine("\n\t\tSimpatia, a Pilha esta vazia. Não tem o que remover!");
                Console.ReadKey();
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
            }
            else
            {
                Console.WriteLine("\n\t\tRemossão Conlcúida!");
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                Console.ReadKey();
                TOPO = TOPO.Anterior; //o TOPO passa a apontar para o objeto que estava sendo referenciado no atributo "ANTERIOR"
            }
        }

        private bool Vazia()
        {
            if (this.TOPO == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // verificar se o topo está vazio

        public void Print() // percorrer a pilha caso não esteja vazia e imprimir os dados
        {
            Console.Clear();
            if (Vazia())
            {
                Console.WriteLine("\n\t\tSimpatia, a Pilha esta vazia. Não posso imprimir!");
                Console.ReadKey();
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
            }
            else
            {
                Livro auxiliar = this.TOPO; //recebe o topo para iniciar

                do //entra no laço para imprimir todos até que no primeiro item na base, onde o seu atributo "ANTERIOR" estara valendo "NULO"
                {
                    Console.WriteLine(auxiliar.ToString() + "\n"); //usa o metodo ToString de Livro para mostrar o objeto na tela
                    auxiliar = auxiliar.Anterior; //o auxiliar recebe o atributo "ANTERIOR" do objeto, apontando agora para para o proximo item da lista

                } while (auxiliar != null); //verificca se o auxiliar(atributo "anterior" no objeto), se for diferente de null o laço continua
                                            //se for "null" o laço termina

                Console.WriteLine("\n\n\t\tFim da Impressão da Pilha.");
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void VerQuantidade()
        {
            int contador = 0;

            if (Vazia())
            {
                Console.Clear();
                Console.WriteLine("\n\t\tNenhum Livro na Pilha!");
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                Livro auxiliar = this.TOPO;

                do
                {
                    contador++;
                    auxiliar = auxiliar.Anterior;

                } while (auxiliar != null);

                Console.Clear();
                Console.WriteLine("\n\t\tQuantidade de Livros na Pilha: " + contador);
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }


        public void procurarTitulo(string titulo)
        {
            if (Vazia())
            {
                Console.WriteLine("\n\t\tNenhum Livro na Pilha!");
                Console.WriteLine("\n\t\tAperte qualquer tecla para voltar...");
                Console.ReadKey();
            }
            else
            {
                Livro auxiliar = this.TOPO;
                bool achou = false;
                do
                {
                    if (titulo == auxiliar.Titulo)
                    {
                        Console.WriteLine("\n\t\tLivro Encontrado:" + "\n\n\t\t" + auxiliar.ToString());
                        Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                        Console.ReadKey();
                        achou = true;
                    }
                    auxiliar = auxiliar.Anterior;

                } while (auxiliar != null);

                if (!achou)
                {
                    Console.WriteLine("\n\t\tLivro não localizado com esse título: " + titulo);
                }
                else
                {
                    Console.WriteLine("\n\t\tFim da busca.");
                }
                Console.WriteLine("\n\t\tAperte qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

    }
}
