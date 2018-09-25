using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class SolveColumn : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    var currentSquare = board.BoardType[x][y];
                }
            }
        }
    }
}
