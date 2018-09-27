using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
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
            var currentSquareMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var currentSquareUsed = new List<int> { };
            //int NumberOfZeros = 0;
            //int whereIsTheZeroY = -1;
            //int whereIsTheZeroX = -1;
            for (int x = 3 * X; x < (3 * X + 3); x++)
            {
                for (int y = 3 * Y; y < (3 * Y + 3); y++)
                {
                    var currentSquare = board.BoardState[x][y].ConfirmedValue;
                    if (currentSquare > 0)
                    {
                        currentSquareMissing.Remove(currentSquare);
                        currentSquareUsed.Add(currentSquare);
                    }
                    //if (currentSquare == 0)
                    //{
                    //    whereIsTheZeroY = y;
                    //    whereIsTheZeroX = x;
                    //    NumberOfZeros++;
                    //}
                }
                for (int y = 0; y < 9; y++)
                {
                    var currentSquare = board.BoardState[x][y];
                    if (currentSquare.ConfirmedValue == 0)
                    {

                        foreach (int value in currentSquareUsed)
                        {
                            currentSquare.SuggestedValues.Remove(value);
                        }
                    }

                }
            }
            // Remove suggestedValues from zero value boardSquares

            //if (NumberOfZeros == 1)
            //{
            //    var square = board.BoardState[whereIsTheZeroX][whereIsTheZeroY];
            //    square.ConfirmedValue = currentSquareMissing[0];
            //}
        }
    }
}
