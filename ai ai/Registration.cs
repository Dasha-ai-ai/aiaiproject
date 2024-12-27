using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_ai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            var user = new
            {
                UserName = UserName.Text,
                Password = Password.Text,
                Email = Email.Text,
                Wins = 0,
                Losses = 0,
                Draws = 0
            };
            string json = JsonSerializer.Serialize(user);
            File.AppendAllText("userData.json", json + Environment.NewLine);
            MessageBox.Show("Пользователь сохранен");
        }
    }
    }

