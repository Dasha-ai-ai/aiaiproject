namespace ai_ai
{
    partial class Form1
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
            button = new Button();
            textBox1 = new TextBox();
            UserName = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            Password = new Label();
            Email = new Label();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(21, 210);
            button.Name = "button";
            button.Size = new Size(75, 23);
            button.TabIndex = 0;
            button.Text = "OK";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // UserName
            // 
            UserName.Location = new Point(12, 41);
            UserName.Name = "UserName";
            UserName.Size = new Size(100, 23);
            UserName.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 4;
            label1.Text = "User Name";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(12, 86);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(12, 151);
            Email.Name = "Email";
            Email.Size = new Size(36, 15);
            Email.TabIndex = 6;
            Email.Text = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(126, 245);
            Controls.Add(Email);
            Controls.Add(Password);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(UserName);
            Controls.Add(textBox1);
            Controls.Add(button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button;
        private TextBox textBox1;
        private TextBox UserName;
        private TextBox textBox3;
        private Label label1;
        private Label Password;
        private Label Email;
    }
}