namespace TicTacToe.Game
{
    public abstract class Game
    {
        protected GameState CurrentState;
        protected GameRules Rules;
        protected Game(GameState currentState, GameBoard board, GameRules rules)
        {
            CurrentState = currentState;
            Board = board;
            Rules = rules;
        }

        public GameBoard Board { get; }
        public GameState State => CurrentState;
        

        public abstract void Move(int position);
    }


}