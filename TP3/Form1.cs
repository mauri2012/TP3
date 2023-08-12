using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TP2
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double parseValue;
            bool DNIValidate = !double.TryParse(this.TDni.Text, out parseValue);
            MsgBoxResult ask;



            inputValidation(DNIValidate, "DNI", this.TDni);
            inputValidation(!this.ValidateString(this.TApellido.Text), "Apellido", this.TApellido);
            inputValidation(!this.ValidateString(this.TNombre.Text), "Nombre", this.TNombre);


            this.LModificar.Text = this.TNombre.Text + " " + this.TApellido.Text;

            if (this.TApellido.Text == "" || this.TApellido.Text == "" || this.TApellido.Text == "")
            {
                MessageBox.Show("el formulario no puede contener campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                ask = (MsgBoxResult)MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == MsgBoxResult.Yes)
                {

                    MessageBox.Show("El cliente " + this.TNombre.Text + " " + this.TApellido.Text + " se inserto Correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void inputValidation(bool validacion, string campo, TextBox textBoxN)
        {
            double parseValue;
            string type;
            if (!double.TryParse(textBoxN.Text, out parseValue))
            {
                type = "numeric";
            }
            else
            {
                type = "char";
            }
            if (validacion)
            {
                textBoxN.Text = "";
                MessageBox.Show(campo + " field only allows " + type + " values", campo + "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateString(string input)
        {
            return input.All(c => char.IsLetter(c) || c == ' ');
        }

        private void TEliminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (ask == MsgBoxResult.Yes)
            {
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                MessageBox.Show("El Cliente: " + LModificar.Text + " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Modificar";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            if (RBVaron.Checked)
            {
                pictureBox1.BackgroundImage = Image.FromFile("../../bendy-man-holding-something.png");
            }
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            if (RBMujer.Checked)
            {

                pictureBox1.BackgroundImage = Image.FromFile("../../outline-seated-woman.png");
            }
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}