using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2
{
    public interface ISolverBehaviour
    {
        void Solve(Board board);
    }
}
