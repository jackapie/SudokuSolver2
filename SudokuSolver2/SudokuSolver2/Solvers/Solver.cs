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
        ISolverBehaviour SolverBehaviour { get; set; }


        void DisplayFinalState()
        {
            for (int x = 0; x < 9; x++)
            {
                var row = "";
                for (int y = 0; y < 9; y++)
                {
                    var square = Board.BoardState[x][y].ConfirmedValue;
                    var squareString = square.ToString();
                    row = row + squareString + ", ";


                }
                Console.WriteLine(row);

            }
            Console.WriteLine();
            Console.ReadLine();
        }

        Board Board;

        void PerformSolve()
        {
            SolverBehaviour.Solve(Board);
        }


        void GetBoard(int level)
        {
            var BoardFactory = new SudokuBoardFactory();
            Board = BoardFactory.CreateBoard(level);
        }

        public void SolveIt(int level)
        {
            GetBoard(level);

            var totalSuggestionsLastTime = 0;
            //insert loop
            //while (board contains any zeros) do the following set a solver behaviour and PerformSolve
            while (Board.GetTotalSuggestions() != totalSuggestionsLastTime)
            {
                totalSuggestionsLastTime = Board.GetTotalSuggestions();
                             
                SolverBehaviour = new MissingNumbers();
                PerformSolve();
                SolverBehaviour = new SolveSuggestedValue();
                PerformSolve();
               
                SolverBehaviour = new Similar2s();
                PerformSolve();
                SolverBehaviour = new Similar3s();
                PerformSolve();
                DisplayFinalState();

            }
            DisplaySuggestedValuesLeft();
        }

        void DisplaySuggestedValuesLeft()
        {
            for (int x = 0; x < 9; x++)
            {
                var row = "";
                for (int y = 0; y < 9; y++)
                {
                    var square = Board.BoardState[x][y];
                    if (square.ConfirmedValue == 0)
                    {
                        var suggestedList = "";
                        foreach (var value in square.SuggestedValues)
                        {

                            var suggestedValue = value.ToString();
                            
                            suggestedList = suggestedList + suggestedValue;
                            
                        }
                        row = row + suggestedList + ",";
                    }
                    if(square.ConfirmedValue > 0)
                    {
                        var confirmedValue = square.ConfirmedValue.ToString();
                        row = row + confirmedValue + ",";
                    }


                }

                Console.WriteLine(row);

            }
            Console.WriteLine();
            Console.ReadLine();
        }



    }
}
