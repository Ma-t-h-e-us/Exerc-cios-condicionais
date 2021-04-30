using System;

namespace Ex_Back_end_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sou um viajante do tempo sobrevivente da sengunda pandemia, em que ano estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            if (anoAtual <= 2020)
            {
                Console.WriteLine("não...meus cálculos não erram por tanto, MENTIROSO, VENHAM GUARDAS DO TEMPO!");
            }
            else
            {
                if (anoAtual > 2021)
                {
                    Console.WriteLine("não minta pra mim...");
                }
                else
                {
                    Console.WriteLine("muito bem, em que ano você nasceu?");
                    int anoNascimento = int.Parse(Console.ReadLine());

                    int idadeDaPessoa = anoAtual - anoNascimento;
                    int idadeEmSemanas = idadeDaPessoa * 48;

                    Console.WriteLine("então você tem " + idadeDaPessoa + " anos...");
                    Console.WriteLine("também conhecido como " + idadeEmSemanas + " semanas de vida");
                }


            }


        }
    }
}
