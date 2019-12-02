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

            if (imc < 18.5)
            {
                Console.WriteLine("Peso abaixo do normal. Neste caso, é necessária a busca por um especialista, para verificar a existência de algum problema de saúde causador do índice abaixo do normal, ou analisar se sua saúde não está sendo afetada.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal. No entanto, mesmo nesta faixa de peso, deve-se ter atenção e cuidado com possíveis problemas metabólicos, principalmente se houver acúmulo de gordura na região interna do abdômen.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Peso em pré-obesidade ou acima do peso, representando um risco maior para a saúde. Nesta causa, é imprescindível uma consulta com um especialista, pois pode estar relacionado à pressão alta, colesterol alto ou diabetes, podendo apontar até para o hipotireoidismo.");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Este índice indica obesidade grau um. Este peso aumenta riscos para várias doenças, como diabetes, hipertensão arterial, o infarto do miocárdio e diversos tipos de câncer.");
            }
            else if (imc >= 35 && imc <= 39.9)
            {
                Console.WriteLine("Indica obesidade grau dois. Este peso já representa risco elevado para as doenças supracitadas.");
            }
            else
            {
                Console.WriteLine("Indica obesidade grau três ou mórbida. O peso neste grau apresenta problemas extremamente graves e necessita de tratamento profissional com o máximo de recursos disponíveis, incluindo até cirurgia.");
            }
        }
    }
}
