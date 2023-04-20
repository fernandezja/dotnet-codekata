using Calc.Core.Interfaces;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;

        private List<Button> _lista;

        public Form1(ICalc calc)
        {
            _calc = calc;

            _calc.Procesando += Calc_Procesando_Demo;
            _calc.Termino += Calc_Termino_Demo;

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Add(1, 1);

            label1.Text = resultado.ToString();
        }

        private void Calc_Procesando_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Procesando....";
        }

        private void Calc_Termino_Demo(object sender, EventArgs e)
        {
            lblEstado.Text = "Termino!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            lblEstado.Text = $"Resize! {DateTime.Now.ToLongTimeString()}";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            lblEstado.Text = $"MouseMove! {DateTime.Now.ToLongTimeString()}";
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var lista = new List<Button>();

            for (int i = 0; i < 10; i++)
            {
                var b = new Button();
                b.Text = i.ToString();

                b.Location = new Point((i * 40), (i * 40));


                panelCalc.Controls.Add(b);
                lista.Add(b);
            }

            var bAdd = new Button();
            bAdd.Text = "+";

            bAdd.Location = new Point(100, 200);
            panelCalc.Controls.Add(bAdd);

            lista.Add(bAdd);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }
    }
}