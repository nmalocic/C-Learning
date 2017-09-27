
using TicTacToe.Game;
using Xunit;

namespace TicTacToe.Tests
{
    public class GameOverTests
    {
        [Fact]
        public void EmptyBoard_GameIsNotOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();

            var result = rules.IsWinningMove(board);

            Assert.Equal(false, result);
        }

        [Fact]
        public void FirstLine_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(1, "X");
            board.Place(2, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(true, result);
        }

        [Fact]
        public void FirstLine_NotFull_GameNotOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(2, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(false, result);
        }

        [Fact]
        public void SecondLine_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(3, "X");
            board.Place(4, "X");
            board.Place(5, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(true, result);
        }

        [Fact]
        public void ThirdLine_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(6, "X");
            board.Place(7, "X");
            board.Place(8, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(true, result);
        }

        [Fact]
        public void FirstColumn_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(3, "X");
            board.Place(6, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(true, result);
        }

        [Fact]
        public void FirstColumn_NotFull_GameIsNotOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(2, "X");
            board.Place(6, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(false, result);
        }

        [Fact]
        public void SecondColumn_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(1, "X");
            board.Place(4, "X");
            board.Place(7, "X");

            var result = rules.IsWinningMove(board);
            Assert.Equal(true, result);
        }

        [Fact]
        public void ThirdColumn_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(2, "X");
            board.Place(5, "X");
            board.Place(8, "X");

            var result = rules.IsWinningMove(board);
            Assert.Equal(true, result);
        }

        [Fact]
        public void LeftDiagonal_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(4, "X");
            board.Place(8, "X");

            var result = rules.IsWinningMove(board);

            Assert.Equal(true, result);
        }

        [Fact]
        public void RightDiagonal_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(2, "X");
            board.Place(4, "X");
            board.Place(6, "X");

            var result = rules.IsWinningMove(board);
            Assert.Equal(true, result);
        }

        [Fact]
        public void BoradFull_GameIsOver()
        {
            GameRules rules = new TicTacToeRules();
            GameBoard board = new TicTacToeBoard();
            board.Place(0, "X");
            board.Place(1, "X");
            board.Place(2, "0");
            board.Place(3, "0");
            board.Place(4, "0");
            board.Place(5, "X");
            board.Place(6, "X");
            board.Place(7, "X");
            board.Place(8, "0");

            var result = rules.IsDrawMove(board);
            Assert.Equal(true, result);
        }
    }
}