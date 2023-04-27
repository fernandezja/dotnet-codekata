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
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Demo", "Colum2 Demo" }, -1);
            listBox1 = new ListBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            listView1 = new ListView();
            colAsunto = new ColumnHeader();
            colId = new ColumnHeader();
            checkedListBox1 = new CheckedListBox();
            dataGridView1 = new DataGridView();
            colDgAsunto = new DataGridViewTextBoxColumn();
            txtSeleccion = new TextBox();
            label1 = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "aasasd, ddd, " });
            listBox1.Location = new Point(36, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(163, 349);
            listBox1.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(247, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(67, 41);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Buscar";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(36, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(205, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colAsunto, colId });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem2 });
            listView1.Location = new Point(221, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(318, 349);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colAsunto
            // 
            colAsunto.Text = "Asunto 1";
            // 
            // colId
            // 
            colId.Text = "Identificador";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Item 1" });
            checkedListBox1.Location = new Point(557, 71);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(196, 346);
            checkedListBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colDgAsunto });
            dataGridView1.Location = new Point(769, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(378, 344);
            dataGridView1.TabIndex = 5;
            // 
            // colDgAsunto
            // 
            colDgAsunto.DataPropertyName = "Asunto";
            colDgAsunto.HeaderText = "Asunto";
            colDgAsunto.Name = "colDgAsunto";
            colDgAsunto.ReadOnly = true;
            // 
            // txtSeleccion
            // 
            txtSeleccion.Location = new Point(46, 507);
            txtSeleccion.Name = "txtSeleccion";
            txtSeleccion.Size = new Size(493, 23);
            txtSeleccion.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 487);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 7;
            label1.Text = "Seleccion:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(44, 536);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Guardar";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 615);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(txtSeleccion);
            Controls.Add(dataGridView1);
            Controls.Add(checkedListBox1);
            Controls.Add(listView1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnSearch;
        private TextBox txtSearch;
        private ListView listView1;
        private BindingSource bindingSource1;
        private ColumnHeader colAsunto;
        private ColumnHeader colId;
        private CheckedListBox checkedListBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colDgAsunto;
        private TextBox txtSeleccion;
        private Label label1;
        private Button btnSave;
    }
}