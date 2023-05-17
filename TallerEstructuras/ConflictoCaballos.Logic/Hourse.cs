using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConflictoCaballos.Logic
{
    public class Hourse
    {
        public string? Data { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public Hourse(string data, int row,int column)
        {
            Data = data;
            Row = row;
            Column = column;
        }
    }
}
