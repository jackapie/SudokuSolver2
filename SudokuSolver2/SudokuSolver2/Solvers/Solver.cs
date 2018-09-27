using SudokuSolver2.BoardFactory;
using SudokuSolver2.SolverBehaviours;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver2.Solvers
{
    public class Solver
    {
        public ISolverBehaviour SolverBehaviour { get; set; }


        public void Display(Board board)
        {
            for (int x = 0; x < 9; x++)
            {
                var row = "";
                for (int y = 0; y < 9; y++)
                {
                    var square = board.BoardState[x][y].ConfirmedValue;
                    var squareString = square.ToString();
                    row = row + squareString + ", ";


                }
                Console.WriteLine(row);

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        public Board Board;

        public void PerformSolve()
        {
            SolverBehaviour.Solve(Board);
        }


        public void GetBoard(int level)
        {
            var BoardFactory = new SudokuBoardFactory();
            Board = BoardFactory.CreateBoard(level);
        }

        public void SolveIt(int level)
        {
            GetBoard(level);

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
        }



    }
}
