﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.BoardFactory
{
    public class BoardSquare
    {
        public int ConfirmedValue { get; set; }
        public List<int> SuggestedValues { get; set; }
    }
}
