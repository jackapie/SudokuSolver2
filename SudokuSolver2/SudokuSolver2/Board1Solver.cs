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
            //insert loop
            //while (board contains any zeros) do the following set a solver behaviour and PerformSolve
            while (Board.ContainsZeros() == true)
            {
                SolverBehaviour = new SolveRow();
                PerformSolve(Board);

            }
            //if board contains zeros do next solve behaviour.
            
            //if board does not contain zeros, display board.
            //Loop over.


        }
    }
}
