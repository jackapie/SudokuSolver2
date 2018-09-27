using SudokuSolver2.BoardFactory;
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


       
           


        }
}
