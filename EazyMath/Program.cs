using System;

namespace EazyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Q q = new Q(Q.R.Next(2) == 1);
            
            while (true)
            {
                Console.Write($"{q.N1} {q.Op} {q.N2} = ");
                
                if (!int.TryParse(Console.ReadLine(), out int i))
                {
                    Console.WriteLine("\n感謝來玩~有緣再會~");
                    return;
                }

                if (q.Check(i))
                {
                    Console.WriteLine("答對囉!!\n");
                    q = new Q(Q.R.Next(2) == 1);
                }

                else Console.WriteLine("答錯囉!!再試試看~\n");
            }
        }
    }
}
