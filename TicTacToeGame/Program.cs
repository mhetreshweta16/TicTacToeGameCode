using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacGameClass ticTacGame = new TicTacGameClass();
            Console.WriteLine("Welcome To TicTacToeGame");
            ticTacGame.createBoard();
            Console.WriteLine("player and compueter letter for game is: ");
            ticTacGame.chooseLetter();
        }
    }
}
