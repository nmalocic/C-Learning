using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Game
{
    public class TicTacToeRules : GameRules
    {
        public TicTacToeRules()
        {
            WinRules = new List<Func<GameBoard, bool>>
            {
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[0] == null || board[1] == null || board[2] == null) return false;
                    return board[0].Equals(board[1]) && board[0].Equals(board[2]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[3] == null || board[4] == null || board[5] == null) return false;
                    return board[3].Equals(board[4]) && board[3].Equals(board[5]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[6] == null || board[7] == null || board[8] == null) return false;
                    return board[6].Equals(board[7]) && board[6].Equals(board[8]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[0] == null || board[3] == null || board[6] == null) return false;
                    return board[0].Equals(board[3]) && board[0].Equals(board[6]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[1] == null || board[4] == null || board[7] == null) return false;
                    return board[1].Equals(board[4]) && board[1].Equals(board[7]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[2] == null || board[5] == null || board[8] == null) return false;
                    return board[2].Equals(board[5]) && board[2].Equals(board[8]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[0] == null || board[4] == null || board[8] == null) return false;
                    return board[0].Equals(board[4]) && board[0].Equals(board[8]);
                },
                (gameBoard) =>
                {
                    var board = gameBoard.GetState();

                    if (board[2] == null || board[4] == null || board[6] == null) return false;
                    return board[2].Equals(board[4]) && board[2].Equals(board[6]);
                }
            };

            DrawRules = new List<Func<GameBoard, bool>>
            {
                (gameBoard) =>
                {
                    return gameBoard.GetState().Count(x => x != null) == 9;
                }
            };
        }

        public TicTacToeRules(List<Func<GameBoard, bool>> winRules, List<Func<GameBoard, bool>> drawRules) : base(winRules, drawRules)
        {
        }
    }
}
