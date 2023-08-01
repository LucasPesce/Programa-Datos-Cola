namespace Turnero
{
    partial class Form2
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
            label1 = new Label();
            lblApellidoNombre = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 35);
            label1.Name = "label1";
            label1.Size = new Size(228, 72);
            label1.TabIndex = 0;
            label1.Text = "Paciente";
            // 
            // lblApellidoNombre
            // 
            lblApellidoNombre.Font = new Font("Segoe UI", 40F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellidoNombre.Location = new Point(31, 107);
            lblApellidoNombre.Name = "lblApellidoNombre";
            lblApellidoNombre.Size = new Size(604, 72);
            lblApellidoNombre.TabIndex = 1;
            lblApellidoNombre.Text = "Apellido, Nombre";
            lblApellidoNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 239);
            label2.Name = "label2";
            label2.Size = new Size(351, 72);
            label2.TabIndex = 2;
            label2.Text = "Consultorio 1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(29F, 71F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(648, 412);
            Controls.Add(label2);
            Controls.Add(lblApellidoNombre);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 40F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(12, 14, 12, 14);
            Name = "Form2";
            StartPosition = FormStartPosition.Manual;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblApellidoNombre;
        private Label label2;
    }
}