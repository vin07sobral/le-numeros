using System;
namespace revisao_logica_de_programacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, quadrado;
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                quadrado = x * x;
                Console.WriteLine(quadrado);
                x = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}