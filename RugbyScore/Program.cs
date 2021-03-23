using System;

namespace RugbyScore
{
    class Program
    {
        static void Main()
        {
            int Score = int.Parse(Console.ReadLine());
            for (int i = 0; i <= Score / 5; i++)
                for (int j = 0; j <= i; j++)
                    if (((Score - 5 * i - 2 * j) % 3 == 0) && (Score - 5 * i - 2 * j) / 3 >= 0)
                        Console.WriteLine($"{i} {j} {(Score - 5 * i - 2 * j) / 3}");
            Console.ReadLine();
        }
    }
}
