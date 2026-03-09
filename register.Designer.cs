namespace WinFormsApp1
{
    partial class RegisterForm
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
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            txtSecname = new TextBox();
            bthRegister = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(67, 90);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(199, 23);
            txtLogin.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(64, 146);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(199, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(69, 201);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(199, 23);
            txtSurname.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(71, 253);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 23);
            txtName.TabIndex = 3;
            // 
            // txtSecname
            // 
            txtSecname.Location = new Point(73, 300);
            txtSecname.Name = "txtSecname";
            txtSecname.Size = new Size(199, 23);
            txtSecname.TabIndex = 4;
            // 
            // bthRegister
            // 
            bthRegister.Location = new Point(79, 372);
            bthRegister.Name = "bthRegister";
            bthRegister.Size = new Size(132, 23);
            bthRegister.TabIndex = 5;
            bthRegister.Text = "Зарегестрироватся";
            bthRegister.UseVisualStyleBackColor = true;
            bthRegister.Click += bthRegister_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 386);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 7;
            label1.Text = "Фамилия";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 128);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 8;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 183);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 235);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 10;
            label4.Text = "Логин";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(79, 282);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 11;
            label5.Text = "Пароль";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 449);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(bthRegister);
            Controls.Add(txtSecname);
            Controls.Add(txtName);
            Controls.Add(txtSurname);
            Controls.Add(txtPassword);
            Controls.Add(txtLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLogin;
        private TextBox txtPassword;
        private TextBox txtSurname;
        private TextBox txtName;
        private TextBox txtSecname;
        private Button bthRegister;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}