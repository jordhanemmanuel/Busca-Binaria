using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arveres
{
    class Program
    {
        static void Main(string[] args)
        {
            TADArvore arvore = new TADArvore();
            arvore.Add(5);
            arvore.Add(4);
            arvore.Add(10);
            arvore.Add(20);
            arvore.Add(3);
            arvore.Add(7);
            arvore.Add(9);
            arvore.Add(12);
            arvore.ImprimirTodos();

            bool boolean = arvore.Consultar(99);
            Console.WriteLine(boolean);
            Console.ReadKey();
        }
    }
}
