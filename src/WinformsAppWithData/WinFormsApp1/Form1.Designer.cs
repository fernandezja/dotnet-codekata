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
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            emailRepositoryBindingSource = new BindingSource(components);
            emailRepositoryBindingSource1 = new BindingSource(components);
            emailRepositoryBindingSource2 = new BindingSource(components);
            emailRepositoryBindingSource3 = new BindingSource(components);
            btnSearch = new Button();
            txtSearch = new TextBox();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource3).BeginInit();
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
            // emailRepositoryBindingSource
            // 
            emailRepositoryBindingSource.DataSource = typeof(App.Core.Data.EmailRepository);
            // 
            // emailRepositoryBindingSource1
            // 
            emailRepositoryBindingSource1.DataSource = typeof(App.Core.Data.EmailRepository);
            // 
            // emailRepositoryBindingSource2
            // 
            emailRepositoryBindingSource2.DataSource = typeof(App.Core.Data.EmailRepository);
            // 
            // emailRepositoryBindingSource3
            // 
            emailRepositoryBindingSource3.DataSource = typeof(App.Core.Data.EmailRepository);
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
            // 
            // listView1
            // 
            listView1.Location = new Point(221, 71);
            listView1.Name = "listView1";
            listView1.Size = new Size(197, 349);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)emailRepositoryBindingSource3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private BindingSource emailRepositoryBindingSource;
        private BindingSource emailRepositoryBindingSource1;
        private BindingSource emailRepositoryBindingSource2;
        private BindingSource emailRepositoryBindingSource3;
        private Button btnSearch;
        private TextBox txtSearch;
        private ListView listView1;
    }
}