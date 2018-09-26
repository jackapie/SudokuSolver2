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
            for (int y = 0; y < 9; y++)
            {
                var currentColumnMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int NumberOfZeros = 0;
                int whereIsTheZero = -1;
                for (int x = 0; x < 9; x++)
                {
                    var currentSquare = board.BoardType[x][y];
                    if (currentSquare > 0)
                    {
                        currentColumnMissing.Remove(currentSquare);
                    }
                    if (currentSquare == 0)
                    {
                        NumberOfZeros++;
                        whereIsTheZero = x;
                    }
                }
                if (NumberOfZeros == 1)
                {
                    board.BoardType[whereIsTheZero][y] = currentColumnMissing[0];
                }
            }
        }
    }
}
