
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SudokuSolver
{
    public class ColorSubset
    {
        public static void ApplyBackgroundColorToGivenSet(List<TextBox> group, Color color)
        {
            foreach (var single in group)
            {
                single.BackColor = color;
            }
        }
    }
}
