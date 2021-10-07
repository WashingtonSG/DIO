using System;

namespace DigitalInnovationOne
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b=2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a+b+c+d);
        }
        static void InstrucaoIf(string[] args)
        {
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if (args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }
        static void InstrucaoSwitch(string[] args)
        {
            int numeroDeArgumentos = args.Length;
            switch(numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                default:
                    Console.WriteLine($"{numeroDeArgumentos} argumentos");
                    break;
            }
        }
        static void Main(string[] args)
        {
            int numeroDeVezes = 5;
            for(int i = 0; i < numeroDeVezes; i++)
            {
                Console.WriteLine($"Bem-vindo ao curso de .NET {i}");
            }
        }
    }
}
