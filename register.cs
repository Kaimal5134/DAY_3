using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void bthRegister_Click(object sender, EventArgs e)
        {
            {
                string login = txtLogin.Text.Trim();
                string password = txtPassword.Text;
                string surname = txtSurname.Text.Trim();
                string name = txtName.Text.Trim();
                string secname = txtSecname.Text.Trim();

                if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("Заполните все обязательные поля!");
                    return;
                }

                using (var db = new Dem030326Context())
                {
                    if (db.Libraries.Any(l => l.Login == login))
                    {
                        MessageBox.Show("Такой логин уже занят!");
                        return;
                    }

                    var newUser = new Library
                    {
                        Surname = surname,
                        Name = name,
                        Secname = secname,
                        Login = login,
                        Password = password
                    };

                    db.Libraries.Add(newUser);
                    db.SaveChanges();
                }

                MessageBox.Show("Регистрация прошла успешно!");
                this.Close();
                Form1 ff = new Form1();
                ff.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 dd = new Form1();
            dd.Show();
        }
    }
}
