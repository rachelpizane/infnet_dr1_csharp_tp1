using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 27;
            string name = "Rachel";
            double altura = 1.72;

            Console.WriteLine("== INFORMAÇÕES =============================");
            Console.WriteLine($"Nome: {name}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Altura: {altura}");
            Console.WriteLine("============================================");

            Console.ReadLine();
        }
    }
}
