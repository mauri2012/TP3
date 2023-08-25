namespace tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

    

        private void BGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TApellido.Text)|| string.IsNullOrWhiteSpace(TNombre.Text)){
                MessageBox.Show("el formulario no puede contener campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                this.textBox3.Text = this.TNombre.Text + " " + this.TApellido.Text;
            }
        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
               
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Apellido solo acepta letras", "Error Apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
             
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Nombre solo acepta letras", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}