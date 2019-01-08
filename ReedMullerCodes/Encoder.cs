using System;
using System.Collections.Generic;

namespace ReedMullerCodes
{
    public class Encoder
    {
        private readonly int m;
        private readonly int r;

        public Encoder(int m, int r)
        {
            this.m = m;
            this.r = r;
        }

        /// <summary>
        /// Užkoduoja vektorių
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public List<int> EncodeVector(List<int> vector, int[,] matrix)
        {
            double n;
            n = Math.Pow(2, m);
            var encodedVector = new List<int>(vector.Count);
            int rows = m.CountCombination(r);
            int columns = Convert.ToInt32(n);

            for (int i = 0; i < columns; i++)
            {
                int vectorBit = 0;
                for (int j = 0; j < rows; j++)
                {
                    vectorBit += (matrix[j, i] * vector[j]);
                }
                encodedVector.Add(vectorBit % 2);
            }
            return encodedVector;
        }
    }
}
