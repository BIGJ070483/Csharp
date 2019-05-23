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
            String msg = "hello world";
            Console.WriteLine("Comment t'appelles-tu ?");
            String nom;
            nom = Console.ReadLine();
            Console.WriteLine("Quel àge as-tu ?");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Console.WriteLine(msg);
            Console.Clear();
            if (age == 1)
            {
                Console.WriteLine("Bonjour " + nom + ", tu as " + age + " an.");
            }
            else
            {
                Console.WriteLine("Bonjour " + nom + ", tu as " + age + " ans.");
            }

            int i = 3;
            int sum = somme(i, 5);
            Console.WriteLine(sum);

            Console.ReadKey();
        }

        /// <summary>
        /// fait la somme de nb1 + nb2
        /// </summary>
        /// <param name="nb1">Premier nombre</param>
        /// <param name="nb2">Deuxieme nombre</param>
        /// <returns></returns>
        static int somme(int nb1, int nb2)
        {
            return nb1 + nb2;
        }
    }
}