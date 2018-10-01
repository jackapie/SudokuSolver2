using SudokuSolver2.BoardFactory;
using SudokuSolver2.SquareLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class Similar2s : ISolverBehaviour
    {
        IComponentToList ComponentToList { get; set; }

        void SolveSimilar2s(List<List<BoardSquare>> board)
        {
            foreach (List<BoardSquare> component in board)
            {
                for (int y = 0; y < 9; y++)
                {
                    var firstSquare = component[y];

                    if (firstSquare.ConfirmedValue == 0
                        && firstSquare.SuggestedValues.Count == 2)
                    {
                        for (int y2 = y + 1; y2 < 9; y2++)
                        {
                            var secondSquare = component[y2];

                            if (secondSquare.ConfirmedValue == 0
                                && firstSquare.SuggestedValues.SequenceEqual(secondSquare.SuggestedValues)
                                )
                            {
                                for (int y3 = 0; y3 < 9; y3++)
                                {
                                    var thirdSquare = component[y3];
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

        public void Solve(Board board)
        {
            ComponentToList = new RowToList();
            var squareLists = ComponentToList.SquareToList(board);
            SolveSimilar2s(squareLists);
            ComponentToList = new ColumnToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveSimilar2s(squareLists);
            ComponentToList = new BoxToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveSimilar2s(squareLists);
        }
    }
}
