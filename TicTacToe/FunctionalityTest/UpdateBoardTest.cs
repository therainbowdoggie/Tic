namespace FunctionalityTest
{
    using System;
    using System.Collections.ObjectModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TicTacToeFunctionality;
    using TicTacToeFunctionality.Enumerations;
    using TicTacToeFunctionality.Models;

    [TestClass]
    public class UpdateBoardTest
    {
        [TestMethod]
        public void UpdateBoardMethodTest()
        {
            var boardState = new BoardState
            {
                Board = new ObservableCollection<CellStatus>
                {
                    CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected
                }
            };

            var functionality = new Functionality(boardState);

            PrintBoard("Current", functionality.BoardState);

            functionality.UpdateBoard(1, CellStatus.X);

            PrintBoard("After update", functionality.BoardState);
        }

        private static void PrintBoard(string text, BoardState state)
        {
            Console.Write($"{text} board: ");

            foreach (var cell in state.Board)
            {
                Console.Write($"{cell}, ");
            }

            Console.Write("\n");
        }
    }
}
