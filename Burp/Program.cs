using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burp
{
    class Program
    {
        static void Main(string[] args)
        {
            int rem = 0;
            int Remainder(int x, int y)
            {
                rem = x % y;
                return rem;
            }
            Remainder(3, 4);
            Console.WriteLine("Remainder is " + rem);
            Console.ReadLine();
            
        }
    }
}
