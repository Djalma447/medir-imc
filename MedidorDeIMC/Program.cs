using System;
using System.Globalization;

namespace MedidorDeIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Medidor de IMC (Índice de Massa Corporal)");
            Console.WriteLine("Digite seu peso (Kg)");
            double peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite sua altura (M)");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("Seu IMC é: " + imc.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
