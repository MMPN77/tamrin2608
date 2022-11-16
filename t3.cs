using System;
namespace tamrin_3
{
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Enter Your First Balance Of Account  :");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Banks Profit(Percent/yearly) :");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Selected Value :");
            int v = Convert.ToInt32(Console.ReadLine());

             int i=0;
             while(f<v)
             {
             f = f+(f * p / 100);
             i++;
             }

            Console.WriteLine("Required Time : " + i+" years");
            Console.WriteLine("Thanks For Watching");
            Console.ReadKey();
         }
    }
}
