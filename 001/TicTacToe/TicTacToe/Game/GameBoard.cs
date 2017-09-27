namespace TicTacToe.Game
{
    public abstract class GameBoard
    {
        private readonly int _numberOfFields;
        private readonly string[] _board;

        protected GameBoard(int boardWidth)
        {
            _numberOfFields = boardWidth * boardWidth;
            _board = new string[_numberOfFields];
        }

        public bool IsvalidMove(int field)
        {
            return IsInsideBoard(field) && IsNotOccupied(field);
        }

        private bool IsNotOccupied(int field)
        {
            return _board[field] == null;
        }

        private bool IsInsideBoard(int field)
        {
            return field > -1 && field < _numberOfFields;
        }

        public void Place(int field, string play)
        {
            _board[field] = play;
        }

        public string[] GetState()
        {
            return _board;
        }
    }
}