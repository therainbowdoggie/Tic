namespace TicTacToeFunctionality.Models
{
    using System.Collections.ObjectModel;
    using Enumerations;

    public class BoardState
    {
        public CellStatus Turn { get; set; }
        public ObservableCollection<CellStatus> Board { get; set; }
    }
}
