using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board2 : Board
    {
        //A puzzle from Brainium Sudoku app, rated "Easy"
        public Board2()
        {
            var board = new List<List<int>>
            {
                new List<int> {4,0,3,1,0,0,7,0,0},
                new List<int> {0,0,0,0,4,0,0,0,0},
                new List<int> {5,0,0,3,0,0,9,0,1},
                new List<int> {3,0,8,0,6,1,0,0,0},
                new List<int> {0,1,0,5,0,3,0,7,0},
                new List<int> {0,0,0,4,2,0,1,0,5},
                new List<int> {6,0,9,0,0,5,0,0,4},
                new List<int> {0,0,0,0,1,0,0,0,0},
                new List<int> {0,0,5,0,0,7,8,0,9}
            };

            BoardState = CreateNewBoard(board);


        }

    }
}
