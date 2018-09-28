using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board4 : Board
    {
        //A puzzle from Brainium Sudoku app, rated "Expert"
        public Board4()
        {
            var board = new List<List<int>>
            {
                new List<int> {0,0,0,0,3,0,0,1,0},
                new List<int> {0,0,0,9,0,0,0,0,0},
                new List<int> {4,0,0,0,0,8,7,0,0},
                new List<int> {0,2,0,0,1,0,0,0,0},
                new List<int> {0,0,3,0,0,7,0,0,5},
                new List<int> {6,0,0,4,0,0,9,0,0},
                new List<int> {0,0,1,0,0,0,0,0,2},
                new List<int> {0,9,0,0,0,6,0,3,0},
                new List<int> {8,0,0,5,0,0,4,0,0}
            };

            BoardState = CreateNewBoard(board);

            
        }

       
    }
}




