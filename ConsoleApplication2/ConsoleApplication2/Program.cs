using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0;
            int B = 100;
            int count = 1;
            string a;
            while(B > A + 1)
            {
                int C = (A + B) / 2;
                Console.Write("Q{0}: Is your number less than {1}?", count, C);
                a = Console.ReadLine();
                if (a == "Y")
                    B = C + 1;
                if (a == "N")
                    A = C;
                count++;
            }
        }
    }
}
