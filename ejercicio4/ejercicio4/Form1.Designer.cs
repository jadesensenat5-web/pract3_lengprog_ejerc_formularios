namespace ejercicio4
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
            txtPalabra = new TextBox();
            btnVerificar = new Button();
            SuspendLayout();
            // 
            // txtPalabra
            // 
            txtPalabra.Location = new Point(82, 95);
            txtPalabra.Name = "txtPalabra";
            txtPalabra.Size = new Size(150, 31);
            txtPalabra.TabIndex = 0;
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(82, 150);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(163, 34);
            btnVerificar.TabIndex = 1;
            btnVerificar.Text = "¿Es Polindromo?";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVerificar);
            Controls.Add(txtPalabra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPalabra;
        private Button btnVerificar;
    }
}
