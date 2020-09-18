using System;

namespace Gritador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite qualquer palavra: ");
            string palavra = Console.ReadLine().ToUpper();
            Console.WriteLine($"Palavra em CAIXA ALTA: {palavra}");
            Console.ReadKey();
        }
    }
}
