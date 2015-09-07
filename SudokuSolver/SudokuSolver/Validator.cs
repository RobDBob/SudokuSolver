using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace SudokuSolver
{
    class Validator
    {
        public bool ValidateSubset(IEnumerable<TextBox> subSetToValidate)
        {
            foreach(var item in subSetToValidate)
            {
                if( subSetToValidate.Count(x => x.Text.Equals("1")) > 1)
                {

                }
            }
            return false;
        }

        public void ValidateSet(IEnumerable<List<TextBox>> setToValidate)
        {
            foreach (var subSet in setToValidate)
            {
                if( !ValidateSubset(subSet))
                {
                    ColorSubset.ApplyBackgroundColorToGivenSet(subSet, Color.Pink);
                }
            }
        }
    }
}
