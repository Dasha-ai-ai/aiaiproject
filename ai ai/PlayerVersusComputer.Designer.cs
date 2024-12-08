namespace ai_ai
{
    partial class PlayerVersusComputer
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
            button0_0 = new Button();
            button0_1 = new Button();
            button0_2 = new Button();
            button1_0 = new Button();
            button1_1 = new Button();
            button1_2 = new Button();
            button2_0 = new Button();
            button2_1 = new Button();
            button2_2 = new Button();
            labelCurrentPlayer = new Label();
            menuStrip1 = new MenuStrip();
            helpToolStripMenuItem = new ToolStripMenuItem();
            resetToolStripMenuItem = new ToolStripMenuItem();
            mainMenuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button0_0
            // 
            button0_0.Location = new Point(11, 46);
            button0_0.Name = "button0_0";
            button0_0.Size = new Size(53, 43);
            button0_0.TabIndex = 0;
            button0_0.UseVisualStyleBackColor = true;
            button0_0.Click += button0_0_Click;
            // 
            // button0_1
            // 
            button0_1.Location = new Point(92, 46);
            button0_1.Name = "button0_1";
            button0_1.Size = new Size(53, 43);
            button0_1.TabIndex = 1;
            button0_1.UseVisualStyleBackColor = true;
            button0_1.Click += button0_1_Click;
            // 
            // button0_2
            // 
            button0_2.Location = new Point(173, 46);
            button0_2.Name = "button0_2";
            button0_2.Size = new Size(53, 43);
            button0_2.TabIndex = 2;
            button0_2.UseVisualStyleBackColor = true;
            button0_2.Click += button0_2_Click;
            // 
            // button1_0
            // 
            button1_0.Location = new Point(11, 122);
            button1_0.Name = "button1_0";
            button1_0.Size = new Size(53, 43);
            button1_0.TabIndex = 3;
            button1_0.UseVisualStyleBackColor = true;
            button1_0.Click += button1_0_Click;
            // 
            // button1_1
            // 
            button1_1.Location = new Point(92, 122);
            button1_1.Name = "button1_1";
            button1_1.Size = new Size(53, 43);
            button1_1.TabIndex = 4;
            button1_1.UseVisualStyleBackColor = true;
            button1_1.Click += button1_1_Click;
            // 
            // button1_2
            // 
            button1_2.Location = new Point(173, 122);
            button1_2.Name = "button1_2";
            button1_2.Size = new Size(53, 43);
            button1_2.TabIndex = 5;
            button1_2.UseVisualStyleBackColor = true;
            button1_2.Click += button1_2_Click;
            // 
            // button2_0
            // 
            button2_0.Location = new Point(11, 198);
            button2_0.Name = "button2_0";
            button2_0.Size = new Size(53, 43);
            button2_0.TabIndex = 6;
            button2_0.UseVisualStyleBackColor = true;
            button2_0.Click += button2_0_Click;
            // 
            // button2_1
            // 
            button2_1.Location = new Point(92, 198);
            button2_1.Name = "button2_1";
            button2_1.Size = new Size(53, 43);
            button2_1.TabIndex = 7;
            button2_1.UseVisualStyleBackColor = true;
            button2_1.Click += button2_1_Click;
            // 
            // button2_2
            // 
            button2_2.Location = new Point(173, 198);
            button2_2.Name = "button2_2";
            button2_2.Size = new Size(53, 43);
            button2_2.TabIndex = 8;
            button2_2.UseVisualStyleBackColor = true;
            button2_2.Click += button2_2_Click;
            // 
            // labelCurrentPlayer
            // 
            labelCurrentPlayer.AutoSize = true;
            labelCurrentPlayer.Location = new Point(12, 24);
            labelCurrentPlayer.Name = "labelCurrentPlayer";
            labelCurrentPlayer.Size = new Size(39, 15);
            labelCurrentPlayer.TabIndex = 9;
            labelCurrentPlayer.Text = "Player";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, resetToolStripMenuItem, mainMenuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(238, 24);
            menuStrip1.TabIndex = 10;
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
            // PlayerVersusComputer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(238, 251);
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
            Name = "PlayerVersusComputer";
            Text = "PlayerVersusComputer";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button0_0;
        private Button button0_1;
        private Button button0_2;
        private Button button1_0;
        private Button button1_1;
        private Button button1_2;
        private Button button2_0;
        private Button button2_1;
        private Button button2_2;
        private Label labelCurrentPlayer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem resetToolStripMenuItem;
        private ToolStripMenuItem mainMenuToolStripMenuItem;
    }
}