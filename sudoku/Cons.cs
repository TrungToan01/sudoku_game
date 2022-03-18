using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku
{

    class Cons: Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            this.Text = string.Empty;
            this.IsLocked = false;
        }



        public static int Chess_width = 65;
        public static int Chess_height = 65;
        public static int Board_col = 9;
        public static int Board_cow = 9;
    }
}
