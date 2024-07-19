namespace ValidadorCnpj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnValidaCnpj_Click(object sender, EventArgs e)
        {
            Validacao valid = new Validacao();
            mtbCnpj.TextMaskFormat = MaskFormat.IncludeLiterals;
            string cnpj = mtbCnpj.Text;
            bool verfal = valid.validarCnpj(cnpj);
            if (verfal)
                MessageBox.Show("CNPJ válido");
            else
                MessageBox.Show("CNPJ inválido");

        }
    }
}
