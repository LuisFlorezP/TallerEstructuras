using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescomposicionFactores
{
    public class Factores
    {
        public string ResultDecomposition(int number)
        {
            bool first = true;
            var result = string.Empty;
            result += $"{number} = ";
            while (number != 1 || first == true)
            {
                if (number % 2 == 0)
                {
                    number /= 2;
                    if (first)
                    {
                        result += "2 ";
                        first = false;
                        continue;
                    }
                    result += "x 2 ";
                } 
                else if (number % 3 == 0)
                {
                    number /= 3;
                    if (first)
                    {
                        result += "3 ";
                        first = false;
                        continue;
                    }
                    result += "x 3 ";
                }
                else if (number % 4 == 0)
                {
                    number /= 4;
                    if (first)
                    {
                        result += "4 ";
                        first = false;
                        continue;
                    }
                    result += "x 4 ";
                }
                else if (number % 5 == 0)
                {
                    number /= 5;
                    if (first)
                    {
                        result += "5 ";
                        first = false;
                        continue;
                    }
                    result += "x 5 ";
                }
                else if (number % 6 == 0)
                {
                    number /= 6;
                    if (first)
                    {
                        result += "6 ";
                        first = false;
                        continue;
                    }
                    result += "x 6 ";
                }
                else if (number % 7 == 0)
                {
                    number /= 7;
                    if (first)
                    {
                        result += "7 ";
                        first = false;
                        continue;
                    }
                    result += "x 7 ";
                }
                else if (number % 8 == 0)
                {
                    number /= 8;
                    if (first)
                    {
                        result += "8 ";
                        first = false;
                        continue;
                    }
                    result += "x 8 ";
                }
                else if (number % 9 == 0)
                {
                    number /= 9;
                    if (first)
                    {
                        result += "9 ";
                        first = false;
                        continue;
                    }
                    result += "x 9 ";
                }
                else if (number % 10 == 0)
                {
                    number /= 10;
                    if (first)
                    {
                        result += "10 ";
                        first = false;
                        continue;
                    }
                    result += "x 10 ";
                }
                else
                {
                    if (first)
                    {
                        result += $"{number}";
                        first = false;
                        break;
                    }
                    result += $"x {number}";
                    break;
                }
            }
            return result += "\n";
        }
    }
}
