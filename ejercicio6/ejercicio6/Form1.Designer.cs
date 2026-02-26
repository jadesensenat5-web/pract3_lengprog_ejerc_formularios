namespace ejercicio6
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
            txtPerfecto = new MaskedTextBox();
            btnVerificarPerfecto = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtPerfecto
            // 
            txtPerfecto.Location = new Point(94, 67);
            txtPerfecto.Mask = "99999";
            txtPerfecto.Name = "txtPerfecto";
            txtPerfecto.Size = new Size(150, 31);
            txtPerfecto.TabIndex = 0;
            txtPerfecto.ValidatingType = typeof(int);
            // 
            // btnVerificarPerfecto
            // 
            btnVerificarPerfecto.Location = new Point(114, 119);
            btnVerificarPerfecto.Name = "btnVerificarPerfecto";
            btnVerificarPerfecto.Size = new Size(112, 34);
            btnVerificarPerfecto.TabIndex = 1;
            btnVerificarPerfecto.Text = "Verificar";
            btnVerificarPerfecto.UseVisualStyleBackColor = true;
            btnVerificarPerfecto.Click += btnVerificarPerfecto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 24);
            label1.Name = "label1";
            label1.Size = new Size(264, 29);
            label1.TabIndex = 2;
            label1.Text = "Ingresa el Numero";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 266);
            Controls.Add(label1);
            Controls.Add(btnVerificarPerfecto);
            Controls.Add(txtPerfecto);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtPerfecto;
        private Button btnVerificarPerfecto;
        private Label label1;
    }
}
