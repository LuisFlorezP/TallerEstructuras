using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosechandoCaballo
{
    public class Cosecha
    {
        public string? Locations { get; set; }
        public string? PositionHourse { get; set; }
        public string? Indications { get; set; }
        public int LocationLength { get; set; }
        public int PositionHoursLength { get; set; }
        public int IndicationLength { get; set; }

        public Cosecha(string? locations, string? positionHourse, string? indications)
        {
            Locations = locations;
            PositionHourse = positionHourse;
            Indications = indications;
            LocationLength = locations.Length;
            PositionHoursLength = positionHourse.Length;
            IndicationLength = indications.Length;
        }

        public string ResultHarverst()
        {
            var board = new char[8, 8];
            var frutos = string.Empty;

            for (int i = 0; i < LocationLength; i += 4)
            {
                var fruit = Locations.Substring(i, 3);

                int row = PositionRow(fruit[1], "Fruit");
                int column = PositionColumn(fruit[0], "Fruit");

                if (fruit[2] != '+' && fruit[2] != '-' && fruit[2] != '*' && fruit[2] != '=')
                {
                    throw new Exception("Fruit address are invalid.");
                }

                board[row, column] = fruit[2];
            }

            int rowHourse = PositionRow(PositionHourse[1], "Hourse");
            int columnHourse = PositionColumn(PositionHourse[0], "Hourse");
            int newPositionHourseRow, newPositionHourseColumn;
            for (int i = 0; i < IndicationLength; i += 3)
            {
                var indication = Indications.Substring(i, 2);

                if (indication.Equals("UL"))
                {
                    newPositionHourseRow = rowHourse - 2;
                    newPositionHourseColumn = columnHourse - 1;
                }
                else if (indication.Equals("UR"))
                {
                    newPositionHourseRow = rowHourse - 2;
                    newPositionHourseColumn = columnHourse + 1;
                }
                else if (indication.Equals("LU"))
                {
                    newPositionHourseRow = rowHourse - 1;
                    newPositionHourseColumn = columnHourse - 2;
                }
                else if (indication.Equals("LD"))
                {
                    newPositionHourseRow = rowHourse + 1;
                    newPositionHourseColumn = columnHourse - 2;
                }
                else if (indication.Equals("RU"))
                {
                    newPositionHourseRow = rowHourse - 1;
                    newPositionHourseColumn = columnHourse + 2;
                }
                else if (indication.Equals("RD"))
                {
                    newPositionHourseRow = rowHourse + 1;
                    newPositionHourseColumn = columnHourse + 2;
                }
                else if (indication.Equals("DL"))
                {
                    newPositionHourseRow = rowHourse + 2;
                    newPositionHourseColumn = columnHourse - 1;
                }
                else if (indication.Equals("DR"))
                {
                    newPositionHourseRow = rowHourse + 2;
                    newPositionHourseColumn = columnHourse + 1;
                }
                else
                {
                    throw new Exception("The indications are not valid.");
                }

                if ((board[newPositionHourseRow, newPositionHourseColumn] == '+') 
                    || (board[newPositionHourseRow, newPositionHourseColumn] == '-') 
                    || (board[newPositionHourseRow, newPositionHourseColumn] == '*') 
                    || (board[newPositionHourseRow, newPositionHourseColumn] == '='))
                {
                    frutos += $"{board[newPositionHourseRow, newPositionHourseColumn]} ";
                }

                rowHourse = newPositionHourseRow;
                columnHourse = newPositionHourseColumn;
            }

            return frutos;
        }

        private static int PositionRow(char? data, string? type)
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
                _ => throw new Exception($"{type} address are invalid."),
            };
        }

        private static int PositionColumn(char? data, string? type)
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
                _ => throw new Exception($"{type} address are invalid."),
            };
        }
    }
}
