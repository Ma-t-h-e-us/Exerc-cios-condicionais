using System;

namespace Ex_Back_end_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos anos você tem?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 5 && idade <= 7)
            {
                Console.WriteLine("Infantil A");
            }

            if (idade >= 8 && idade <= 10)
            {
                Console.WriteLine("Infantil B");
            }

            if (idade >= 11 && idade <= 13)
            {
                Console.WriteLine("Juvenil A");
            }

            if (idade >= 14 && idade <= 17)
            {
                Console.WriteLine("Juvenil B");
            }

            if (idade > 18)
            {
                 Console.WriteLine("Sênior");
            }
        }
    }
}
