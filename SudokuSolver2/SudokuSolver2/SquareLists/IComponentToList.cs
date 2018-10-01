using SudokuSolver2.BoardFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.SquareLists
{
    public interface IComponentToList
    {
        List<List<BoardSquare>> SquareToList(Board board);
    }
}
