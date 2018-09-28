using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board3 : Board
    {
        //This board is for the most difficult sudoku puzzle
        public Board3()
        {
            var board = new List<List<int>>
            {
                new List<int> {8,0,0,0,0,0,0,0,0},
                new List<int> {0,0,3,6,0,0,0,0,0},
                new List<int> {0,7,0,0,9,0,2,0,0},
                new List<int> {0,5,0,0,0,7,0,0,0},
                new List<int> {0,0,0,0,4,5,7,0,0},
                new List<int> {0,0,0,1,0,0,0,3,0},
                new List<int> {0,0,1,0,0,0,0,6,8},
                new List<int> {0,0,8,5,0,0,0,1,0},
                new List<int> {0,9,0,0,0,0,4,0,0}
            };

            BoardState = CreateNewBoard(board);


        }
    }
}
