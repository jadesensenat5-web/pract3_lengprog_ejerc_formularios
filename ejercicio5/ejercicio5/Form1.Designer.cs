namespace ejercicio5
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
            txtNumeroPrimo = new MaskedTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNumeroPrimo
            // 
            txtNumeroPrimo.Location = new Point(31, 82);
            txtNumeroPrimo.Mask = "99999";
            txtNumeroPrimo.Name = "txtNumeroPrimo";
            txtNumeroPrimo.Size = new Size(179, 31);
            txtNumeroPrimo.TabIndex = 0;
            txtNumeroPrimo.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Location = new Point(31, 140);
            button1.Name = "button1";
            button1.Size = new Size(168, 34);
            button1.TabIndex = 1;
            button1.Text = "Verificar Primo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 296);
            Controls.Add(button1);
            Controls.Add(txtNumeroPrimo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox txtNumeroPrimo;
        private Button button1;
    }
}
