using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ChislatanaFibonachi


{
    public static int Fib(int n)
    {
        int a = 0;
        int b = 1;
        
        for (int i = 0; i < n; i++)
        {
            int tem = a;
            a = b;
            b = tem + b;
        }
        return a;
    }

    static void Main()
    {
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine(Fib(i));
        }
    }
}