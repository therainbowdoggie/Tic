namespace FunctionalityTest
{
    using System;
    using System.Collections.ObjectModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TicTacToeFunctionality;
    using TicTacToeFunctionality.Enumerations;
    using TicTacToeFunctionality.Models;

    [TestClass]
    public class ResetGameTest
    {
        [TestMethod]
        public void ResetGameMethodTest()
        {
            var emptyState = new BoardState
            {
                Board = new ObservableCollection<CellStatus>
                {
                    CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected
                }
            };

            var boardState = new BoardState
            {
                Turn = CellStatus.X,

                Board = new ObservableCollection<CellStatus>
                {
                    CellStatus.O, CellStatus.X, CellStatus.Unselected
                }
            };

            var functionality = new Functionality(boardState);

            PrintState("Current", functionality.BoardState);

            functionality.ResetGame(emptyState);

            PrintState("After reset", functionality.BoardState);
        }

        private static void PrintState(string text, BoardState state)
        {
            Console.WriteLine($"{text} turn: {state.Turn}");

            Console.Write($"{text} board: ");

            foreach (var cell in state.Board)
            {
                Console.Write($"{cell}, ");
            }

            Console.Write("\n");
        }
    }
}
