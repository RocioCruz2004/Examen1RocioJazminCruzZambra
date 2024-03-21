namespace gestionEmpleados.VISTA.EmpleadoVistas
{
    partial class EmpleadoEditarVista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 215);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(379, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // button1
            // 
            button1.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            button1.Location = new Point(562, 27);
            button1.Name = "button1";
            button1.Size = new Size(169, 48);
            button1.TabIndex = 35;
            button1.Text = "SELECCIONAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(357, 282);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(132, 48);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Gill Sans MT", 12F, FontStyle.Bold);
            btnGuardar.Location = new Point(136, 282);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(132, 48);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(165, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(379, 23);
            textBox3.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(165, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(379, 23);
            textBox2.TabIndex = 31;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(165, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 23);
            textBox1.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label5.Location = new Point(24, 215);
            label5.Name = "label5";
            label5.Size = new Size(133, 18);
            label5.TabIndex = 29;
            label5.Text = "FECHA CONTRATO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label3.Location = new Point(64, 160);
            label3.Name = "label3";
            label3.Size = new Size(63, 18);
            label3.TabIndex = 28;
            label3.Text = "SALARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label2.Location = new Point(62, 103);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 27;
            label2.Text = "PUESTO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 9F, FontStyle.Bold);
            label1.Location = new Point(72, 41);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 26;
            label1.Text = "PERSONA:";
            // 
            // EmpleadoEditarVista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "EmpleadoEditarVista";
            Text = "EmpleadoEditarVista";
            Load += EmpleadoEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}