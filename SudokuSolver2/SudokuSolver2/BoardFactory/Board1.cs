using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class Board1 : Board
    {
        public Board1()
        {
            var board = new List<List<int>>
            {
                new List<int> {0,5,7,1,0,8,3,4,0},
                new List<int> {3,9,8,2,0,5,1,7,6},
                new List<int> {1,4,6,0,3,0,8,5,2},
                new List<int> {9,2,0,8,0,7,0,6,5},
                new List<int> {0,0,1,0,0,0,2,0,0},
                new List<int> {5,8,0,6,0,2,0,1,3},
                new List<int> {8,3,9,0,7,0,6,2,1},
                new List<int> {6,7,5,3,0,1,9,8,4},
                new List<int> {0,1,2,9,0,6,5,3,0}
            };

            BoardState = CreateNewBoard(board);

            
        }

       
    }
}




