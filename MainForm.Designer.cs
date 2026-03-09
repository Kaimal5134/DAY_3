namespace WinFormsApp1
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            button_add = new Button();
            button_red = new Button();
            button_del = new Button();
            bindingSource_book = new BindingSource(components);
            bindingSource_aut = new BindingSource(components);
            dataGridView1 = new DataGridView();
            nameBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            authorIdDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            priceBookDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)bindingSource_book).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_aut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button_add
            // 
            button_add.Location = new Point(93, 320);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 0;
            button_add.Text = "add";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_red
            // 
            button_red.Location = new Point(261, 320);
            button_red.Name = "button_red";
            button_red.Size = new Size(94, 29);
            button_red.TabIndex = 1;
            button_red.Text = "redaction";
            button_red.UseVisualStyleBackColor = true;
            button_red.Click += button_red_Click;
            // 
            // button_del
            // 
            button_del.Location = new Point(439, 320);
            button_del.Name = "button_del";
            button_del.Size = new Size(94, 29);
            button_del.TabIndex = 2;
            button_del.Text = "del";
            button_del.UseVisualStyleBackColor = true;
            button_del.Click += button_del_Click;
            // 
            // bindingSource_book
            // 
            bindingSource_book.DataSource = typeof(Models.Book);
            // 
            // bindingSource_aut
            // 
            bindingSource_aut.DataSource = typeof(Models.Author);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameBookDataGridViewTextBoxColumn, authorIdDataGridViewTextBoxColumn, priceBookDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource_book;
            dataGridView1.Location = new Point(58, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(531, 209);
            dataGridView1.TabIndex = 3;
            // 
            // nameBookDataGridViewTextBoxColumn
            // 
            nameBookDataGridViewTextBoxColumn.DataPropertyName = "NameBook";
            nameBookDataGridViewTextBoxColumn.HeaderText = "NameBook";
            nameBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameBookDataGridViewTextBoxColumn.Name = "nameBookDataGridViewTextBoxColumn";
            nameBookDataGridViewTextBoxColumn.ReadOnly = true;
            nameBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorIdDataGridViewTextBoxColumn
            // 
            authorIdDataGridViewTextBoxColumn.DataPropertyName = "AuthorId";
            authorIdDataGridViewTextBoxColumn.DataSource = bindingSource_aut;
            authorIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            authorIdDataGridViewTextBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            authorIdDataGridViewTextBoxColumn.HeaderText = "AuthorId";
            authorIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            authorIdDataGridViewTextBoxColumn.Name = "authorIdDataGridViewTextBoxColumn";
            authorIdDataGridViewTextBoxColumn.ReadOnly = true;
            authorIdDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            authorIdDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            authorIdDataGridViewTextBoxColumn.ValueMember = "Idauthors";
            authorIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceBookDataGridViewTextBoxColumn
            // 
            priceBookDataGridViewTextBoxColumn.DataPropertyName = "PriceBook";
            priceBookDataGridViewTextBoxColumn.HeaderText = "PriceBook";
            priceBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceBookDataGridViewTextBoxColumn.Name = "priceBookDataGridViewTextBoxColumn";
            priceBookDataGridViewTextBoxColumn.ReadOnly = true;
            priceBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button_del);
            Controls.Add(button_red);
            Controls.Add(button_add);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource_book).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_aut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button_add;
        private Button button_red;
        private Button button_del;
        private DataGridView dataGridView1;
        public BindingSource bindingSource_book;
        public BindingSource bindingSource_aut;
        private DataGridViewTextBoxColumn nameBookDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn authorIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceBookDataGridViewTextBoxColumn;
    }
}