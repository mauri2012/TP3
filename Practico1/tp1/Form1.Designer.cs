namespace tp1
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
            label1 = new Label();
            TApellido = new TextBox();
            BEliminar = new Button();
            BGuardar = new Button();
            TNombre = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "LNombre";
            label1.AutoSize = true;
            label1.Location = new Point(22, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // TApellido
            // 
            TApellido.Location = new Point(89, 99);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(113, 23);
            TApellido.TabIndex = 1;
           
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // BEliminar
            // 
            BEliminar.AccessibleName = "BEliminar";
            BEliminar.Location = new Point(148, 163);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 4;
            BEliminar.Text = "Eliminar";
            BEliminar.Click += BEliminar_Click;
            // 
            // BGuardar
            // 
            BGuardar.AccessibleName = "BGuardar";
            BGuardar.Location = new Point(22, 163);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 3;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(89, 60);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(113, 23);
            TNombre.TabIndex = 5;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // label2
            // 
            label2.AccessibleName = "LApellido";
            label2.AutoSize = true;
            label2.Location = new Point(22, 107);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(282, 55);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(167, 112);
            textBox3.TabIndex = 7;
            // 
            // BSalir
            // 
            BSalir.AccessibleName = "Salir";
            BSalir.Location = new Point(315, 199);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 8;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += Salir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(TNombre);
            Controls.Add(BGuardar);
            Controls.Add(BEliminar);
            Controls.Add(TApellido);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Mi primer form";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button Guardar;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button Salir;
        private TextBox TApellido;
        private Button BGuardar;
        private TextBox TNombre;
        private Button BEliminar;
        private Button BSalir;
    }
}