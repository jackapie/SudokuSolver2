using SudokuSolver2.BoardFactory;
using SudokuSolver2.SquareLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class MissingNumbers : ISolverBehaviour
    {
        IComponentToList ComponentToList { get; set; }
                             
        void SolveMissingNumbers(List<List<BoardSquare>> listOfComponents)
        {
            foreach (List<BoardSquare> component in listOfComponents)
            {
                FindMissingInComponent(component);
            }
        }

        void FindMissingInComponent(List<BoardSquare> component)
        {
            var currentComponentMissing = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var currentComponentUsed = new List<int> { };

            foreach (BoardSquare square in component)
            {
                var confirmedValue = square.ConfirmedValue;
                if (confirmedValue > 0)
                {
                    currentComponentMissing.Remove(confirmedValue);
                    currentComponentUsed.Add(confirmedValue);
                }
            }

            foreach (BoardSquare square in component)
            {
                if (square.ConfirmedValue == 0)
                {
                    foreach (var value in currentComponentUsed)
                    {
                        square.SuggestedValues.Remove(value);
                    }
                }
            }
        }

        public void Solve(Board board)
        {
            ComponentToList = new RowToList();
            var squareLists = ComponentToList.SquareToList(board);
            SolveMissingNumbers(squareLists);
            ComponentToList = new ColumnToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveMissingNumbers(squareLists);
            ComponentToList = new BoxToList();
            squareLists = ComponentToList.SquareToList(board);
            SolveMissingNumbers(squareLists);

        }
    }
}
