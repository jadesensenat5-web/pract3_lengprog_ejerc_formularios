namespace ejercicio3
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
            txtValor = new TextBox();
            cmbOrigen = new ComboBox();
            cmbDestino = new ComboBox();
            btnConvertir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtValor
            // 
            txtValor.Location = new Point(39, 90);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(150, 31);
            txtValor.TabIndex = 0;
            // 
            // cmbOrigen
            // 
            cmbOrigen.FormattingEnabled = true;
            cmbOrigen.Items.AddRange(new object[] { "Metros", "Centimetros", "Pulgadas" });
            cmbOrigen.Location = new Point(39, 196);
            cmbOrigen.Name = "cmbOrigen";
            cmbOrigen.Size = new Size(182, 33);
            cmbOrigen.TabIndex = 1;
            // 
            // cmbDestino
            // 
            cmbDestino.FormattingEnabled = true;
            cmbDestino.Items.AddRange(new object[] { "Metros", "Centimetros", "Pulgadas" });
            cmbDestino.Location = new Point(39, 297);
            cmbDestino.Name = "cmbDestino";
            cmbDestino.Size = new Size(182, 33);
            cmbDestino.TabIndex = 2;
            // 
            // btnConvertir
            // 
            btnConvertir.Location = new Point(358, 295);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(112, 34);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 153);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 4;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 250);
            label2.Name = "label2";
            label2.Size = new Size(28, 25);
            label2.TabIndex = 5;
            label2.Text = "A:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 10);
            label3.Name = "label3";
            label3.Size = new Size(386, 44);
            label3.TabIndex = 6;
            label3.Text = "Unidades de Longitud";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnConvertir);
            Controls.Add(cmbDestino);
            Controls.Add(cmbOrigen);
            Controls.Add(txtValor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtValor;
        private ComboBox cmbOrigen;
        private ComboBox cmbDestino;
        private Button btnConvertir;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
