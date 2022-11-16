using System;
namespace tamrin_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Enter Number One :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number Two :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number Three :");
            int c = Convert.ToInt32(Console.ReadLine());
            //f(x)=ax^2+bx+c
            rishe(a,b,c);
            Console.WriteLine("Thanks For Watching");
            Console.ReadKey();
        }
        private static void rishe(int x, int y,int z)
        {
            double d = Math.Pow(y, 2)-(4*x*z);
            if (d >= 0)
            {
                if (d > 0)
                {
                    double rishe1 =((-y) + Math.Sqrt(d)) / (2 * x);
                    double rishe2 = ((-y) - Math.Sqrt(d)) /(2 * x);
                    Console.WriteLine(rishe1);
                    Console.WriteLine(rishe2);
                }
                else
                {
                    double rishe0 =(-y) / (2 * x);
                    Console.WriteLine(rishe0);
                }
            }
            else
            {
                Console.WriteLine( "Bedoon rishe");  
            } 
        }
    }
}