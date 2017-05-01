using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gwcMathLibrary;
using System.Diagnostics;

namespace MathLibraryCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //testVectorProduct();
            //testMatrixMultiplication();
            testPrimes();
            Console.Read();
        }
        public static void testPrimes()
        {
            gwcMathLibrary.Math.Prime primeGenerator = new gwcMathLibrary.Math.Prime();

            /*foreach(Int64 i in primeGenerator.calcPrimesUpTo(100000000))
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(primeGenerator.calculateNextPrime(234));*/
            Stopwatch test = new Stopwatch();
            test.Start();
            primeGenerator.calcPrimesUpTo(1000000);
            test.Stop();
            Console.WriteLine(test.Elapsed.TotalMilliseconds);

        }
        public static void testMatrixMultiplication()
        {
            Random random = new Random();
            double[,] test = new double[2,3];
            for (int x = 0; x < test.GetLength(0); x++)
            {
                for (int y = 0; y < test.GetLength(1); y++)
                {
                    test[x,y] = random.Next(-5,5);
                }
            }
            double[,] test1 = new double[3,5];
            for (int x = 0; x < test1.GetLength(0); x++)
            {
                for (int y = 0; y < test1.GetLength(1); y++)
                {
                    test1[x,y] = random.Next(-5, 5);
                }
            }
            Matrix matrix1 = new Matrix(test);
            matrix1.printMatrix();
            Console.WriteLine("\r\n\r\n");

            Matrix matrix2 = new Matrix(test1);
            matrix2.printMatrix();

            Console.WriteLine("\r\n\r\n");
            //matrix1.add(matrix2).printMatrix();
            (matrix1 * matrix2).printMatrix();
        }
        public static void testVectorProduct()
        {
            int cnt = 1;
            Vector vector1 = new Vector(0, 0, .6 * Math.Pow(10,-3));
            Vector vector2 = new Vector(2, 2, 0);

            Console.WriteLine(vector1.crossProduct(vector2));
        }
    }
}
