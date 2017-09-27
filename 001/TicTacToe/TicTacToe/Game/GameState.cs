namespace TicTacToe.Game
{
    public abstract class GameState
    {
        public abstract string Name { get; }
        public abstract string VisaulSign { get; }

        public abstract GameState GetNextState();
    }
}