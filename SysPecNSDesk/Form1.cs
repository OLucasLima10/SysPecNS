namespace SysPecNSDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(this.txtNumero1.Text);
            int txtNumero2 = Convert.ToInt32(this.txtNumero2.Text);
            string operacao = cmbOperacao.Text;
            int posicaoOperacao = cmbOperacao.SelectedIndex;
            int Resultado = 0;

            if (posicaoOperacao == 0)
            {
                //int resultado = numero1 * numero2;
            }
            this.resultado.Items.Add($"{operacao} - {posicaoOperacao}");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperacao.SelectedIndex > 4)
            {
                txtNumero2.Enabled = false;
            }

            else
            {
                txtNumero2.Enabled = true;
            }
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero1.Focus();
            btnConfirma.Enabled = false;
        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
            if (txtNumero2.Text.Length > 0)
            {
                btnConfirma.Enabled = true;
            }
            else
            {
                btnConfirma.Enabled= false;
            }
        }
    }
}



