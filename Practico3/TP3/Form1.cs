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

  

        private void TGuardar_Click(object sender, EventArgs e)
        {
           
            MsgBoxResult ask;



            


            

            if (string.IsNullOrWhiteSpace(TApellido.Text) || string.IsNullOrWhiteSpace(TNombre.Text) || string.IsNullOrWhiteSpace(TDni.Text) || string.IsNullOrWhiteSpace(TTelefono.Text))
            {
                MessageBox.Show("el formulario no puede contener campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                ask = (MsgBoxResult)MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ask == MsgBoxResult.Yes)
                {

                    MessageBox.Show("El cliente " + this.TNombre.Text + " " + this.TApellido.Text + " se inserto Correctamente ", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LModificar.Text = this.TNombre.Text + " " + this.TApellido.Text;
                }
                

            }
        }

  
  

        private void TEliminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask = (MsgBoxResult)MessageBox.Show("Est� apunto de eliminar el Cliente: " + LModificar.Text, "Confirmar Eliminaci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (ask == MsgBoxResult.Yes)
            {
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                MessageBox.Show("El Cliente: " + LModificar.Text + " se elimino correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LModificar.Text = "Modificar";
            }
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

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Nombre solo acepta letras", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Apellido solo acepta letras", "Error Apellido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo DNI solo acepta numeros", "Error DNI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                // Set the Handled property to true to cancel the key press
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("El campo Telefono solo acepta Numeros", "Error Telefono", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}