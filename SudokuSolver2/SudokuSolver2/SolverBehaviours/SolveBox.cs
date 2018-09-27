using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class SolveBox : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            for (int X = 0; X < 3; X++)
            {
                for (int Y = 0; Y < 3; Y++)
                {
                    SolveBoxXY(board, X, Y);
                }

            }

        }


        private static void SolveBoxXY(Board board, int X, int Y)
        {
            var currentBoxMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var currentBoxUsed = new List<int> { };

            for (int x = 3 * X; x < (3 * X + 3); x++)
            {
                for (int y = 3 * Y; y < (3 * Y + 3); y++)
                {
                    var currentSquare = board.BoardState[x][y].ConfirmedValue;
                    if (currentSquare > 0)
                    {
                        currentBoxMissing.Remove(currentSquare);
                        currentBoxUsed.Add(currentSquare);
                    }
                }
            }

            for (int x = 3 * X; x < (3 * X + 3); x++)
            {
                for (int y = 3 * Y; y < (3 * Y + 3); y++)
                {
                    var currentSquare = board.BoardState[x][y];
                    if (currentSquare.ConfirmedValue == 0)
                    {
                        foreach (int value in currentBoxUsed)
                        {
                            currentSquare.SuggestedValues.Remove(value);
                        }
                    }
                }
            }
        }
    }
}
