using System;

namespace Ex_Back_end_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu salário?");
            float salario = float.Parse(Console.ReadLine());
            // Console.WriteLine(salario);

            if (salario < 500) {
                float salarioComAumento = salario * 30 / 100 + salario;
                Console.WriteLine("seu salário teve um aumento de 30%, agora está com valor de R$ " + salarioComAumento);
            } else {
                Console.WriteLine("desculpe, você não tem direito a um aumento :(");
            }
        }
    }
}
