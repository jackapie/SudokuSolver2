using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board
    {
        public List<List<BoardSquare>> BoardState { get; set; }

        public BoardSquare CreateBoardSquare(int value)
        {
            // if the value in the list is a 0, return a boardSquare with a suggested values list
            if (value == 0)
            {
                var zero = new BoardSquare();
                zero.SuggestedValues = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                return zero;
            }
            //if the value in the list is greater than 0, return a boardSquare with a confirmed value equal to that in the list
            if (value > 0)
            {
                var nonZero = new BoardSquare();
                nonZero.ConfirmedValue = value;
                return nonZero;
            }
            return null;
        }

        public List<BoardSquare> CreateBoardRow(List<int> values)
        {
            var row = new List<BoardSquare>();
            //take a list of ints and for each one, create a BoardSquare.
            foreach (int value in values)
            {

                var boardSquare = CreateBoardSquare(value);
                //put the boardsquare in the row list.
                row.Add(boardSquare);
            }
            return row;


        }

        public List<List<BoardSquare>> CreateNewBoard(List<List<int>> rows)
        {
            var newBoard = new List<List<BoardSquare>>();
            foreach (var row in rows)
            {
                var boardRow = CreateBoardRow(row);
                newBoard.Add(boardRow);
            }
            return newBoard;
        }

        public int HowManyZeroes()
        {
            var zeros = 0;
            foreach (var i in BoardState)
            {
                foreach (var boardSquare in i)
                {
                    if (boardSquare.ConfirmedValue == 0) { zeros++; }
                }

            }

            return zeros;
        }

    }
}
