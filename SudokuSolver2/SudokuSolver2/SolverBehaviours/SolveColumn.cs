using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class SolveColumn : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            for (int y = 0; y < 9; y++)
            {
                var currentColumnMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                var currentColumnUsed = new List<int> { };
                //int NumberOfZeros = 0;
                //int whereIsTheZero = -1;
                for (int x = 0; x < 9; x++)
                {
                    var currentSquare = board.BoardState[x][y].ConfirmedValue;
                    if (currentSquare > 0)
                    {
                        currentColumnMissing.Remove(currentSquare);
                        currentColumnUsed.Add(currentSquare);
                    }
                   
                }
                for (int x = 0; x < 9; x++)
                {
                    var currentSquare = board.BoardState[x][y];
                    if (currentSquare.ConfirmedValue == 0)
                    {

                        foreach (int value in currentColumnUsed)
                        {
                            currentSquare.SuggestedValues.Remove(value);
                        }
                    }
                }
               
            }
        }
    }
}
