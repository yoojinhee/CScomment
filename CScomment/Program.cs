using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CScomment
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.Write("x :");
            x = int.Parse(Console.ReadLine());
            Console.Write("y :");
            y = int.Parse(Console.ReadLine());
            if (x > 4)
            {
                if (y > 2)
                {
                    Console.WriteLine(x * y);
                }
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
