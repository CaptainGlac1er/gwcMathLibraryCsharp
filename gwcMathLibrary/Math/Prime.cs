using gwcDataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace gwcMathLibrary.Math
{
    public class Prime
    {
        SingleLinkedList<Int64> primes = new SingleLinkedList<Int64>();
        public Prime()
        {
            primes.Add(2);
        }
        public Int64[] calcPrimesUpTo(Int64 largestNumber)
        {
            for (Int64 current = primes.getHeadData(); current < largestNumber; current++)
            {
                bool worked = true;
                Int64 maxFactor = (Int64)(System.Math.Sqrt(current) + .5);
                foreach (Int64 i in primes)
                {
                    if (!(worked ^= (current % i == 0))) //changes worked to false if a multiple is found.
                        break;
                    if (i > maxFactor)
                        break;
                }
                if (worked)
                    primes.Add(current);
            }
            return primes.toArray();
        }
        public Int64 calculateNextPrime(Int64 n)
        {
            Int64[] primesUnder = calcPrimesUpTo(n);
            bool notFound = true;
            Int64 current = n;
            for (; notFound; current++)
            {
                foreach (Int64 i in primesUnder)
                    if ((notFound ^= (current % i == 0))) //changes worked to false if a multiple is found.
                        break;
            }
            return current;
        }
        
    }
    
}
