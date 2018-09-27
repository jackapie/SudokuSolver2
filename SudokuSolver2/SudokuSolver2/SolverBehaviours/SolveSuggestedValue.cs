using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SolverBehaviours
{
    public class SolveSuggestedValue : ISolverBehaviour
    {
        public void Solve(Board board)
        {
            
            var boardState = board.BoardState;
            foreach (var row in boardState)
            {
                foreach(var square in row)
                {
                    if(square.SuggestedValues != null && square.SuggestedValues.Count == 1)
                    {
                        square.ConfirmedValue = square.SuggestedValues[0];
                        square.SuggestedValues = null;
                    }
                }
            }
        }
    }
}
