namespace TicTacToe.Game
{
    public class TicTacToeGame : Game
    {
        public TicTacToeGame() : this(new TicTacToePlayerOneState(), new TicTacToeBoard(), new TicTacToeRules())
        {
            
        }

        public TicTacToeGame(GameState currentState, GameBoard board, GameRules rules) : base(currentState, board, rules)
        {
        }

        public override void Move(int position)
        {
            if (!Board.IsvalidMove(position)) return;
            Board.GetState()[position] = CurrentState.VisaulSign;
            if (Rules.IsWinningMove(Board))
            {
                CurrentState = new WinState(CurrentState);
            }
            else if (Rules.IsDrawMove(Board))
            {
                CurrentState = new DrawState();
            }
            else
            {
                CurrentState = CurrentState.GetNextState();
            }

        }
    }

    public class DrawState : GameState
    {
        public DrawState()
        {
            Name = "drawstate";
            VisaulSign = null;
        }

        public override string Name { get; }
        public override string VisaulSign { get; }
        public override GameState GetNextState()
        {
            return this;
        }
    }
}