﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class SudokuBoardFactory
    {
       

        public Board CreateBoard(int level)
        {
            if (level == 1) {
                return new Board1();
            }

            else return null;
        }

        
    }
}
