using System;
namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Desafio1();
        }

        private static void Desafio1()
        {
            int a = 1, b = 1, c = 1, d = 1, e = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n * 2; i++)
            {
                Console.WriteLine($"{a} {b} {c}");
                if (i % 2 == 0)
                {
                    a += 1;
                    b += 2 * d;
                    d += 1;
                    c = b * a;
                    e += 1;
                }
                else
                {
                    b += 1;
                    c = b * a - e;
                }
            }
        }
    }
}