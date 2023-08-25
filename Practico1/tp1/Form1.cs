namespace tp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            this.textBox3.Text = this.textBox2.Text + " " + this.textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox3.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}