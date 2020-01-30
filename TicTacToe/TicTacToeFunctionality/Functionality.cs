namespace TicTacToeFunctionality
{
    using System.Collections.Generic;
    using System.Linq;
    using Enumerations;
    using Extensions;
    using Models;

    public class Functionality
    {
        public BoardState BoardState { get; private set; }
        private static List<List<int>> WinPossibilities { get; }

        static Functionality()
        {
            WinPossibilities = GameCondition.GetWinConditions();
        }

        public Functionality(BoardState boardState)
        {
            BoardState = boardState;
        }

        /// <summary>
        ///     Resets the game
        /// </summary>
        /// <param name="state">Clear board state</param>
        public void ResetGame(BoardState state)
        {
            BoardState = state;
        }

        /// <summary>
        ///     Swaps turn
        /// </summary>
        public void SwapTurn()
        {
            BoardState.Turn = BoardState.Turn == CellStatus.O ? CellStatus.X : CellStatus.O;
        }

        /// <summary>
        ///     Updates the board
        /// </summary>
        /// <param name="index">Cell ID</param>
        /// <param name="player">Player</param>
        public void UpdateBoard(int index, CellStatus player)
        {
            BoardState.Board[index] = player;
        }

        /// <summary>
        ///     Checks whether the game ended
        /// </summary>
        /// <param name="text">The announcement about the game result</param>
        /// <returns>True when any party won or game was a draw</returns>
        public bool TryRestartGame(out string text)
        {
            var teams = new[]
            {
                CellStatus.O, CellStatus.X
            };

            var winningTeam = teams.FirstOrDefault(
                team => WinPossibilities.Any(condition => condition.All(index => BoardState.Board[index] == team)));

            if (winningTeam != default)
            {
                text = $"Game ended in {winningTeam} winning...";

                return true;
            }

            if (BoardState.Board.All(value => value != CellStatus.Unselected))
            {
                text = "Game ended in a draw...";

                return true;
            }

            text = null;

            return false;
        }
    }
}
