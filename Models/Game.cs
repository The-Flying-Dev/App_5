// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

namespace MathsGame.Models
{
    internal class Game
    {
        internal DateTime Date { get; set; }

        internal int Score { get; set; }

        internal GameType Type { get; set; }
    }

    // Enumeration is used when options are limited
    internal enum GameType
    {
        Addition,
        Subtraction,
        Multiplication,
        Division
    }
}
