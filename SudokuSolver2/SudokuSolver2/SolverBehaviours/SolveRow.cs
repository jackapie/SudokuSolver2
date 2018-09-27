using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class SolveRow : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            for (int x = 0; x < 9; x++)
            {
                var currentRowMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var currentRowUsed = new List<int> { };
                
                for (int y = 0; y < 9; y++)
                {
                    int currentSquare = board.BoardState[x][y].ConfirmedValue;
                    if (currentSquare > 0)
                    {
                        currentRowMissing.Remove(currentSquare);
                        currentRowUsed.Add(currentSquare);
                    }
                   
                }
               
                // Remove suggestedValues from zero value boardSquares
                for (int y = 0; y < 9; y++)
                {
                    var currentSquare = board.BoardState[x][y];
                    if (currentSquare.ConfirmedValue == 0)
                    {
                       
                        foreach(int value in currentRowUsed)
                        {
                            currentSquare.SuggestedValues.Remove(value);
                        }
                    }

                }




            }
        }
    }
}
