using GameLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_ai
{
    public partial class PlayerVersusPlayer : Form
    {
        private GameLogic gameLogic = new GameLogic();
        public PlayerVersusPlayer()
        {
            InitializeComponent();
            labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
        }

        private void button0_0_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(0, 0))
                {
                    button0_0.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button0_1_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(0, 1))
                {
                    button0_1.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button0_2_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(0, 2))
                {
                    button0_2.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button1_0_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(1, 0))
                {
                    button1_0.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button1_1_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(1, 1))
                {
                    button1_1.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(1, 2))
                {
                    button1_2.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button2_0_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(2, 0))
                {
                    button2_0.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(2, 1))
                {
                    button2_1.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void button2_2_Click(object sender, EventArgs e)
        {
            if (!(gameLogic.gameEndedDraw || gameLogic.gameEndedWin))
            {
                if (gameLogic.PlayerMove(2, 2))
                {
                    button2_2.Text = gameLogic.lastMovedPlayer.ToString();
                    labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
                    if (gameLogic.gameEndedWin)
                    {
                        MessageBox.Show($"Игрок {gameLogic.lastMovedPlayer} победил!");
                        labelCurrentPlayer.Text = $"Победа {gameLogic.lastMovedPlayer}";
                    }
                    if (gameLogic.gameEndedDraw)
                    {
                        MessageBox.Show("Игра закончилась ничьей");
                        labelCurrentPlayer.Text = "Ничья";
                    }
                }
            }
            else
            {
                MessageBox.Show("Игра завершена!");
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameLogic.ResetGame();
            foreach (Control control in this.Controls)
            {
                if (control is Button)
                {
                    control.Text = string.Empty;
                }
            }
            labelCurrentPlayer.Text = "Ход игрока " + gameLogic.currentPlayer;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Игроки по очереди ставят на свободные клетки поля 3×3 знаки" +
                " (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или большой диагонали, выигрывает. " +
                "Если игроки заполнили все 9 ячеек и оказалось, что ни в одной вертикали, горизонтали или большой диагонали нет трёх одинаковых знаков, партия считается закончившейся вничью. " +
                "Первый ход делает игрок, ставящий крестики.");
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
