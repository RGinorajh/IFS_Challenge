using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x = 29;

            Console.WriteLine(sumPrime(x));
            Console.ReadKey();

        }

        static bool checkprime( int p) {

            if (p == 1)
            {
               return false;
            }

            for (int k = 2; k*k <= p; k++)
            {
                    if (p % k == 0)
                    {
                       return false;
                    }
            }
            return true;

        }

        static int sumPrime(int x)
        {

            int sum = 0;

            for (int k = 2; k <= x; k++)
            {
                bool isprime = checkprime(k);
                if (isprime)
                {
                    sum = sum + k;
                }
            }
            return sum;

        }
        

    }
}
