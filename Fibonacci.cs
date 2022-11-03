using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Fibonacci
    {
        public void Series()
        {
            int n1 = 0, n2 = 1, n3, num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 + "" + n2 + "");
            for (int i = 0; i < num; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3 + "");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
