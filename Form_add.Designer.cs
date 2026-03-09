namespace WinFormsApp1
{
    partial class Form_add
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
            button_Save = new Button();
            button2 = new Button();
            textBox_name = new TextBox();
            bindingSource_book = new BindingSource(components);
            textBox_price = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBox_author = new ComboBox();
            bindingSource_aut = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource_book).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_aut).BeginInit();
            SuspendLayout();
            // 
            // button_Save
            // 
            button_Save.Location = new Point(77, 251);
            button_Save.Name = "button_Save";
            button_Save.Size = new Size(94, 43);
            button_Save.TabIndex = 0;
            button_Save.Text = "Save";
            button_Save.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(77, 302);
            button2.Name = "button2";
            button2.Size = new Size(94, 43);
            button2.TabIndex = 1;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox_name
            // 
            textBox_name.DataBindings.Add(new Binding("Text", bindingSource_book, "NameBook", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox_name.DataBindings.Add(new Binding("DataContext", bindingSource_book, "NameBook", true));
            textBox_name.Location = new Point(46, 53);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(157, 27);
            textBox_name.TabIndex = 2;
            // 
            // bindingSource_book
            // 
            bindingSource_book.DataSource = typeof(Models.Book);
            // 
            // textBox_price
            // 
            textBox_price.DataBindings.Add(new Binding("Text", bindingSource_book, "PriceBook", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox_price.DataBindings.Add(new Binding("DataContext", bindingSource_book, "PriceBook", true));
            textBox_price.Location = new Point(49, 199);
            textBox_price.Name = "textBox_price";
            textBox_price.Size = new Size(157, 27);
            textBox_price.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 25);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 94);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 5;
            label2.Text = "author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 173);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 6;
            label3.Text = "price";
            // 
            // comboBox_author
            // 
            comboBox_author.DataBindings.Add(new Binding("SelectedValue", bindingSource_book, "AuthorId", true));
            comboBox_author.DataSource = bindingSource_aut;
            comboBox_author.DisplayMember = "Name";
            comboBox_author.FormattingEnabled = true;
            comboBox_author.Location = new Point(50, 130);
            comboBox_author.Name = "comboBox_author";
            comboBox_author.Size = new Size(156, 28);
            comboBox_author.TabIndex = 7;
            comboBox_author.ValueMember = "Idauthors";
            // 
            // bindingSource_aut
            // 
            bindingSource_aut.DataSource = typeof(Models.Author);
            // 
            // Form_add
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(286, 415);
            Controls.Add(comboBox_author);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_price);
            Controls.Add(textBox_name);
            Controls.Add(button2);
            Controls.Add(button_Save);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_add";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_add";
            ((System.ComponentModel.ISupportInitialize)bindingSource_book).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource_aut).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button_Save;
        private Button button2;
        private TextBox textBox_name;
        private TextBox textBox_price;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox_author;
        public BindingSource bindingSource_book;
        public BindingSource bindingSource_aut;
    }
}