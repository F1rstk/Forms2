namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Criação de variaveis.
            double operedorA = double.Parse(txtOperadorA.Text);
            double operedorB = double.Parse(txtOperadorB.Text);
            double resultado = 0;

            if (rdbAdicao.Checked)
            {
                resultado = operedorA + operedorB;
                txtEspressao.Text = operedorA + "+" + operedorB;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbSubtracacao.Checked)
            {
                resultado = operedorA - operedorB;
                txtEspressao.Text = operedorA + "-" + operedorB;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbMultiplicacao.Checked)
            {
                resultado = operedorA * operedorB;
                txtEspressao.Text = operedorA + "*" + operedorB;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbDivisao.Checked)
            {
                resultado = operedorA / operedorB;
                txtEspressao.Text = operedorA + "/" + operedorB;
                txtResultado.Text = resultado.ToString();
            }
            else if (rdbResto.Checked)
            {
                resultado = operedorA % operedorB;
                txtEspressao.Text = operedorA + "%" + operedorB;
                txtResultado.Text = resultado.ToString();
            }
        }
    }
}