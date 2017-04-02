using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gwcMathLibrary
{
    public class Vector
    {
        protected double[] unitVectors;
        public Vector(double i, double j, double k)
        {
            unitVectors = new double[3];
            unitVectors[0] = i;
            unitVectors[1] = j;
            unitVectors[2] = k;
        }
        public Vector(double[] unitVectors)
        {
            this.unitVectors = unitVectors;
        }
        public double[] getUnitVectors()
        {
            return unitVectors;
        }
        public int getDimensions()
        {
            return unitVectors.Length;
        }
        public double getMagnitude()
        {
            double add = 0;
            foreach (double uv in unitVectors)
                add += Math.Pow(uv, 2);
            return Math.Sqrt(add);
        }
        public override String ToString()
        {
            String output = "";
            foreach (double d in unitVectors)
                output += d + " ";
            return output;
        }
        public Vector crossProduct(Vector secondVector)
        {
            return crossProduct(new Vector[] { this, secondVector });
        }
        private Vector crossProduct(Vector[] vectors)
        {
            double[] output;
            if (vectors.GetLength(0) > 1)
            {
                output = new double[vectors[0].getDimensions()];
                bool shouldNeg = false;
                for (int i = 0; i < vectors.GetLength(0) + 1; i++)
                {
                    double[,] subArray = new double[vectors.GetLength(0),vectors.GetLength(0)];
                    int shift = 0;
                    for (int j = 0; j < vectors.Length + 1; j++)
                    {
                        if (j == i) shift = 1;
                        else
                            for (int k = 0; k < vectors.GetLength(0); k++)
                                subArray[j - shift,k] = vectors[k].getUnitVectors()[j];
                    }
                    output[i] = Matrix.determinant(subArray) * ((shouldNeg) ? -1 : 1);
                    shouldNeg = !shouldNeg;
                }
                return new Vector(output);
            }
            else if (vectors.GetLength(0) == 1)
            {
                return vectors[0];
            }
            else
                return null;
        }
    }
}
