using System;

namespace ReferenceTypeValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;
            Console.Write("a: ");
            int a =Int32.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b =Int32.Parse(Console.ReadLine());
            Console.Write("c: ");
           int c =Int32.Parse(Console.ReadLine());
           d=b*b-4*a*c;
           if(d > 0 || d == 0)
           {
               Console.Write("d: ");
           Console.WriteLine($"x1={(-b+Math.Sqrt(d))/2/a}");
           Console.WriteLine($"x2={(-b-Math.Sqrt(d))/2/a}");
           }

        


    

            
        }
    }
}
