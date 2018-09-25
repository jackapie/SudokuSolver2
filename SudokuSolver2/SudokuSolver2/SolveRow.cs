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
                var currentRowMissing = new List<int>{ 1,2,3,4,5,6,7,8,9 };
                int NumberOfZeros = 0;
                int whereIsTheZero = -1;
                for (int y = 0; y < 9; y++)
                {
                    int currentSquare = board.BoardType[x][y];
                    if (currentSquare > 0)
                    {
                        currentRowMissing.Remove(currentSquare);
                    }
                    if(currentSquare == 0) ///&& (currentRowMissing.Count == 1))
                    {
                        NumberOfZeros++;
                        whereIsTheZero = y;
                        //currentSquare = currentRowMissing[0];
                    }
                    if(y == 8 && NumberOfZeros == 1)
                    {
                        board.BoardType[x][whereIsTheZero] = currentRowMissing[0];
                    }




                }
            }
        }
    }
}
