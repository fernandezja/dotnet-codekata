namespace WinFormsApp
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
            dataGridView1 = new DataGridView();
            MailId = new DataGridViewTextBoxColumn();
            Asunto = new DataGridViewTextBoxColumn();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            cbTamanioPagina = new ComboBox();
            txtSearch = new TextBox();
            txtPageIndex = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MailId, Asunto });
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 331);
            dataGridView1.TabIndex = 0;
            // 
            // MailId
            // 
            MailId.HeaderText = "MailId";
            MailId.Name = "MailId";
            MailId.ReadOnly = true;
            // 
            // Asunto
            // 
            Asunto.HeaderText = "Asunto";
            Asunto.Name = "Asunto";
            Asunto.ReadOnly = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(695, 35);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 23);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente >";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(505, 35);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 23);
            btnAnterior.TabIndex = 2;
            btnAnterior.Text = "< Anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // cbTamanioPagina
            // 
            cbTamanioPagina.FormattingEnabled = true;
            cbTamanioPagina.Items.AddRange(new object[] { "5", "10", "25", "50", "100" });
            cbTamanioPagina.Location = new Point(378, 35);
            cbTamanioPagina.Name = "cbTamanioPagina";
            cbTamanioPagina.Size = new Size(121, 23);
            cbTamanioPagina.TabIndex = 3;
            cbTamanioPagina.SelectedIndexChanged += cbTamanioPagina_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(361, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtPageIndex
            // 
            txtPageIndex.Location = new Point(611, 35);
            txtPageIndex.Name = "txtPageIndex";
            txtPageIndex.Size = new Size(49, 23);
            txtPageIndex.TabIndex = 5;
            txtPageIndex.TextChanged += txtPageIndex_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPageIndex);
            Controls.Add(txtSearch);
            Controls.Add(cbTamanioPagina);
            Controls.Add(btnAnterior);
            Controls.Add(btnSiguiente);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSiguiente;
        private Button btnAnterior;
        private ComboBox cbTamanioPagina;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn MailId;
        private DataGridViewTextBoxColumn Asunto;
        private TextBox txtPageIndex;
    }
}