namespace ControlAreaVolumen
{
    public partial class frmControlAreaVolumen : Form
    {
        public frmControlAreaVolumen()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Capturando los valores
            double altura = double.Parse(txtAltura.Text);
            double diametro = double.Parse(txtDiametro.Text);

            // Realizando los cálculos
            double radio = diametro / 2;
            double area = (2 * Math.PI * radio) * (radio + altura);
            double volumen = Math.PI * Math.Pow(radio, 2) * altura;

            // Mostrando los resultados en el cuadro de texto
            txtR.Text = "** RESUMEN DE VOLUMEN Y ÁREAS";
            txtR.Text += "\r\nVALOR ALTURA: " + altura.ToString("0.00");
            txtR.Text += "\r\nVALOR DIÁMETRO: " + diametro.ToString("0.00");
            txtR.Text += "\r\n--------------------------------------";
            txtR.Text += "\r\nRADIO: " + radio.ToString("0.00");
            txtR.Text += "\r\nÁREA: " + area.ToString("0.00");
            txtR.Text += "\r\nVOLUMEN: " + volumen.ToString("0.00");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtDiametro.Clear();
            txtR.Clear();
            txtAltura.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Medidas",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
            if(r == DialogResult.Yes)
                this.Close();
        }
    }
}