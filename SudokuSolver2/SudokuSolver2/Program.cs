using SudokuSolver2.Solvers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    class Program
    {
        static void Main(string[] args)
        {
            var solve = new Solver();
            solve.SolveIt(3);
        }
    }
}
