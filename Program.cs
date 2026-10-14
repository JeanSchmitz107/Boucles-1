namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 10

        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n\n");

        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("Bonne année !");
        Console.WriteLine("\n\n\n");

        // Etape 3 : faire un compteur qui va de -4 à 2

        for (int i = -4; i < 3; i++)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("\n\n\n");

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15

        for (int i = 0; i < 16; i += 2)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("15\n\n\n");

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"

        string oui = "";
        while (oui != "oui")
        {
            oui = Console.ReadLine();
        }
        Console.WriteLine("\n\n\n");


        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}