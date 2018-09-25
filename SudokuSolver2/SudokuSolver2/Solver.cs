using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public abstract class Solver
    {
        public ISolverBehaviour SolverBehaviour { get; set; }


        public void Display()
        {
            Console.WriteLine("Show the solved puzzle on the screen");
        }

        public Board Board;

        public void PerformSolve(Board boardName)
        {
            SolverBehaviour.Solve(Board);
        }



    }
}
