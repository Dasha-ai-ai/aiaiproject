namespace ai_ai
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            {
                PlayerVersusComputer newForm = new();
                newForm.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerVersusPlayer newForm = new();
            newForm.Show();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            Form1 regForm = new Form1();
            regForm.ShowDialog();
        }
    }
}
