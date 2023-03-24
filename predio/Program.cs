using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace predio
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevador elevador = new Elevador(10, 10);

            elevador.EntrarElevador(1);

            elevador.Deslocar(7);

            elevador.Deslocar(3);

            elevador.EntrarElevador(3);

            elevador.Deslocar(3);

            elevador.Sair(2);

            Console.WriteLine("Andar Atual: " + elevador.AndarAtual);
            Console.WriteLine("Pessoas no elevador: " + elevador.Totalpessoa);
            Console.ReadKey();



        }
    }
}
