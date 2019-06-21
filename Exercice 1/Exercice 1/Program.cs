using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour , choisissez un nombre :");
            //String nbuser1 = Console.ReadLine();
            int nombre;
            int.TryParse(Console.ReadLine(), out nombre);
            for(int i = nombre; i > -1; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}