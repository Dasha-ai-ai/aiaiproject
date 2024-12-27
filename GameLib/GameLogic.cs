namespace GameLib
{
    public enum GameStatus
    {
        Running,
        Win,
        Draw
    }
    public class GameLogic
    {
        private char[,] board;
        public int col { get; private set; }
        public int row { get; private set; }
        public char currentPlayer { get; private set; }

        public char lastMovedPlayer { get; private set; }

        public GameStatus Status { get; private set; }
        public bool gameEndedDraw { get; private set; }
        public bool gameEndedWin { get; private set; }

        public GameLogic()
        {
            board = new char[3, 3];
            currentPlayer = 'X';
            Status = GameStatus.Running;
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
            row = rand.Next(0, 3);
            col = rand.Next(0, 3);
            while (board[row, col] == 'X' || board[row, col] == 'O')
            {
                row = rand.Next(0, 3);
                col = rand.Next(0, 3);
            }
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
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != '\0') countOfFullField++;
                }
                if ((board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer) ||
                    (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer) ||
                    (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                     (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
                {
                    Status = GameStatus.Win;
                    break;
                }
            }
            if (countOfFullField == 9 && Status!= GameStatus.Win) Status = GameStatus.Draw;

        }



    }
}
