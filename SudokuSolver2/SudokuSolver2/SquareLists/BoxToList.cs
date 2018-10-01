using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SquareLists
{
    public class BoxToList : IComponentToList
    {
        public List<List<BoardSquare>> SquareToList(Board board)
        {
            var listOfBoxLists = new List<List<BoardSquare>>();
            for (int X = 0; X < 3; X++)
            {
                for (int Y = 0; Y < 3; Y++)
                {
                    var boxList = new List<BoardSquare>();
                    for (int x = X * 3; x < (X * 3) + 3; x++)
                    {
                        
                        for (int y = Y * 3; y < (Y * 3) + 3; y++)
                        {
                            var currentSquare = board.BoardState[x][y];
                            boxList.Add(currentSquare);
                        }
                        
                    }
                    listOfBoxLists.Add(boxList);
                }
            }
            return listOfBoxLists;
        }
    }
}
