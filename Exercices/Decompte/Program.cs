using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decompte
{
    class Program
    {
        static void Main(string[] args)
        {
            //demander un nombre à l'utilisateur
            Console.WriteLine("Donnez un nombre de départ");
            String reponse = Console.ReadLine();
            int nb;

            //tester si le nombre est correct
            if (int.TryParse(reponse, out nb))
            {
                //si oui : decompte
                while (nb >= 0)
                {
                    Console.WriteLine(nb);
                    nb--;
                }
            }
            else
            {
                //sinon : afficher un message d'erreur
                Console.WriteLine("Désole, votre nombre n'est pas correct");
            }
            //fin du programme
            Console.ReadKey();
        }
    }
}
