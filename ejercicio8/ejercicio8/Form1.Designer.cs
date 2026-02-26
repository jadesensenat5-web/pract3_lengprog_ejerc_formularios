namespace ejercicio8
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
            txtOracion = new TextBox();
            btnContar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtOracion
            // 
            txtOracion.Location = new Point(12, 43);
            txtOracion.Multiline = true;
            txtOracion.Name = "txtOracion";
            txtOracion.Size = new Size(260, 103);
            txtOracion.TabIndex = 0;
            // 
            // btnContar
            // 
            btnContar.Location = new Point(12, 161);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(200, 34);
            btnContar.TabIndex = 1;
            btnContar.Text = "Contar Palabras";
            btnContar.UseVisualStyleBackColor = true;
            btnContar.Click += btnContar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(34, 231);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(96, 25);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Palabras: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 356);
            Controls.Add(lblResultado);
            Controls.Add(btnContar);
            Controls.Add(txtOracion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOracion;
        private Button btnContar;
        private Label lblResultado;
    }
}
