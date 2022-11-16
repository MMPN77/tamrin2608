using System;
namespace tamrin_1
{
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Enter a Number :");
            int x = Convert.ToInt32(Console.ReadLine());
            
             int a=tavan2(x);
            Console.WriteLine(x+" ^ 2 = "+a);
            
            int b = tavan3(x);
            Console.WriteLine(x+" ^ 3 = "+b);
            Console.WriteLine("Thanks For Watching");
            Console.ReadKey();
        }
         
        static int tavan2(int a)
         {
             int y =Convert.ToInt32( Math.Pow(a , 2));
             return y;
         }
        
        static int tavan3(int a)
         { 
            int z=Convert.ToInt32(Math.Pow(a , 3 ));
            return z;
         }
    }
}
