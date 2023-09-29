using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHAILAN_Bérénice_TD1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Demandez à l'utilisateur de saisir la somme d'argent
            Console.Write("Saisissez la somme d'argent : ");
            int somme = Convert.ToInt32(Console.ReadLine()); // L'utilisateur saisit une valeur, qui est convertie en entier (int).

            // Calculez le nombre de billets de 100 €
            int billet100 = somme / 100; // Utilise la division entière pour calculer le nombre de billets de 100 €.
            somme %= 100; // Calcule le reste après avoir retiré les billets de 100 €.

            // Calculez le nombre de billets de 50 €
            int billet50 = somme / 50; // Utilise la division entière pour calculer le nombre de billets de 50 €.
            somme %= 50; // Calcule le reste après avoir retiré les billets de 50 €.

            // Calculez le nombre de billets de 10 €
            int billet10 = somme / 10; // Utilise la division entière pour calculer le nombre de billets de 10 €.
            somme %= 10; // Calcule le reste après avoir retiré les billets de 10 €.

            // Calculez le nombre de billets de 5 €
            int billet5 = somme / 5; // Utilise la division entière pour calculer le nombre de billets de 5 €.
            somme %= 5; // Calcule le reste après avoir retiré les billets de 5 €.

            // Le reste est le nombre de pièces de 1 €
            int piece1 = somme; // Le reste après avoir retiré tous les billets est le nombre de pièces de 1 €.

            // Affichez les résultats
            Console.WriteLine($"{billet100} billet(s) de 100 €"); // Affiche le nombre de billets de 100 €.
            Console.WriteLine($"{billet50} billet(s) de 50 €"); // Affiche le nombre de billets de 50 €.
            Console.WriteLine($"{billet10} billet(s) de 10 €"); // Affiche le nombre de billets de 10 €.
            Console.WriteLine($"{billet5} billet(s) de 5 €"); // Affiche le nombre de billets de 5 €.
            Console.WriteLine($"{piece1} piece(s) de 1 €"); // Affiche le nombre de pièces de 1 €.

            Console.Read();
        }
    }
}
