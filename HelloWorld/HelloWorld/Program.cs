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
            Console.WriteLine("Comment t'appelles-tu ?");
            String nom;
            nom = Console.ReadLine();
            Console.WriteLine("Quel àge as-tu ?");
            int age;
            int.TryParse(Console.ReadLine(), out age);

            Console.Clear();
            if(age == 1)
            {
                Console.WriteLine("Bonjour " + nom + ", tu as " + age + " an.");
            }
            else
            {
                Console.WriteLine("Bonjour " + nom + ", tu as " + age + " ans.");
            }
            
            
            Console.ReadKey();
        }
    }
}