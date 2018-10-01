using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SquareLists
{
    public class RowToList : IComponentToList
    {
        public List<List<BoardSquare>> SquareToList(Board board)
        {
            var ListOfRowLists = new List<List<BoardSquare>>();
            for (int x = 0; x < 9; x++)
            {
                var RowList = new List<BoardSquare>();
                
                for (int y = 0; y < 9; y++)
                {
                    var currentSquare = board.BoardState[x][y];
                    RowList.Add(currentSquare);
                }

                ListOfRowLists.Add(RowList);
            }
            return ListOfRowLists;
        }
       
    }
}
