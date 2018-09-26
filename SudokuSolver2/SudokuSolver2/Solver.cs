﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public abstract class Solver
    {
        public ISolverBehaviour SolverBehaviour { get; set; }


        public void Display(Board board)
        {
            for (int x = 0; x < 9; x++)
            {
                var row = new List<string>();
                for (int y = 0; y < 9; y++)
                {
                    var square = board.BoardState[x][y].ConfirmedValue;
                    var squareString = square.ToString();
                    row.Add(squareString);
                    row.Add(", ");

                }
                Console.WriteLine(row);
            }

        }

        public Board Board;

        public void PerformSolve(Board boardName)
        {
            SolverBehaviour.Solve(Board);
        }



    }
}
