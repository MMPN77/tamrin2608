using System;
namespace tamrin_2
{
    class Program
    {
         static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Please Enter Days Of Your Births Day To Now :");
            int x = Convert.ToInt32(Console.ReadLine());
            
            int y = Convert.ToInt32(x / 365);
            int k = Convert.ToInt32(y / 4);
            int m = Convert.ToInt32((x - (365 * y))-k);
             int mn;
             int d;
            if (m > 186)
            {
                if (m > 336 )
                {
                    mn = Convert.ToInt32(((m-336) / 29)+11);
                     d = Convert.ToInt32((m -336)- ((mn - 11) * 29));
                    
                }
                else
                {
                     mn = Convert.ToInt32(((m-186)/30)+6);
                      d = Convert.ToInt32((m -186) -((mn-6) * 30)+1);
                }
            }
            else
            {
                 mn = Convert.ToInt32(m / 31);
                  d = Convert.ToInt32(m - (mn * 31)+1);       
           }
            Console.WriteLine("Your Age is: ");
            Console.WriteLine(y+" years & "+mn+" months & "+d+" days");
            Console.WriteLine("Thanks For Watching");
            Console.ReadKey();
         }
    }
}
