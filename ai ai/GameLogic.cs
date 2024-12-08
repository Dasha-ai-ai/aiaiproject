using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ai_ai
{
    public class GameLogic
    {

        private char[,] board;
        public int col { get ; private set; }
        public int row { get; private set; }
        public char currentPlayer { get; private set; }

        public char lastMovedPlayer { get; private set; }

        public bool gameEndedDraw { get; private set; }
        public bool gameEndedWin { get; private set; }
        public GameLogic()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            gameEndedDraw = false;
            gameEndedWin = false;
        }
        public void ResetGame()
        {
            currentPlayer = 'X';
            board = new char[3, 3];
            gameEndedWin = false;
            gameEndedDraw = false;
        }
        public bool PlayerMove(int row, int col)
        {
            if (board[row, col] != '\0')
            {
                MessageBox.Show("Это поле уже занято");
                return false;
            }

            board[row, col] = currentPlayer;
            lastMovedPlayer = currentPlayer;
            CheckGameEnd();
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            return true;
        }
        public void ComputerMove()
        {
            Random rand = new Random(); 
            do
            {
                row = rand.Next(0, 3); // Выбираем случайную строку и столбец
                col = rand.Next(0, 3);
            } while (board[row, col] != 'X' && board[row, col] != 'O'); // Продолжать случайный выбор, пока не выберется пустая клетка
            board[row, col] = currentPlayer;
            lastMovedPlayer = currentPlayer;
            CheckGameEnd();
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }
        private void CheckGameEnd()
        {
            int countOfFullField = 0;
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if (board[i, j] != '\0') countOfFullField++;
                }
                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer) ||
                    (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                     (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
                {
                    gameEndedWin = true;
                    break;
                }
            }
            if (countOfFullField == 9 && gameEndedWin == false) gameEndedDraw = true;

        }
        

    }

}
