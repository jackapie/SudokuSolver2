using SudokuSolver2.BoardFactory;
using SudokuSolver2.SquareLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class Similar3s : ISolverBehaviour
    {
        IComponentToList ComponentToList { get; set; }

        bool EqualList(List<int> a, List<int> b)
        {
            if ((a[0] == b[0] && a[1] == b[1]) || (a[0] == b[1] && a[1] == b[2])
                || (a[0] == b[0] && a[1] == b[2]))
            {
                return true;
            }
            return false;
        }



        void SolveSimilar3s(List<List<BoardSquare>> board)
        {
            foreach (List<BoardSquare> component in board)
            {
                for (int y = 0; y < 9; y++)
                {
                    var firstSquare = component[y];
                    var firstSV = firstSquare.SuggestedValues;
                    var firstCV = firstSquare.ConfirmedValue;

                    if (firstCV == 0
                        && firstSV.Count == 3)
                    {
                        for (int y2 = y + 1; y2 < 9; y2++)
                        {
                            var secondSquare = component[y2];
                            var secondSV = secondSquare.SuggestedValues;
                            var secondCV = secondSquare.ConfirmedValue;
                            if (secondCV == 0
                                && secondSV.Count == 3
                                && secondSV.SequenceEqual(firstSV))
                            {
                                for (int y3 = 0; y3 < 9; y3++)
                                {
                                    var thirdSquare = component[y3];
                                    var thirdSV = thirdSquare.SuggestedValues;
                                    var thirdCV = thirdSquare.ConfirmedValue;

                                    if ((thirdSquare != firstSquare && thirdSquare != secondSquare)
                                        && (thirdCV == 0)
                                        && ((thirdSV.Count == 3 && thirdSV.SequenceEqual(firstSV))
                                        || thirdSV.Count == 2 && EqualList(thirdSV, firstSV)))
                                    {
                                        for (int y4 = 0; y4 < 9; y4++)
                                        {
                                            var fourthSquare = component[y4];
                                            var fourthCV = fourthSquare.ConfirmedValue;
                                            var fourthSV = fourthSquare.SuggestedValues;

                                            if (fourthSquare != firstSquare && fourthSquare != secondSquare 
                                                && fourthSquare != thirdSquare && fourthCV == 0)
                                            {
                                                fourthSV.Remove(firstSV[0]);
                                                fourthSV.Remove(firstSV[1]);
                                                fourthSV.Remove(firstSV[2]);
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

        public void Solve(Board board)
        {
            ComponentToList = new RowToList();
            var squareLists = ComponentToList.SquareToList(board);
            SolveSimilar3s(squareLists);
            ComponentToList = new ColumnToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveSimilar3s(squareLists);
            ComponentToList = new BoxToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveSimilar3s(squareLists);
        }
    }
}
