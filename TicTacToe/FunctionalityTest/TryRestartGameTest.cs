namespace FunctionalityTest
{
    using System;
    using System.Collections.ObjectModel;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TicTacToeFunctionality;
    using TicTacToeFunctionality.Enumerations;
    using TicTacToeFunctionality.Models;

    [TestClass]
    public class TryRestartGameTest
    {
        [TestMethod]
        public void TryRestartGameMethodTest()
        {
            var boardState = new BoardState
            {
                Board = new ObservableCollection<CellStatus>
                {
                    CellStatus.X, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                    CellStatus.Unselected, CellStatus.X, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                    CellStatus.Unselected, CellStatus.Unselected, CellStatus.X, CellStatus.Unselected, CellStatus.Unselected,
                    CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.X, CellStatus.Unselected,
                    CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.X
                }
            };

            var functionality = new Functionality(boardState);

            Console.WriteLine(functionality.TryRestartGame(out var text) ? text : "Cannot restart game because it has not ended yet");
        }
    }
}
