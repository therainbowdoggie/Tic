namespace TicTacToeFunctionality.Extensions
{
    using System.Collections.Generic;

    public static class GameCondition
    {
        /// <summary>
        ///     Gets all possible winning conditions for the game
        /// </summary>
        /// <returns>List containing winning positions</returns>
        public static List<List<int>> GetWinConditions()
        {
            var winningIndices = new List<List<int>>();

            for (var i = 0; i < 5; ++i)
            {
                var horizontal = new List<int>();
                var vertical = new List<int>();

                for (var j = 0; j < 5; ++j)
                {
                    // vertical wins (e.g., 0 1 2 3 4)
                    vertical.Add(i * 5 + j);

                    // horizontal wins (e.g., 0 5 10 15 20)
                    horizontal.Add(j * 5 + i);
                }

                winningIndices.Add(vertical);
                winningIndices.Add(horizontal);
            }

            // diagonal wins
            winningIndices.Add(new List<int> { 0, 6, 12, 18, 24 });
            winningIndices.Add(new List<int> { 4, 8, 12, 16, 20 });

            return winningIndices;
        }
    }
}
