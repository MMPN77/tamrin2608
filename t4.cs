using System;
namespace tamrin_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Enter Number One :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number Two :");
            int y = Convert.ToInt32(Console.ReadLine());
            B(x, y);
            K(x, y);
            Console.WriteLine("Thanks For Watching");
            Console.ReadKey();
        }
        private static void B(int x, int y)
        {
            int i, min, b=1;
            min = x;
            if (min > y)
            {
                min = y;
            }
            for (i = 1; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    b = i;
                }
            }
            Console.WriteLine("B M M : "+b);
        }
        public static void K(int a, int b)
        {
            int max=1;
            int i = a;
            for (; (i % b) != 0; i += a) ;
            max= i;
            Console.WriteLine("K M M : "+max);
            }
        }
    }
