using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arveres
{
    class TADArvore
    {
        private No raiz;

        public void Add(int n)
        {
            if (raiz == null)
            {
                raiz = new No();
                raiz.Val = n;
            }
            else
            {
                Inserir(raiz, n);
            }
        }

        private void Inserir(No no, int valor)
        {
            if (valor >= no.Val)
            {
                if (no.Direita == null)
                {
                    no.Direita = new No();
                    no.Direita.Val = valor;
                }
                else
                {
                    Inserir(no.Direita, valor);
                }
            }
            else
            {
                if (no.Esquerda == null)
                {
                    no.Esquerda = new No();
                    no.Esquerda.Val = valor;
                }
                else
                {
                    Inserir(no.Esquerda, valor);
                }
            }
        }

        public void ImprimirTodos()
        {
            if (raiz != null)
                Imprimir(raiz);
        }

        private void Imprimir(No no)
        {
            if (no != null)
            {
                Console.WriteLine(no.Val);
                Imprimir(no.Direita);
                Imprimir(no.Esquerda);
            }
        }

        public bool Consultar(int n)
        {
              return ConsultarTodos(n, raiz);
        }

        private bool ConsultarTodos(int n, No no)
        {
            if (no != null)
            {
                if (no.Val != n)
                {
                    if (ConsultarTodos(n, no.Direita))
                        return true;
                    else
                        return ConsultarTodos(n, no.Esquerda);
                }
                else
                    return true;
            }
            return false;
        }
    }
}
