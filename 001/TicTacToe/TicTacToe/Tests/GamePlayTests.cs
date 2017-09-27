using System.Linq;
using TicTacToe.Game;
using Xunit;

namespace TicTacToe.Tests
{
    public class GamePlayTests
    {
        [Fact]
        public void GameStarted_InInitialState()
        {
            Game.Game game = new TicTacToeGame();

            var state = game.State;

            Assert.Equal("playerone", state.Name);
        }

        [Fact]
        public void PlayerOne_MakesMove_ReturnsPlayerTwoState()
        {
            Game.Game game = new TicTacToeGame();
            game.Move(4);
            var state = game.State;

            Assert.Equal("playertwo", state.Name);
        }

        [Fact]
        public void PlayerOne_MakesMove_MoveIsPlacedOnBoard()
        {
            Game.Game game = new TicTacToeGame();
            game.Move(4);

            var board = game.Board;

            Assert.Equal("X", board.GetState()[4]);
        }

        [Fact]
        public void FourPlays_BoardHasForItems()
        {
            Game.Game game = new TicTacToeGame();

            game.Move(3);
            game.Move(5);
            game.Move(0);
            game.Move(4);

            var state = game.State;
            Assert.Equal("playerone", state.Name);

            var itemsOnBoard = game.Board.GetState().Count(x => x != null);

            Assert.Equal(4, itemsOnBoard);
        }

        [Fact]
        public void InvalidPlay_KeepsTheState()
        {
            Game.Game game = new TicTacToeGame();

            game.Move(2);
            game.Move(2);
            game.Move(-3);
            game.Move(154);

            var stateName = game.State.Name;
            Assert.Equal("playertwo", stateName);
        }

        [Fact]
        public void WinMove_ReturnsWinState()
        {
            Game.Game game = new TicTacToeGame();

            game.Move(0);
            game.Move(5);
            game.Move(1);
            game.Move(4);
            game.Move(2);

            var stateName = game.State.Name;
            Assert.Equal("winstate", stateName);
        }

        [Fact]
        public void WinState_Neverchanges()
        {
            Game.Game game = new TicTacToeGame();

            game.Move(0);
            game.Move(5);
            game.Move(1);
            game.Move(4);
            game.Move(2);

            var stateName = game.State.Name;
            Assert.Equal("winstate", stateName);

            game.Move(4);

            stateName = game.State.Name;
            Assert.Equal("winstate", stateName);
        }

        [Fact]
        public void DrawMove_ReturnsDrawState()
        {
            Game.Game game = new TicTacToeGame();

            game.Move(0);
            game.Move(2);
            game.Move(1);
            game.Move(3);
            game.Move(5);
            game.Move(4);
            game.Move(6);
            game.Move(7);
            game.Move(8);

            var stateName = game.State.Name;
            Assert.Equal("drawstate", stateName);
        }
    }
}
