namespace TicTacToe.ViewModels
{
    using System.Collections.ObjectModel;
    using TicTacToeFunctionality.Enumerations;
    using TicTacToeFunctionality.Models;

    public class BoardViewModel
    {
        public BoardState State { get; } = new BoardState
        {
            Turn = CellStatus.O,

            Board = new ObservableCollection<CellStatus> 
            {
                CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected,
                CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected, CellStatus.Unselected
            }
        };
    }
}
