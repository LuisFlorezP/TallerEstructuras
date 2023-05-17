using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConflictoCaballos.Logic
{
    public class Conflicto
    {
        public static string? Hourses { get; set; }
        public static string[,]? Board { get; set; }

        public Conflicto(string? hourses)
        {
            Hourses = hourses;
            Board = new string[8,8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Board[i, j] = " ";
                }
            }
        }

        public string ConflictHourse()
        {
            var output = string.Empty;
            List<Hourse> listHourses = FillBoardWithHourses();

            for (int i = 0; i < Hourses.Length; i += 3)
            {
                var hourse = Hourses.Substring(i, 2);
                output += $"\nAnalyzing Horse in {hourse[1]}{hourse[0]} => ";

                bool exist = false;
                Hourse data = listHourses.Find(x => x.Data.Contains(hourse));
                if (data == null)
                {
                    exist = true;
                }
                if (exist)
                {
                    continue;
                }
                int rowHourse = data.Row;
                int columnHourse = data.Column;
                if ((rowHourse - 2 >= 0 && rowHourse - 2 < 8) && (columnHourse - 1 >= 0 && columnHourse - 1 < 8))
                {
                    if (!(Board[rowHourse - 2, columnHourse - 1].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse - 2, columnHourse - 1][1]}{Board[rowHourse - 2, columnHourse - 1][0]}\t";
                    }
                }
                if ((rowHourse - 2 >= 0 && rowHourse - 2 < 8) && (columnHourse + 1 >= 0 && columnHourse + 1 < 8))
                {
                    if (!(Board[rowHourse - 2, columnHourse + 1].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse - 2, columnHourse + 1][1]}{Board[rowHourse - 2, columnHourse + 1][0]}\t";
                    }
                }
                if ((rowHourse - 1 >= 0 && rowHourse - 1 < 8) && (columnHourse - 2 >= 0 && columnHourse - 2 < 8))
                {
                    if (!(Board[rowHourse - 1, columnHourse - 2].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse - 1, columnHourse - 2][1]}{Board[rowHourse - 1, columnHourse - 2][0]}\t";
                    }
                }
                if ((rowHourse + 1 >= 0 && rowHourse + 1 < 8) && (columnHourse - 2 >= 0 && columnHourse - 2 < 8))
                {
                    if (!(Board[rowHourse + 1, columnHourse - 2].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse + 1, columnHourse - 2][1]}{Board[rowHourse + 1, columnHourse - 2][0]}\t";
                    }
                }
                if ((rowHourse - 1 >= 0 && rowHourse - 1 < 8) && (columnHourse + 2 >= 0 && columnHourse + 2 < 8))
                {
                    if (!(Board[rowHourse - 1, columnHourse + 2].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse - 1, columnHourse + 2][1]}{Board[rowHourse - 1, columnHourse + 2][0]}\t";
                    }
                }
                if ((rowHourse + 1 >= 0 && rowHourse + 1 < 8) && (columnHourse + 2 >= 0 && columnHourse + 2 < 8))
                {
                    if (!(Board[rowHourse + 1, columnHourse + 2].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse + 1, columnHourse + 2][1]}{Board[rowHourse + 1, columnHourse + 2][0]}\t";
                    }
                }
                if ((rowHourse + 2 >= 0 && rowHourse + 2 < 8) && (columnHourse - 1 >= 0 && columnHourse - 1 < 8))
                {
                    if (!(Board[rowHourse + 2, columnHourse - 1].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse + 2, columnHourse - 1][1]}{Board[rowHourse + 2, columnHourse - 1][0]}\t";
                    }
                }
                if ((rowHourse + 2 >= 0 && rowHourse + 2 < 8) && (columnHourse + 1 >= 0 && columnHourse + 1 < 8))
                {
                    if ((!Board[rowHourse + 2, columnHourse + 1].Equals(" ")))
                    {
                        output += $"Conflict with {Board[rowHourse + 2, columnHourse + 1][1]}{Board[rowHourse + 2, columnHourse + 1][0]}\t";
                    }
                }
            }

            return output + "\n";
        }

        public static List<Hourse> FillBoardWithHourses()
        {
            var listHourses = new List<Hourse>();

            for (int i = 0; i < Hourses.Length; i += 3)
            {
                var hourse = Hourses.Substring(i, 2);

                int row = PositionRow(hourse[1]);
                int column = PositionColumn(hourse[0]);

                Board[row, column] = hourse;
                Hourse data = new Hourse(hourse, row, column);
                listHourses.Add(data);
            } 

            return listHourses;
        }

        private static int PositionRow(object data)
        {
            return data switch
            {
                '8' => 0,
                '7' => 1,
                '6' => 2,
                '5' => 3,
                '4' => 4,
                '3' => 5,
                '2' => 6,
                '1' => 7,
                _ => throw new Exception("Hourse address are invalid."),
            };
        }

        private static int PositionColumn(object data)
        {
            return data switch
            {
                'A' => 0,
                'B' => 1,
                'C' => 2,
                'D' => 3,
                'E' => 4,
                'F' => 5,
                'G' => 6,
                'H' => 7,
                _ => throw new Exception("Hourse address are invalid."),
            };
        }
    }
}
