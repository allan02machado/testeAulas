using System;

namespace testeAulas
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Hi dude, welcome my program!");

                Console.Write("Do you ready?! Y/N: ");
                opcao = Console.ReadLine().ToUpper();
            } while (opcao != "Y");

            Console.WriteLine("Come back ever!");
        }
    }
}
