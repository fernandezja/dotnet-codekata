using App.Core.Data;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void CargarDatos()
        {
            txtSeleccion.Text = string.Empty;
            var emails = (new EmailRepository()).Buscar(txtSearch.Text);

            //Listbox
            listBox1.DataSource = emails;
            listBox1.DisplayMember = "Asunto";
            //listBox1.ValueMember = "Id";


            //ListView
            listView1.View = View.Details;
            listView1.Items.Clear();
            foreach (var email in emails)
            {
                ListViewItem item = new ListViewItem(email.Asunto);
                item.ForeColor = Color.Red;
                item.Checked = true;

                item.SubItems.Add(email.Id.ToString());
                listView1.Items.Add(item);
            }


            //checkedListBox
            checkedListBox1.Items.Clear();
            foreach (var email in emails)
            {
                checkedListBox1.Items.Add(email.Asunto);
            }

            //DataGrid
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = emails;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}