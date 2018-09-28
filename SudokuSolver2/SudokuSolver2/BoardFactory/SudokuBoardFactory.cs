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
            if (level == 3)
            {
                return new Board3();
            }
            if (level == 4)
            {
                return new Board4();
            }
            if (level == 5)
            {
                return new Board5();
            }

            else return null;
        }

        
    }
}
