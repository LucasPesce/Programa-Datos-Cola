namespace Turnero
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtEdad = new TextBox();
            label5 = new Label();
            lblEspera = new Label();
            btnAtender = new Button();
            btnRegistras = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 85);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 1;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 144);
            label3.Name = "label3";
            label3.Size = new Size(55, 32);
            label3.TabIndex = 2;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 201);
            label4.Name = "label4";
            label4.Size = new Size(66, 32);
            label4.TabIndex = 3;
            label4.Text = "Edad";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(186, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 39);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(186, 78);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(240, 39);
            txtApellido.TabIndex = 5;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(186, 141);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(240, 39);
            txtDNI.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(186, 198);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(240, 39);
            txtEdad.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(522, 25);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 8;
            label5.Text = "En espera";
            // 
            // lblEspera
            // 
            lblEspera.AutoSize = true;
            lblEspera.Font = new Font("Segoe UI", 80F, FontStyle.Regular, GraphicsUnit.Point);
            lblEspera.ForeColor = Color.Indigo;
            lblEspera.Location = new Point(470, 55);
            lblEspera.Name = "lblEspera";
            lblEspera.Size = new Size(234, 142);
            lblEspera.TabIndex = 9;
            lblEspera.Text = "000";
            // 
            // btnAtender
            // 
            btnAtender.BackColor = Color.Violet;
            btnAtender.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtender.Location = new Point(46, 294);
            btnAtender.Name = "btnAtender";
            btnAtender.Size = new Size(606, 96);
            btnAtender.TabIndex = 10;
            btnAtender.Text = "A T E N D E R";
            btnAtender.UseVisualStyleBackColor = false;
            btnAtender.Click += cmdAtender_Click;
            // 
            // btnRegistras
            // 
            btnRegistras.BackColor = Color.Plum;
            btnRegistras.Location = new Point(491, 195);
            btnRegistras.Name = "btnRegistras";
            btnRegistras.Size = new Size(179, 45);
            btnRegistras.TabIndex = 11;
            btnRegistras.Text = "Registrar";
            btnRegistras.UseVisualStyleBackColor = false;
            btnRegistras.Click += cmdRegistras_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(716, 426);
            Controls.Add(btnRegistras);
            Controls.Add(btnAtender);
            Controls.Add(lblEspera);
            Controls.Add(label5);
            Controls.Add(txtEdad);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.Manual;
            Text = "TURNERO";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtEdad;
        private Label label5;
        private Label lblEspera;
        private Button btnAtender;
        private Button btnRegistras;
    }
}