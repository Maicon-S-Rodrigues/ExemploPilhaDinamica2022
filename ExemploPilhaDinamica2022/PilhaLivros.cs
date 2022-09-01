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

        public PilhaLivros ()
        {
            this.TOPO = null;
            Console.WriteLine("Pilha criada com sucesso!");
        } //iniciando uma nova pilha

        public void Push (Livro auxiliar)
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
                Console.WriteLine("\nSimpatia, a Pilha esta vazia. Não tem o que remover!");
            }
            else
            {
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

        public void Print () // percorrer a pilha caso não esteja vazia e imprimir os dados
        {
            if (Vazia())
            {
                Console.WriteLine("\nSimpatia, a Pilha esta vazia. Não posso imprimir!");
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
                Console.WriteLine("\n\nFim da Impressão da Pilha.");               
            }
        }
    }
}
