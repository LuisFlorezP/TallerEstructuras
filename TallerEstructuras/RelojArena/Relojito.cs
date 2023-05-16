using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelojArena
{
    public class Relojito
    {
        public int N { get; set; }
        public int[,] Matrix { get; set; }

        public Relojito(int n)
        {
            N = n;
            Matrix = Fill();
        }

        private int[,] Fill()
        {
            var matrix = new int[N, N];
            int number = 0, dataDouble = 2;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = number;
                    number++;
                }
                number = dataDouble;
                dataDouble += 2;
            }
            return matrix;
        }

        public string Reloj()
        {
            var matrix = new string[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = Convert.ToString(Matrix[i, j]);
                }
            }
            for (int i = 0, j = N - 1; i < ((N - 1) / 2) + 1; i++, j--)
            {
                for (int m = 0, k = N - 1, l = 0; l < i; l++, m++, k--)
                {
                    matrix[i, m] = " ";
                    matrix[i, k] = " ";
                    matrix[j, m] = " ";
                    matrix[j, k] = " ";
                }
            }
            return Print(matrix);
        }

        private string Print(string[,] matrix)
        {
            var output = string.Empty;
            output += "RELOJ DE ARENA\n";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += matrix[i, j] + "\t";
                }
                output += "\n";
            }
            return output;
        }

        public override string ToString()
        {
            var output = string.Empty;
            output += "MATRIZ COMPLETA\n";
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    output += Matrix[i, j] + "\t";
                }
                output += "\n";
            }
            return output;
        }
    }
}
