using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gwcMathLibrary;
namespace MathLibraryCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            testVectorProduct();
            //testMatrixMultiplication();
            Console.Read();
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
            Vector vector1 = new Vector(5, -5, 3);
            Vector vector2 = new Vector(1, -6.5, 5);

            Console.WriteLine(vector1.crossProduct(vector2));
        }
    }
}
