using Microsoft.EntityFrameworkCore;
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
    public partial class MainForm : Form
    {
        Dem030326Context context;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataError += (sender, e) => e.ThrowException = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Dem030326Context();
            context.Books.Include(x => x.Author).Load();

            context.Database.EnsureCreated();
            bindingSource_book.DataSource = context.Books.Local.ToBindingList();
            bindingSource_aut.DataSource = context.Authors.Local.ToBindingList();
     

        }
        private void button_add_Click(object sender, EventArgs e)
        {
            var form = new Form_add();
            form.bindingSource_aut.DataSource = bindingSource_aut.DataSource;
            form.bindingSource_book.DataSource = bindingSource_book.AddNew();
            form.button_Save.Click += Button_Save_Click;
            form.Show();
        }

        private void button_red_Click(object sender, EventArgs e)
        {
            var form = new Form_add();
            form.bindingSource_aut.DataSource = bindingSource_aut.DataSource;
            form.bindingSource_book.DataSource = bindingSource_book.Current;
            form.button_Save.Click += Button_Save_Click;
            form.Show();
        }

        private void Button_Save_Click(object? sender, EventArgs e)
        {
            bindingSource_book.EndEdit();
            var book = (Book)bindingSource_book.Current;
            if (book.AuthorId == 0)
            {
                MessageBox.Show("Выберите автора!");
                return; 
            }
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            bindingSource_book.RemoveCurrent();
            context.SaveChanges();
            dataGridView1.Refresh();
        }
    }
}
