using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 f1 = new Class1();
            Console.WriteLine("Nhap n");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; ; i++)
            {
                if (n > f1.Fibonacci(i) & n < f1.Fibonacci(i + 1))
                {
                    Console.WriteLine(f1.Fibonacci(i));
                }
            }



            Console.ReadKey();
        }
    }
}
