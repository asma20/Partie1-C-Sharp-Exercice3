using System;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.WriteLine("Entrer le 1 ére nombre :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrer le 2éme nombre :");
            number2 = Convert.ToInt32(Console.ReadLine());
            float s = number1 + 33;
            number2 ++;
            float division = s/ number2;
            Console.WriteLine("Somme "+s);
            Console.WriteLine("L'incrémentation" + number2);
            Console.WriteLine("la resultat de division est "+division);



        }
    }
}
