using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class SudokuBoardFactory
    {
       

        public Board CreateBoard(int level)
        {
            if (level == 1) {
                return new Board1();
            }
            if (level == 2)
            {
                return new Board2();
            }

            else return null;
        }

        
    }
}
