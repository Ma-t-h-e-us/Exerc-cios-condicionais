using System;

namespace Ex_Back_end
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            int idadeMeses = idade * 12;
            int idadeDias = idade * 365;
            int idadeHoras = idadeDias * 24;
            int idadeMinutos = idadeHoras * 60;

            Console.WriteLine("você tem " + idadeMeses + " meses de vida");
            Console.WriteLine("você tem " + idadeDias + " dias de vida");
            Console.WriteLine("você tem " + idadeHoras + " horas de vida");
            Console.WriteLine("você tem " + idadeMinutos + " minutos de vida");
        }
    }
}
