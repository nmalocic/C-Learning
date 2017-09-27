using TicTacToe.Game;
using Xunit;

namespace TicTacToe.Tests
{
    public class ValidMoveTests
    {
        [Fact]
        public void PlayOutSideOfBoard_NotValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            var result = board.IsvalidMove(10);
            Assert.Equal(false, result);
        }

        [Fact]
        public void PlayInSideOfBoard_ValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            var result = board.IsvalidMove(5);
            Assert.Equal(true, result);
        }

        [Fact]
        public void PlayOutSideOfBoardNegativeValue_NotValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            var result = board.IsvalidMove(-4);
            Assert.Equal(false, result);
        }

        [Fact]
        public void LowerEdgeCase_ValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            var result = board.IsvalidMove(0);
            Assert.Equal(true, result);
        }

        [Fact]
        public void UpperEdgeCase_ValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            var result = board.IsvalidMove(8);
            Assert.Equal(true, result);
        }

        [Fact]
        public void PlayOnOccupiedField_NotValidMove()
        {
            GameBoard board = new TicTacToeBoard();
            board.Place(5, "X");
            var result = board.IsvalidMove(5);
            Assert.Equal(false, result);
        }
    }
}
