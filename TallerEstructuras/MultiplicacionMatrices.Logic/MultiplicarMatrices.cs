using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicacionMatrices.Logic
{
    public class MultiplicarMatrices
    {
        private int M { get; set; }
        private int N { get; set; }
        private int P { get; set; }
        private double[,] A { get; set; }
        private double[,] B { get; set; }

        public MultiplicarMatrices() { }

        public MultiplicarMatrices(int m, int n, int p)
        {
            // ************************ CÓDIGO FUNCIONAMIENTO ************************
            M = m;
            N = n;
            P = p;
            A = Fill(m, n, true);
            B = Fill(n, p, true);
            // ************************ PRUEBA ENUNCIADO ************************
            //M = 3;
            //N = 4;
            //P = 2;
            //A = new double[3, 4];
            //A[0, 0] = 0;
            //A[0, 1] = 1;
            //A[0, 2] = 2;
            //A[0, 3] = 3;
            //A[1, 0] = 0;
            //A[1, 1] = 2;
            //A[1, 2] = 4;
            //A[1, 3] = 6;
            //A[2, 0] = 0;
            //A[2, 1] = 3;
            //A[2, 2] = 6;
            //A[2, 3] = 9;
            //B = new double[4, 2];
            //B[0, 0] = 0;
            //B[0, 1] = 0;
            //B[1, 0] = 1;
            //B[1, 1] = 2;
            //B[2, 0] = 2;
            //B[2, 1] = 4;
            //B[3, 0] = 3;
            //B[3, 1] = 6;
        }

        public string Process()
        {
            var matrix = Fill(M, P, false);
            double result = 0;
            int m = 0, n = 0, p = 0;
            while (m < M)
            {
                while (p < P)
                {
                    while (n < N)
                    {
                        result += (A[m, n] * B[n, p]);
                        n++;
                    }
                    matrix[m, p] = result;
                    result = 0;
                    n = 0;
                    p++;
                }
                p = 0;
                m++;
            }
            var output = string.Empty;
            output += "*** A ***\n";
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += A[i, j] + "\t";
                }
                output += "\n";
            }
            output += "*** B ***\n";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    output += B[i, j] + "\t";
                }
                output += "\n";
            }
            output += "*** C ***\n";
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < P; j++)
                {
                    output += matrix[i, j] + "\t";
                }
                output += "\n";
            }
            return output;
        }

        public static double[,] Fill(int x, int y, bool fill)
        {
            var matrix = new double[x, y];
            if (fill)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        var random = new Random();
                        matrix[i, j] = random.Next(10);
                    }
                }
            }
            else
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
