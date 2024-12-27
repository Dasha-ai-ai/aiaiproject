namespace ai_ai
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            Reg = new Button();
            Log = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(55, 273);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(197, 85);
            button1.TabIndex = 0;
            button1.Text = "computer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSteelBlue;
            button2.Font = new Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(493, 273);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(191, 85);
            button2.TabIndex = 1;
            button2.Text = "2 player";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(255, 108);
            label1.Name = "label1";
            label1.Size = new Size(263, 49);
            label1.TabIndex = 2;
            label1.Text = "TIC-TAC-TOE";
            // 
            // Reg
            // 
            Reg.Location = new Point(0, 2);
            Reg.Name = "Reg";
            Reg.Size = new Size(49, 36);
            Reg.TabIndex = 3;
            Reg.Text = "Reg";
            Reg.UseVisualStyleBackColor = true;
            Reg.Click += Reg_Click;
            // 
            // Log
            // 
            Log.Location = new Point(55, 2);
            Log.Name = "Log";
            Log.Size = new Size(47, 36);
            Log.TabIndex = 4;
            Log.Text = "Log";
            Log.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(801, 434);
            Controls.Add(Log);
            Controls.Add(Reg);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "tic-tac-toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Button Reg;
        private Button Log;
    }
}
