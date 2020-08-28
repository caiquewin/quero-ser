using System;
using System.Linq;

namespace Calculando_estatísticas_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int media = 0;
            Console.Write("Coloque os valores: ");
            try
            {
                var numeros = Console.ReadLine().Split(' ').Select(i => int.Parse(i));
                numeros.ToArray();
                foreach (int num in numeros)
                {
                    media += num;
                }
                media /= numeros.Count();
                Console.WriteLine("Valor Mínimo: "+numeros.Min());
                Console.WriteLine("Valor Máximo: "+numeros.Max());
                Console.WriteLine("Número de elementos na sequência: "+numeros.Count());
                Console.WriteLine("Valor médio: "+media);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro coloque numeros inteiro e separado exemplo> 6 9 15 -2 92 11");
                Console.WriteLine("Coloque valores inteiros sem virgula ou ponto");
            }
            



            
        }
    }
}
