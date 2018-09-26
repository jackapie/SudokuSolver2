using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class SolveRow : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            for (int x = 0; x < 9; x++)
            {
                var currentRowMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                int NumberOfZeros = 0;
                int whereIsTheZero = -1;
                for (int y = 0; y < 9; y++)
                {
                    int currentSquare = board.BoardState[x][y].ConfirmedValue;
                    if (currentSquare > 0)
                    {
                        currentRowMissing.Remove(currentSquare);
                    }
                    if (currentSquare == 0)
                    {
                        NumberOfZeros++;
                        whereIsTheZero = y;
                    }
                }
                if (NumberOfZeros == 1)
                {
                    var square = board.BoardState[x][whereIsTheZero];
                    square.ConfirmedValue = currentRowMissing[0];
                }
            }
        }
    }
}
