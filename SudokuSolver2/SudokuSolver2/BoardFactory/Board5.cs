using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board5 : Board
    {
        //A puzzle from Brainium Sudoku app, rated "Hard"
        public Board5()
        {
            var board = new List<List<int>>
            {
                new List<int> {1,0,0,0,2,0,0,0,0},
                new List<int> {0,6,9,0,0,0,0,0,0},
                new List<int> {0,3,0,0,5,6,0,0,0},
                new List<int> {0,0,0,0,0,5,0,0,2},
                new List<int> {4,0,6,0,0,9,8,0,0},
                new List<int> {0,0,8,6,3,0,5,0,9},
                new List<int> {0,0,0,0,4,1,0,9,0},
                new List<int> {0,0,0,0,0,0,3,0,1},
                new List<int> {0,0,0,5,0,2,0,8,7}
            };

            BoardState = CreateNewBoard(board);

            
        }

       
    }
}




