using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador(10, 10);

            elevador.Entrar(1);

            elevador.Deslocar(7);

            elevador.Sair(1);

            elevador.Deslocar(3);

            elevador.Entrar(3);

            elevador.Deslocar(5);

            elevador.Sair(2);
            
            Console.WriteLine("Andar atual: " + elevador.AndarAtual);
            Console.WriteLine("Pessoas no elevador: " + elevador.QtdeAtual);


            Console.ReadKey();

        }
    }
}
