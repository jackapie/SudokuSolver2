using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class Board
    {
        public List<List<int>> BoardType { get; set; }

        

        public bool ContainsZeros()
        {
            foreach (List<int> i in BoardType)
            {
                foreach (int j in i)
                {
                    if (j == 0) { return true; }
                }
                
            }return false;
        }
    }
}
