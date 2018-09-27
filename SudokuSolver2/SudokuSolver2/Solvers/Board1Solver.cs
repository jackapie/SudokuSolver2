using SudokuSolver2.BoardFactory;
using SudokuSolver2.SolverBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Solvers
{
    public class Board1Solver : Solver
    {

        public void GetBoard()
        {
            var BoardFactory = new SudokuBoardFactory();
            Board = BoardFactory.CreateBoard(1);
        }


        public void SolveIt() { 
            GetBoard();

            var zeroesLastTime = 0;
            //insert loop
            //while (board contains any zeros) do the following set a solver behaviour and PerformSolve
            while (Board.HowManyZeroes() != zeroesLastTime)
            {
                zeroesLastTime = Board.HowManyZeroes();

                SolverBehaviour = new SolveRow();
                PerformSolve();
                SolverBehaviour = new SolveColumn();
                PerformSolve();
                SolverBehaviour = new SolveBox();
                PerformSolve();
                SolverBehaviour = new SolveSuggestedValue();
                PerformSolve();
                Display(Board);

            }
            //if board does not contain zeros, display board.
           
           
            //Loop over.


        }
    }
}
