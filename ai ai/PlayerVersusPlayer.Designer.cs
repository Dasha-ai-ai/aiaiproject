namespace ai_ai
{
    partial class PlayerVersusPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2_2 = new Button();
            button2_1 = new Button();
            button2_0 = new Button();
            button1_2 = new Button();
            button1_1 = new Button();
            button1_0 = new Button();
            button0_2 = new Button();
            button0_1 = new Button();
            button0_0 = new Button();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            labelCurrentPlayer = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button2_2
            // 
            button2_2.Location = new Point(170, 194);
            button2_2.Name = "button2_2";
            button2_2.Size = new Size(53, 43);
            button2_2.TabIndex = 17;
            button2_2.UseVisualStyleBackColor = true;
            button2_2.Click += button2_2_Click;
            // 
            // button2_1
            // 
            button2_1.Location = new Point(89, 194);
            button2_1.Name = "button2_1";
            button2_1.Size = new Size(53, 43);
            button2_1.TabIndex = 16;
            button2_1.UseVisualStyleBackColor = true;
            button2_1.Click += button2_1_Click;
            // 
            // button2_0
            // 
            button2_0.Location = new Point(8, 194);
            button2_0.Name = "button2_0";
            button2_0.Size = new Size(53, 43);
            button2_0.TabIndex = 15;
            button2_0.UseVisualStyleBackColor = true;
            button2_0.Click += button2_0_Click;
            // 
            // button1_2
            // 
            button1_2.Location = new Point(170, 118);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(53, 43);
            button1_2.TabIndex = 14;
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // button1_1
            // 
            button1_1.Location = new Point(89, 118);
            button1_1.Name = "button1_1";
            button1_1.Size = new Size(53, 43);
            button1_1.TabIndex = 13;
            button1_1.UseVisualStyleBackColor = true;
            button1_1.Click += button1_1_Click;
            // 
            // button1_0
            // 
            button1_0.Location = new Point(8, 118);
            button1_0.Name = "button1_0";
            button1_0.Size = new Size(53, 43);
            button1_0.TabIndex = 12;
            button1_0.UseVisualStyleBackColor = true;
            button1_0.Click += button1_0_Click;
            // 
            // button0_2
            // 
            button0_2.Location = new Point(170, 42);
            button0_2.Name = "button0_2";
            button0_2.Size = new Size(53, 43);
            button0_2.TabIndex = 11;
            button0_2.UseVisualStyleBackColor = true;
            button0_2.Click += button0_2_Click;
            // 
            // button0_1
            // 
            button0_1.BackColor = SystemColors.ButtonHighlight;
            button0_1.Location = new Point(89, 42);
            button0_1.Name = "button0_1";
            button0_1.Size = new Size(53, 43);
            button0_1.TabIndex = 10;
            button0_1.UseVisualStyleBackColor = false;
            button0_1.Click += button0_1_Click;
            // 
            // button0_0
            // 
            button0_0.BackColor = SystemColors.ButtonHighlight;
            button0_0.Location = new Point(8, 42);
            button0_0.Name = "button0_0";
            button0_0.Size = new Size(53, 43);
            button0_0.TabIndex = 9;
            button0_0.UseVisualStyleBackColor = false;
            button0_0.Click += button0_0_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, resetToolStripMenuItem, mainMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(229, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
            // 
            // resetToolStripMenuItem
            // 
            resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            resetToolStripMenuItem.Size = new Size(47, 20);
            resetToolStripMenuItem.Text = "Reset";
            resetToolStripMenuItem.Click += resetToolStripMenuItem_Click;
            // 
            // mainMenuToolStripMenuItem
            // 
            mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            mainMenuToolStripMenuItem.Size = new Size(80, 20);
            mainMenuToolStripMenuItem.Text = "Main menu";
            mainMenuToolStripMenuItem.Click += mainMenuToolStripMenuItem_Click;
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.AutoSize = true;
            labelCurrentPlayer.Location = new Point(12, 24);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(39, 15);
            labelCurrentPlayer.TabIndex = 19;
            labelCurrentPlayer.Text = "Player";
            // 
            // PlayerVersusPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(229, 241);
            Controls.Add(labelCurrentPlayer);
            Controls.Add(button2_2);
            Controls.Add(button2_1);
            Controls.Add(button2_0);
            Controls.Add(button1_2);
            Controls.Add(button1_1);
            Controls.Add(button1_0);
            Controls.Add(button0_2);
            Controls.Add(button0_1);
            Controls.Add(button0_0);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "PlayerVersusPlayer";
            Text = "PlayerVersusPlayer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2_2;
        private Button button2_1;
        private Button button2_0;
        private Button button1_2;
        private Button button1_1;
        private Button button1_0;
        private Button button0_2;
        private Button button0_1;
        private Button button0_0;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
        private Label labelCurrentPlayer;
    }
}