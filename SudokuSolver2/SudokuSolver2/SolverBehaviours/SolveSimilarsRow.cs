using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class SolveSimilarsRow : ISolverBehaviour
    {
        //This solver will compare suggestedValues lists. 
        //If there are two lists with 2 ints that are the same (a, b) and a third containing the same
        //two ints, plus one more int (c), the third square has the confirmed value of that extra int (c)
        public void Solve(Board board)
        {
            //For rows
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    var firstSquare = board.BoardState[x][y];

                    if (firstSquare.ConfirmedValue == 0
                        && firstSquare.SuggestedValues.Count == 2)
                    {
                        for (int y2 = y + 1; y2 < 9; y2++)
                        {
                            var secondSquare = board.BoardState[x][y2];

                            if (secondSquare.ConfirmedValue == 0
                                && firstSquare.SuggestedValues.SequenceEqual(secondSquare.SuggestedValues)
                                )
                            {
                                for (int y3 = 0; y3 < 9; y3++)
                                {
                                    var thirdSquare = board.BoardState[x][y3];
                                    if (thirdSquare != firstSquare && thirdSquare != secondSquare && thirdSquare.ConfirmedValue == 0)
                                    {
                                        thirdSquare.SuggestedValues.Remove(firstSquare.SuggestedValues[0]);
                                        thirdSquare.SuggestedValues.Remove(firstSquare.SuggestedValues[1]);
                                    }
                                }
                            }
                        }
                    }

                }

            }
        }


    }
}

