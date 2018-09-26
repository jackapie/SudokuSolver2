using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public class Board1Solver : Solver
    {

        public void GetBoard()
        {
            var BoardFactory = new SudokuBoardFactory();
            Board = BoardFactory.CreateBoard(1);
        }

        public Board1Solver()
        {

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

            }
            //if board does not contain zeros, display board.
            Display(Board);
           
            //Loop over.


        }
    }
}
