using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
   public class TicTacGameClass
    {

        public void createBoard()
        {
            char[] board = new char[10];
            board[1]=' ';
            board[2] = ' ';
            board[3] = ' ';
            board[4] = ' ';
            board[5] = ' ';
            board[6] = ' ';
            board[7] = ' ';
            board[8] = ' ';
            board[9] = ' ';

        }
        public void chooseLetter()
        {
            Console.WriteLine("hello player,enter your letter for game");
            char playerletter =Convert.ToChar(Console.ReadLine());
            char compuetLetter=' ';

            if (playerletter == 'x')
            {
                compuetLetter = 'o';
            }
            else if (playerletter == 'o')
            {
                compuetLetter = 'x';
            }
            else
            {
                Console.WriteLine("enter valid letter");
            }

            Console.WriteLine("the Player letter is " + playerletter);

            
            Console.WriteLine("the computer letter is " + compuetLetter);

        }
    }
}
