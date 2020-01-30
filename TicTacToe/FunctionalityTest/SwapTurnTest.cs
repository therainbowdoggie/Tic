namespace FunctionalityTest
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TicTacToeFunctionality;
    using TicTacToeFunctionality.Enumerations;
    using TicTacToeFunctionality.Models;

    [TestClass]
    public class SwapTurnTest
    {
        [TestMethod]
        public void SwapTurnMethodTest()
        {
            var currentBoardState = new BoardState
            {
                Turn = CellStatus.O
            };

            var functionality = new Functionality(currentBoardState);

            PrintTurn("Current", functionality.BoardState);

            functionality.SwapTurn();

            PrintTurn("After turn", functionality.BoardState);
        }

        private static void PrintTurn(string text, BoardState state)
        {
            Console.WriteLine($"{text} turn: {state.Turn}");
        }
    }
}
