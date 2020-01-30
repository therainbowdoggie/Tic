namespace TicTacToe.Views
{
    using System.Windows;
    using System.Windows.Controls;
    using TicTacToeFunctionality;
    using TicTacToeFunctionality.Enumerations;
    using ViewModels;

    /// <summary>
    ///     Interaction logic for Board.xaml
    /// </summary>
    public partial class Board
    {
        private Functionality Functionality { get; }
        private BoardViewModel ViewModel { get; set; }

        /// <summary>
        ///     Creates an instance of Board class
        /// </summary>
        public Board()
        {
            InitializeComponent();

            ViewModel = new BoardViewModel();

            Functionality = new Functionality(ViewModel.State);

            DataContext = ViewModel;
        }

        /// <summary>
        ///     Restarts the game
        /// </summary>
        private void RestartGame()
        {
            ViewModel = new BoardViewModel();

            Functionality.ResetGame(ViewModel.State);

            DataContext = ViewModel;
        }

        /// <summary>
        ///     Handles the board after the cell was clicked
        /// </summary>
        /// <param name="sender">The button</param>
        /// <param name="e">Args for the event</param>
        private void OnClicked(object sender, RoutedEventArgs e)
        {
            var button = (Button) sender;
            var index = int.Parse(button.Uid);

            if (Functionality.BoardState.Board[index] == CellStatus.Unselected)
            {
                Functionality.UpdateBoard(index, ViewModel.State.Turn);
                Functionality.SwapTurn();
            }
            else
            {
                MessageBox.Show("This cell has already been selected!");
            }

            if (Functionality.TryRestartGame(out var text))
            {
                MessageBox.Show($"{text} Restarting!");

                RestartGame();
            }
        }
    }
}
