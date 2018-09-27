﻿using SudokuSolver2.BoardFactory;
using SudokuSolver2.SolverBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Solvers
{
    public class Board2Solver : Solver
    {

        public void GetBoard()
        {
            var BoardFactory = new SudokuBoardFactory();
            Board = BoardFactory.CreateBoard(2);
        }


        public void DoAThing() { 
            GetBoard();

            var zeroesLastTime = 0;
            //insert loop
            //while (board contains any zeros) do the following set a solver behaviour and PerformSolve
            while (Board.HowManyZeroes() != zeroesLastTime)
            {
                zeroesLastTime = Board.HowManyZeroes();

                SolverBehaviour = new SolveRow();
                PerformSolve(Board);
                SolverBehaviour = new SolveColumn();
                PerformSolve(Board);
                SolverBehaviour = new SolveBox();
                PerformSolve(Board);
                SolverBehaviour = new SolveSuggestedValue();
                PerformSolve(Board);
                Display(Board);

            }
            //if board does not contain zeros, display board.
           
           
            //Loop over.


        }
    }
}
