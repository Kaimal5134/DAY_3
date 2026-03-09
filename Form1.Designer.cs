namespace WinFormsApp1
{
    partial class Form1
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
            button_avtorization = new Button();
            textBox_lgin = new TextBox();
            textBox_pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // button_avtorization
            // 
            button_avtorization.Location = new Point(95, 284);
            button_avtorization.Margin = new Padding(3, 4, 3, 4);
            button_avtorization.Name = "button_avtorization";
            button_avtorization.Size = new Size(146, 73);
            button_avtorization.TabIndex = 0;
            button_avtorization.Text = "Войти";
            button_avtorization.UseVisualStyleBackColor = true;
            button_avtorization.Click += button_avtorization_Click;
            // 
            // textBox_lgin
            // 
            textBox_lgin.Location = new Point(72, 141);
            textBox_lgin.Margin = new Padding(3, 4, 3, 4);
            textBox_lgin.Name = "textBox_lgin";
            textBox_lgin.Size = new Size(196, 27);
            textBox_lgin.TabIndex = 1;
            // 
            // textBox_pass
            // 
            textBox_pass.Location = new Point(72, 232);
            textBox_pass.Margin = new Padding(3, 4, 3, 4);
            textBox_pass.Name = "textBox_pass";
            textBox_pass.Size = new Size(196, 27);
            textBox_pass.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 108);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 3;
            label1.Text = "login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 205);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 4;
            label2.Text = "password";
            // 
            // button1
            // 
            button1.Location = new Point(95, 388);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(146, 31);
            button1.TabIndex = 5;
            button1.Text = "Регистация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(333, 452);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_pass);
            Controls.Add(textBox_lgin);
            Controls.Add(button_avtorization);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Avtorization";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_avtorization;
        private TextBox textBox_lgin;
        private TextBox textBox_pass;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}
