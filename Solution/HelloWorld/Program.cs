using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu nome: ");
            String name = Console.ReadLine();

            Console.WriteLine($"Olá, {name}!");

            Console.ReadLine();
        }
    }
}
