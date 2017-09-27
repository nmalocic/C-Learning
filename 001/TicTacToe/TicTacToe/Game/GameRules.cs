using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe.Game
{
    public abstract class GameRules
    {
        protected List<Func<GameBoard, bool>> WinRules;
        protected List<Func<GameBoard, bool>> DrawRules;

        protected GameRules()
        {   
        }

        protected GameRules(List<Func<GameBoard, bool>> winRules, List<Func<GameBoard, bool>> drawRules)
        {
            WinRules = winRules;
            DrawRules = drawRules;
        }

        public bool IsWinningMove(GameBoard board)
        {
            return WinRules.Any(rule => rule(board));
        }

        public bool IsDrawMove(GameBoard board)
        {
            return DrawRules.Any(rule => rule(board));
        }
    }
}