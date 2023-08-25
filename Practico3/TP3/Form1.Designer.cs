namespace TP2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LApellido = new Label();
            LNombre = new Label();
            TNombre = new TextBox();
            TDni = new TextBox();
            TApellido = new TextBox();
            TGuardar = new Button();
            TEliminar = new Button();
            TTelefono = new TextBox();
            LNaranja = new CheckBox();
            LVisa = new CheckBox();
            LMastercard = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            RBMujer = new RadioButton();
            RBVaron = new RadioButton();
            BSalir = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AccessibleName = "LNya";
            LNya.AutoSize = true;
            LNya.Location = new Point(7, 20);
            LNya.Name = "LNya";
            LNya.Size = new Size(107, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AccessibleName = "LMocdificar";
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(120, 20);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "Modificar";
            // 
            // LDni
            // 
            LDni.AccessibleName = "LDni";
            LDni.AutoSize = true;
            LDni.Location = new Point(6, 118);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // LApellido
            // 
            LApellido.AccessibleName = "LApellido";
            LApellido.AutoSize = true;
            LApellido.Location = new Point(7, 89);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            LApellido.Click += label4_Click;
            // 
            // LNombre
            // 
            LNombre.AccessibleName = "LNombre";
            LNombre.AutoSize = true;
            LNombre.Location = new Point(7, 55);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 4;
            LNombre.Text = "Nombre";
            // 
            // TNombre
            // 
            TNombre.Location = new Point(76, 47);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 5;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDni
            // 
            TDni.AccessibleName = "TDni";
            TDni.Location = new Point(76, 110);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 6;
            TDni.TextChanged += textBox2_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.AccessibleName = "TApellido";
            TApellido.Location = new Point(76, 81);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TGuardar
            // 
            TGuardar.AccessibleName = "TGuardar";
            TGuardar.Image = TP3.Properties.Resources.bouncy_uploading_files_and_folders_to_cloud_storage__1_;
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(42, 356);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(110, 53);
            TGuardar.TabIndex = 8;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += button1_Click;
            // 
            // TEliminar
            // 
            TEliminar.AccessibleName = "TEliminar";
            TEliminar.Image = TP3.Properties.Resources._3d_fluency_delete_folder__1_;
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(172, 356);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(110, 53);
            TEliminar.TabIndex = 9;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(76, 148);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 10;
            TTelefono.KeyPress += TTelefono_KeyPress;
            // 
            // LNaranja
            // 
            LNaranja.AutoSize = true;
            LNaranja.Location = new Point(111, 255);
            LNaranja.Name = "LNaranja";
            LNaranja.Size = new Size(67, 19);
            LNaranja.TabIndex = 11;
            LNaranja.Text = "Naranja";
            LNaranja.UseVisualStyleBackColor = true;
            // 
            // LVisa
            // 
            LVisa.AutoSize = true;
            LVisa.Location = new Point(111, 230);
            LVisa.Name = "LVisa";
            LVisa.Size = new Size(47, 19);
            LVisa.TabIndex = 12;
            LVisa.Text = "Visa";
            LVisa.UseVisualStyleBackColor = true;
            LVisa.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // LMastercard
            // 
            LMastercard.AutoSize = true;
            LMastercard.Location = new Point(111, 205);
            LMastercard.Name = "LMastercard";
            LMastercard.Size = new Size(85, 19);
            LMastercard.TabIndex = 13;
            LMastercard.Text = "Mastercard";
            LMastercard.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 188);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 14;
            label1.Text = "Tarjeta de creditos";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = TP3.Properties.Resources.bendy_man_holding_something;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(311, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 175);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(414, 246);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 16;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(333, 246);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 17;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // BSalir
            // 
            BSalir.Image = TP3.Properties.Resources.network_arrow_letters;
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(333, 356);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(115, 53);
            BSalir.TabIndex = 18;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 152);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 19;
            label2.Text = "Telefono";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(LNaranja);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(LVisa);
            panel1.Controls.Add(LMastercard);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(LNombre);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LApellido);
            panel1.Location = new Point(33, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 289);
            panel1.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(506, 438);
            Controls.Add(panel1);
            Controls.Add(BSalir);
            Controls.Add(RBVaron);
            Controls.Add(RBMujer);
            Controls.Add(pictureBox1);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            ImeMode = ImeMode.Hiragana;
            Name = "Form1";
            Text = "pequeño formulario";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LApellido;
        private Label LNombre;
        private TextBox TNombre;
        private TextBox TDni;
        private TextBox TApellido;
        private Button TGuardar;
        private Button TEliminar;
        private TextBox TTelefono;
        private CheckBox LNaranja;
        private CheckBox LVisa;
        private CheckBox LMastercard;
        private Label label1;
        private PictureBox pictureBox1;
        private RadioButton RBMujer;
        private RadioButton RBVaron;
        private Button BSalir;
        private Label label2;
        private Panel panel1;
    }
}