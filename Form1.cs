using Microsoft.VisualBasic.Logging;
using System;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_avtorization_Click(object sender, EventArgs e)
        {
            string username = textBox_lgin.Text.Trim();
            string password = textBox_pass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            using (var db = new Dem030326Context())
            {
                var librarian = db.Libraries
                    .FirstOrDefault(l => l.Login == username && l.Password == password);

                if (librarian == null)
                {
                    MessageBox.Show("Неверный логин или пароль.");
                    return;
                }
                MessageBox.Show($"Добро пожаловать, {librarian.Surname}  {librarian.Name}  {librarian.Secname}!");
                this.Hide();
                MainForm ff = new MainForm();
                ff.Show();



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm ff = new RegisterForm();
            ff.Show();
        }
    }
}

