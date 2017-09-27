namespace TicTacToe.Game
{
    public sealed class TicTacToePlayerOneState : GameState
    {
        public TicTacToePlayerOneState()
        {
            Name = "playerone";
            VisaulSign = "X";
        }

        public override GameState GetNextState()
        {
            return new TicTacToePlayerTwoState();
        }

        public override string Name { get; }
        public override string VisaulSign { get; }
    }

    public sealed class TicTacToePlayerTwoState : GameState
    {
        public TicTacToePlayerTwoState()
        {
            Name = "playertwo";
            VisaulSign = "O";
        }

        public override string Name { get; }
        public override string VisaulSign { get; }

        public override GameState GetNextState()
        {
            return new TicTacToePlayerOneState();
        }
    }

    public class WinState : GameState
    {
        public WinState(GameState currentState)
        {
            Name = "winstate";
            VisaulSign = "W";
            Winner = currentState;
        }

        public GameState Winner { get; }
        public override string Name { get; }
        public override string VisaulSign { get; }
        public override GameState GetNextState()
        {
            return this;
        }
    }
}