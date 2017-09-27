namespace TicTacToe.Game
{
    public class TicTacToeBoard : GameBoard
    {

        public TicTacToeBoard() : this(3)
        {
        }

        public TicTacToeBoard(int boardWidth) : base(boardWidth)
        {
        }
    }
}
