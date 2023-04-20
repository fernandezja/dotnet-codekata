namespace CalcWinform1
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
            button1 = new Button();
            label1 = new Label();
            lblEstado = new Label();
            btnGenerate = new Button();
            panelCalc = new Panel();
            btnRemover = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 26);
            button1.Name = "button1";
            button1.Size = new Size(169, 32);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseMove += button1_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 72);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // lblEstado
            // 
            lblEstado.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblEstado.AutoSize = true;
            lblEstado.BackColor = Color.NavajoWhite;
            lblEstado.Location = new Point(2, 435);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(38, 15);
            lblEstado.TabIndex = 2;
            lblEstado.Text = "label2";
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(317, 26);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(278, 32);
            btnGenerate.TabIndex = 4;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // panelCalc
            // 
            panelCalc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCalc.BackColor = Color.Cornsilk;
            panelCalc.Location = new Point(33, 101);
            panelCalc.Name = "panelCalc";
            panelCalc.Size = new Size(734, 312);
            panelCalc.TabIndex = 5;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(629, 26);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(116, 32);
            btnRemover.TabIndex = 6;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(panelCalc);
            Controls.Add(btnGenerate);
            Controls.Add(lblEstado);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Resize += Form1_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label lblEstado;
        private Button btnGenerate;
        private Panel panelCalc;
        private Button btnRemover;
    }
}