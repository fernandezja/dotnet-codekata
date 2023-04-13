using Calc.Core.Interfaces;

namespace CalcWinform1
{
    public partial class Form1 : Form
    {
        private ICalc _calc;

        public Form1(ICalc calc)
        {
            _calc = calc;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = _calc.Add(1, 1);

            label1.Text = resultado.ToString();
        }
    }
}